using System;
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
        public List<Bericht> GetAll()
        {
            List<Bericht> result = new List<Bericht>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Bericht ORDER BY Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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

        private Bericht CreateBerichtFromReader(SqlDataReader reader)
        {
            Bericht bericht = new Bericht()
            {
                ID = Convert.ToInt32(reader["ID"]),
                Bestand = (byte[])(reader["Bestand"]),
                Tags = Convert.ToString(reader["Tags"]),
                Tekst = Convert.ToString(reader["Tekst"])
            };

            return bericht;
        }
    }
}
