using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;
using System.Data.SqlClient;

namespace _4Events.Database
{
    public class ReserveringContext : IReserveringContext
    {
        public List<Locatie> GetAllLocaties()
        {
            List<Locatie> result = new List<Locatie>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Locatie ORDER BY Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateLocatieFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public List<Reservering> GetAllReserveringen()
        {
            throw new NotImplementedException();
        }

        private Locatie CreateLocatieFromReader(SqlDataReader reader)
        {
            Locatie locatie = new Locatie()
            {
                ID = Convert.ToInt32(reader["ID"]),
                Straat = Convert.ToString(reader["Straat"]),
                Huisnummer = Convert.ToInt32(reader["Huisnr"]),
                HuisnummerToevoeging = Convert.ToString(reader["Huisnr_Toevoeging"]),
                Plaats = Convert.ToString(reader["Plaats"]),
                Postcode = Convert.ToString(reader["Postcode"])
            };

            return locatie;
        }
    }
}
