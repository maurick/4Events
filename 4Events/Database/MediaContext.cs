using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;
using System.Data.SqlClient;
using System.Data;

namespace _4Events.Database
{
    /// <summary>
    /// Bevat alle databasecode voor het mediasharigsysteem.
    /// </summary>
    public class MediaContext : IMediaRepository
    {
        public bool DeleteBericht(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM BERICHT WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        //return false;
                        throw;
                    }
                    
                }
            }
            return true;
        }

        public List<Bericht> GetBerichten(int aantal)
        {
            List<Bericht> result = new List<Bericht>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT TOP (@aantal) * FROM Bericht ORDER BY Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@aantal", aantal);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                result.Add(CreateBerichtFromReader(reader));
                            }
                        }
                        catch (Exception)
                        {
                            // return null;?
                            throw;
                        }
                        
                    }
                }
            }
            return result;
        }

        public int GetLikesAmount(Bericht bericht)
        {
            int result = 0;
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT COUNT(*) FROM [LIKE] WHERE BerichtID = @berichtid;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@berichtid", bericht.ID);

                    try
                    {
                        result = (int)command.ExecuteScalar();
                    }
                    catch (SqlException)
                    {
                        // return 0;
                        throw;
                    }
                }
            }
            return result;
        }

        public List<Bericht> GetReacties()
        {
            throw new NotImplementedException();
        }

        public Bestand GetBestandById(int id)
        {
            Bestand result = null;

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT Bestand FROM BESTAND WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        result = new Bestand() { ID = id, BestandArray = (byte[])command.ExecuteScalar() };
                    }
                    catch (SqlException)
                    {
                        // return 0;
                        throw;
                    }

                }
            }

            return result;
        }

        public int GetReportAmount(Bericht bericht)
        {
            int result = 0;

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT COUNT(*) FROM REPORT WHERE BERICHTID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", bericht.ID);

                    try
                    {
                        result = (int)command.ExecuteScalar();
                    }
                    catch (SqlException)
                    {
                        // return 0;
                        throw;
                    }
                    
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bestand"></param>
        /// <returns>BestandID</returns>
        private int InsertBestand(Bestand bestand, SqlConnection connection)
        {
            int result = 0;
            string query = "INSERT INTO BESTAND (ID, Bestand) VALUES (@id, @bestand)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@bestand", bestand.BestandArray);
                command.Parameters.AddWithValue("@id", bestand.ID);

                try
                {
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT MAX(ID) FROM BESTAND";
                    command.Parameters.Clear();
                    result = (int)command.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return result;
        }

        private int InsertCategorie(Categorie categorie, SqlConnection connection)
        {
            int result = -1;
            string query = "INSERT INTO CATEGORIE (Naam, MainCategorieID) VALUES (@naam, @maincategorieid)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@naam", categorie.Naam);

                if(categorie.MainCategorieID == null)
                {
                    command.Parameters.AddWithValue("@maincategorieid", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@maincategorieid", categorie.MainCategorieID);
                }

                

                try
                {
                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT MAX(ID) FROM CATEGORIE";
                    command.Parameters.Clear();
                    result = (int)command.ExecuteScalar();
                }
                catch (SqlException)
                {
                    command.CommandText = "SELECT ID FROM CATEGORIE WHERE NAAM = @naam";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@naam", categorie.Naam);
                    result = (int)command.ExecuteScalar();
                }
            }

            return result;
        }

        public bool InsertBericht(Bericht bericht)
        {
            using(SqlConnection connection = Database.Connection)
            {
                int categorieid;
                string query;

                if (bericht.Bestand == null)
                {
                    query = "INSERT INTO Bericht (ReplyTo, CategorieID, Tekst, AccountID) VALUES (@replyTo, @categorieid, @tekst, @accountid)";
                }
                else
                {
                    query = "INSERT INTO Bericht (ReplyTo, BestandID, CategorieID, Tekst, AccountID) VALUES (@replyTo, @bestandid, @categorieid, @tekst, @accountid)";
                }

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    if(bericht.Bestand != null)
                    {
                        Bestand bestand = new Bestand
                        {
                            ID = GetMaxBerichtId() + 1,
                            BestandArray = bericht.Bestand.BestandArray
                        };
                        command.Parameters.AddWithValue("@bestandid", InsertBestand(bestand, connection));
                    }

                    if(bericht.ReplyTo == null)
                    {
                        command.Parameters.AddWithValue("@replyto", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@replyto", bericht.ReplyTo);
                    }

                    categorieid = InsertCategorie(bericht.Categorie, connection);

                    command.Parameters.AddWithValue("@categorieid", categorieid);
                    

                    command.Parameters.AddWithValue("@tekst", bericht.Tekst);
                    command.Parameters.AddWithValue("@accountid", bericht.AccountID);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                        // return false;
                    }
                }
            }
            return true;
        }

        public bool InsertLike(Bericht bericht, Account account)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO [LIKE] (AccountID, BerichtID) VALUES (@accountid, @berichtid)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accountid", account.ID);
                    command.Parameters.AddWithValue("@berichtid", bericht.ID);

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

        public bool InsertReport(Bericht bericht, Account account)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO [Report] (AccountID, BerichtID) VALUES (@accountid, @berichtid)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accountid", account.ID);
                    command.Parameters.AddWithValue("@berichtid", bericht.ID);

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

        private int GetMaxBerichtId()
        {
            int result = 0;

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT MAX(ID) FROM BERICHT";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        result = (int)command.ExecuteScalar();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            return result;
        }

        private Categorie GetCategorieById(int id)
        {
            Categorie result = null;

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM CATEGORIE WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                result = CreateCategorieFromReader(reader);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                }
            }
            return result;
        }

        private Bericht CreateBerichtFromReader(SqlDataReader reader)
        {
            Bericht bericht = new Bericht()
            {
                ID = Convert.ToInt32(reader["ID"]),
                ReplyTo = (reader["ReplyTo"] == DBNull.Value) ? null : (int?)(reader["ReplyTo"]),
                Tekst = Convert.ToString(reader["Tekst"]),
                AccountID = Convert.ToInt32(reader["AccountID"]),
                Categorie = GetCategorieById(Convert.ToInt32(reader["CategorieID"])),
                Bestand = GetBestandIdByBerichtId(Convert.ToInt32(reader["ID"]))
            };

            bericht.AmountLikes = GetLikesAmount(bericht);

            return bericht;
        }

        private Categorie CreateCategorieFromReader(SqlDataReader reader)
        {
            Categorie categorie = new Categorie()
            {
                ID = Convert.ToInt32(reader["ID"]),
                MainCategorieID = (reader["MainCategorieID"] == DBNull.Value) ? null : (int?)(reader["MainCategorieID"]),
                Naam = Convert.ToString(reader["Naam"])
            };

            return categorie;
        }


        private Bestand GetBestandIdByBerichtId(int berichtid)
        {
            Bestand result = null;

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Bestand WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", berichtid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                result = new Bestand() { ID = Convert.ToInt32(reader["ID"]) };
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                }
            }
            return result;
        }
    }
}
