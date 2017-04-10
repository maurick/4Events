using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;
using System.Data.SqlClient;

namespace _4Events.Database
{
    /// <summary>
    /// Bevat alle databasecode voor het verhuur systeem.
    /// </summary>
    class VerhuurContext : IVerhuurRepository
    {

        public List<Exemplaar> GetExemplaren(int amount)
        {
            List<Exemplaar> result = new List<Exemplaar>();

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT TOP (@amount) * FROM Exemplaar";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@amount", amount);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateExemplaarFromReader(reader));
                        }
                    }
                }
            }

            return result;
        }

        public bool InsertVerhuur(Verhuur verhuur)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO VERHUUR (AccountID, ExemplaarID, DatumBegin, DatumEind) VALUES (@accountid, @exemplaarid, @datumbegin, @datumeind)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@exemplaarid", verhuur.Exemplaar.ExemplaarID);
                    command.Parameters.AddWithValue("@accountid", verhuur.Account.ID);
                    command.Parameters.AddWithValue("@datumbegin", verhuur.DatumBegin);
                    command.Parameters.AddWithValue("@datumeind", verhuur.DatumEind);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private Product GetProductByID(int id)
        {
            Product result = null;

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Product WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = CreateProductFromReader(reader);
                        }
                    } 
                }
            }

            return result;
        }

        private Verhuur CreateVerhuurFromReader(SqlDataReader reader)
        {
            Verhuur verhuur;
            return verhuur = new Verhuur
            {
                Account = new Account()
                {
                    ID = Convert.ToInt32(reader["AccountID"])
                },
                DatumBegin = Convert.ToDateTime(reader["DatumBegin"]),
                DatumEind = Convert.ToDateTime(reader["DatumEind"]),
                Exemplaar = new Exemplaar
                {
                    ExemplaarID = Convert.ToInt32(reader["ExemplaarID"])
                }
            };
        }

        private Product CreateProductFromReader(SqlDataReader reader)
        {
            Product product;
            return product = new Product
            {
                Naam = Convert.ToString(reader["Naam"]),
                Prijs = Convert.ToDecimal(reader["Prijs"]),
                ProductID = Convert.ToInt32(reader["ID"])
            };
        }

        private Exemplaar CreateExemplaarFromReader(SqlDataReader reader)
        {
            Exemplaar exemplaar;
            return exemplaar = new Exemplaar
            {
                ExemplaarID = Convert.ToInt32(reader["ID"]),
                Aantal = Convert.ToInt32(reader["Exemplaar_Nummer"]),
                Product = GetProductByID(Convert.ToInt32(reader["ProductID"]))
            };
        }

        public List<Verhuur> GetVerhuurByAccount(Account account)
        {
            List<Verhuur> result = new List<Verhuur>();

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM VERHUUR WHERE AccountID = @accountid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accountid", account.ID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(CreateVerhuurFromReader(reader));
                            }
                        }
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                }
            }

            return result;
        }

        public bool DeleteVerhuurById(int id, int exemplaarid)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM VERHUUR WHERE AccountID = @id AND ExemplaarID = @exemplaarid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@exemplaarid", exemplaarid);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
