﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;
using System.Data.SqlClient;

namespace _4Events.Database
{
    public class MediaContext : IMediaContext
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

        public List<Bericht> GetReacties()
        {
            throw new NotImplementedException();
        }

        public bool InsertBericht(Bericht bericht)
        {
            using(SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Bericht";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
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
                Bestand = (reader["Bestand"] == DBNull.Value) ? null : (byte?[])(reader["Bestand"]),
                ReplyTo = (reader["ReplyTo"] == DBNull.Value) ? null : (int?)(reader["ReplyTo"]),
                Tags = Convert.ToString(reader["Tags"]),
                Tekst = Convert.ToString(reader["Tekst"])
            };

            return bericht;
        }
    }
}
