﻿using System;
using System.Collections.Generic;
using _4Events.Model;
using System.Data.SqlClient;

namespace _4Events.Database
{
    public class BeheerContext : IBeheerContext
    {
        public bool DeleteAccount(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM ACCOUNT WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        if(e.ErrorCode != 0)
                        {
                            return false;
                        }
                        throw;
                    }
                }
            }
            return true;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> result = new List<Account>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account ORDER BY Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateAccountFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public Account GetAccountById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return CreateAccountFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }

        public Account GetAccountByEmail(string email)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE Email = @email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return CreateAccountFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }

        public Account InsertAccount(Account newItem)
        {
            using (SqlConnection connection = Database.Connection)
            {

                newItem.Password = EncryptPassword(newItem.Password);

                string query = "INSERT INTO Account (Functie, Naam, Plaats, Straat, Huisnr, Postcode, Email, Wachtwoord)" +
                    " VALUES(" +
                    " @functie, @naam, @plaats, @straat, @huisnr, @postcode, @email, @wachtwoord)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@functie", newItem.Functie.ToString());
                    command.Parameters.AddWithValue("@naam", newItem.Naam);
                    command.Parameters.AddWithValue("@plaats", newItem.Plaats);
                    command.Parameters.AddWithValue("@straat", newItem.Straat);
                    command.Parameters.AddWithValue("@huisnr", newItem.Huisnummer);
                    command.Parameters.AddWithValue("@postcode", newItem.Postcode);
                    command.Parameters.AddWithValue("@email", newItem.Email);
                    command.Parameters.AddWithValue("@wachtwoord", newItem.Password);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        // TODO: make this work.
                        if (e.ErrorCode != 0)
                        {
                            return null;
                        }
                       throw;
                    }
                }
            }
            return newItem;
        }

        public bool UpdateAccount(Account newItem)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE ACCOUNT SET Functie = @functie, Naam = @naam, Plaats = @plaats, Straat = @straat, Huisnr = @huisnr, Postcode = @postcode, Email = @email WHERE ID = @id; ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", newItem.ID);
                    command.Parameters.AddWithValue("@functie", newItem.Functie.ToString());
                    command.Parameters.AddWithValue("@naam", newItem.Naam);
                    command.Parameters.AddWithValue("@plaats", newItem.Plaats);
                    command.Parameters.AddWithValue("@straat", newItem.Straat);
                    command.Parameters.AddWithValue("@huisnr", newItem.Huisnummer);
                    command.Parameters.AddWithValue("@postcode", newItem.Postcode);
                    command.Parameters.AddWithValue("@email", newItem.Email);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        if (e.ErrorCode != 0)
                        {
                            return false;
                        }
                        throw;
                    }
                }
            }
            return true;
        }

        public List<Event> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Event GetEventById(int id)
        {
            throw new NotImplementedException();
        }

        public Event InsertEvent(Event newItem)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvent(Event newItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        private Event CreateEventFromReader(SqlDataReader reader)
        {
            Event newEvent = new Event
            {
                //TODO
            };

            return newEvent;
        }

        private Account CreateAccountFromReader(SqlDataReader reader)
        {
            Account account = new Account
            {
                ID = Convert.ToInt32(reader["ID"]),
                Functie = (Enums.Functie)Enum.Parse(typeof(Enums.Functie), Convert.ToString(reader["Functie"])),
                Naam = Convert.ToString(reader["Naam"]),
                Email = Convert.ToString(reader["Email"]),
                Huisnummer = Convert.ToInt32(reader["Huisnr"]),
                HuisnummerToevoeging = Convert.ToString(reader["Huisnr_Toevoeging"]),
                Plaats = Convert.ToString(reader["Plaats"]),
                Postcode = Convert.ToString(reader["Postcode"]),
                Straat = Convert.ToString(reader["Straat"]),
                Password = Convert.ToString(reader["Wachtwoord"])
            };
            return account;
        }

        private string EncryptPassword(string inputString)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(inputString);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
    }
}