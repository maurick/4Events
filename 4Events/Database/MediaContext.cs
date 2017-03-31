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
    public class MediaContext : IMediaRepository
    {
        public bool DeleteBericht(int id)
        {
            throw new NotImplementedException();
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
                        while (reader.Read())
                        {
                            result.Add(CreateBerichtFromReader(reader));
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

        public bool InsertBericht(Bericht bericht)
        {
            using(SqlConnection connection = Database.Connection)
            {
                string query;

                if (bericht.Bestand == null)
                {
                    query = "INSERT INTO Bericht (ReplyTo, Tags, Tekst, AccountID) VALUES (@replyTo, @tags, @tekst, @accountid)";
                }
                else
                {
                    query = "INSERT INTO Bericht (ReplyTo, Bestand, Tags, Tekst, AccountID) VALUES (@replyTo, @bestand, @tags, @tekst, @accountid)";
                }

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    if(bericht.Bestand != null)
                    {
                        command.Parameters.Add("@bestand", SqlDbType.VarBinary).Value = bericht.Bestand;
                    }

                    if(bericht.ReplyTo == null)
                    {
                        command.Parameters.AddWithValue("@replyto", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@replyto", bericht.ReplyTo);
                    }

                    command.Parameters.AddWithValue("@tags", bericht.Tags);
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

        private Bericht CreateBerichtFromReader(SqlDataReader reader)
        {
            Bericht bericht = new Bericht()
            {
                ID = Convert.ToInt32(reader["ID"]),
                Bestand = (reader["Bestand"] == DBNull.Value) ? null : (byte[])(reader["Bestand"]),
                ReplyTo = (reader["ReplyTo"] == DBNull.Value) ? null : (int?)(reader["ReplyTo"]),
                Tags = Convert.ToString(reader["Tags"]),
                Tekst = Convert.ToString(reader["Tekst"]),
                AccountID = Convert.ToInt32(reader["AccountID"])
            };

            bericht.AmountLikes = GetLikesAmount(bericht);

            return bericht;
        }
    }
}
