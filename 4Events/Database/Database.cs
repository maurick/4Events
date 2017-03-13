using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Events.Database
{
    public class Database
    {
        private static readonly string connectionString = "Data Source=DESKTOP-72SE5L8\\SQLEXPRESS;Initial Catalog=SpacedRepetitionLearning;Integrated Security=True";

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
