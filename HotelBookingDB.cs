using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01421653_Project
{
    public class HotelBookingDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=LAPTOP-IJ2R5L45;Initial Catalog=HotelManagement;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
