using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Events.Model;
using System.Data.SqlClient;

namespace _4Events.Database
{
    public class ReserveringContext : IReserveringRepository
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
            List<Reservering> result = new List<Reservering>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT r.*, a.Naam AS MainAccountNaam " +
                                "FROM RESERVERING r " +
                                "INNER JOIN RESERVERING_ACCOUNT ra on r.ID = ra.ReserveringID " +
                                "INNER JOIN ACCOUNT a on ra.AccountID = a.ID " +
                                "WHERE MainAccount = 1 " +
                                "ORDER BY r.ID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateReserveringFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public List<Reservering> GetReserveringenByEvent(int EventID)
        {
            List<Reservering> result = new List<Reservering>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT r.*, a.Naam AS MainAccountNaam " +
                                "FROM RESERVERING r " +
                                "INNER JOIN RESERVERING_ACCOUNT ra on r.ID = ra.ReserveringID " +
                                "INNER JOIN ACCOUNT a on ra.AccountID = a.ID " +
                                "WHERE EventID = " +  EventID +
                                "ORDER BY r.ID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateReserveringFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public void UpdateReservering(Reservering reservering)
        {

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

        private Reservering CreateReserveringFromReader(SqlDataReader reader)
        {
            Reservering reservering = new Reservering()
            {
                ID = Convert.ToInt32(reader["ID"]),
                MainAccountNaam = Convert.ToString(reader["MainAccountNaam"]),
                EventID = Convert.ToInt32(reader["EventID"]),
                Datum = Convert.ToDateTime(reader["Datum"]),
                Ingechecked = Convert.ToBoolean(reader["Ingechecked"]),
                Betaald = Convert.ToBoolean(reader["Betaald"])
            };

            return reservering;
        }
    }
}
