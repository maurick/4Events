using System;
using System.Collections.Generic;
using _4Events.Model;
using System.Data.SqlClient;

namespace _4Events.Database
{
    public class AccountContext : IAccountContext<Account>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll()
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

        public Account GetById(int id)
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

        public Account GetByEmail(string email)
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

        public Account Insert(Account newItem)
        {
            using (SqlConnection connection = Database.Connection)
            {

                newItem.Password = EncryptPassword(newItem.Password);

                string query = "INSERT INTO Account (Functie, Naam, Plaats, Straat, Huisnr, Postcode, Email, Wachtwoord)" +
                    " VALUES(" +
                    " 'Bezoeker', @naam, @plaats, @straat, @huisnr, @postcode, @email, @wachtwoord)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

        public bool Update(Account newItem)
        {
            throw new NotImplementedException();
        }

        private Account CreateAccountFromReader(SqlDataReader reader)
        {
            Account account = new Account
            {
                ID = Convert.ToInt32(reader["ID"]),
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
