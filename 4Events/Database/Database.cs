using System.Data.SqlClient;

namespace _4Events.Database
{
    public class Database
    {
        private static readonly string connectionString = "Data Source=mssql.fhict.local;Initial Catalog=dbi342472;User ID=dbi342472;Password=PTS24Events";

        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
    }
}
