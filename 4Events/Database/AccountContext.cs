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

        public Account GetByUsername(string username)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE Username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
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
            throw new NotImplementedException();
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
    }
}
