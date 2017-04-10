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
        public List<Plek> GetAllKampeerPlekByLocatie(Locatie locatie)
        {
            List<Plek> result = new List<Plek>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Plek WHERE LocatieID = @locatieid ORDER BY Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@locatieid", locatie.ID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreatePlekFromReader(reader));
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
                                "WHERE MainAccount = 1 " +
                                "AND EventID = " +  EventID +
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

        public bool UpdateReservering(Reservering reservering)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE RESERVERING SET Betaald = @betaald, Ingechecked = @ingechecked WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", reservering.ID);
                    command.Parameters.AddWithValue("@betaald", reservering.Betaald);
                    command.Parameters.AddWithValue("@ingechecked", reservering.Ingechecked);

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
        private Plek CreatePlekFromReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            Plek plek = new Plek()
            {
                ID = id,
                LocatieID = Convert.ToInt32(reader["LocatieID"]),
                specificatie = GetSpecificatie(id)
            };
            return plek;
        }
        private Specificatie GetSpecificatie(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT Naam FROM Specificatie INNER JOIN Specificatie_Plek ON (SpecificatieID = ID) WHERE PlekID = @plekid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@plekid", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           return (Specificatie)Enum.Parse(typeof(Specificatie), Convert.ToString(reader["Naam"]));
                        }
                    }
                }
            }
            return Specificatie.Green;
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

        public bool InsertReservering(Reservering reservering)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO RESERVERING (EventID, Datum, Betaald) VALUES (@EventID, @Datum, @Ingechecked)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EventID", reservering.EventID);
                    command.Parameters.AddWithValue("@Datum", reservering.Datum);
                    command.Parameters.AddWithValue("@Ingechecked", reservering.Ingechecked);

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
    }
}
