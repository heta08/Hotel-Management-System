using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01421653_Project
{
    public class RoomDB
    {
        SqlConnection connection = HotelBookingDB.GetConnection();

        
        public int IncrementId()
        {
            try
            {
                connection.Open();
                int customerID = 0;
                string id="";
                
                string countStatement = "SELECT MAX(Booking_id) FROM Room_Booking";
                
                SqlCommand countCommand =
                     new SqlCommand(countStatement, connection);

                
                id = countCommand.ExecuteScalar().ToString();

                if (id == "" || id == null)
                {
                    return customerID;
                }
                else
                {
                    customerID = int.Parse(id);
                    return customerID;
                }
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            
            
        }

        public void AddRoom(Room room)
        {
            
            string insertStatement =
                "INSERT INTO Room_Booking " +
                "(Booking_id, Customer_name, Phone, Room_type, Number_of_guests, Checkin_date, Checkout_date) " +
                "VALUES (@Booking_id, @Customer_name, @Phone, @Room_type, @Number_of_guests, @Checkin_date, @Checkout_date)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@Booking_id", this.IncrementId()+1);
            insertCommand.Parameters.AddWithValue(
                "@Customer_name", room.CustomerName);
            insertCommand.Parameters.AddWithValue(
                "@Phone", room.Phone);
            insertCommand.Parameters.AddWithValue(
                "@Room_type", room.RoomType);
            insertCommand.Parameters.AddWithValue(
                "@Number_of_guests", room.NumOfGuests);
            insertCommand.Parameters.AddWithValue(
                "@Checkin_date", room.CheckinDate);
            insertCommand.Parameters.AddWithValue(
                "@Checkout_date", room.CheckoutDate);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public string[] GetBookingDetails(int id)
        {
            string selectStatement = "SELECT * FROM Room_Booking WHERE Booking_id =" +id;
            
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            
            string[] details = new string[7];
            try
            {
                connection.Open();
                selectCommand.ExecuteNonQuery();

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                      
                        details[0] = reader["Booking_id"].ToString();
                        details[1] = reader["Customer_name"].ToString();
                        details[2] = reader["Phone"].ToString();
                        details[3] = reader["Room_type"].ToString();
                        details[4] = reader["Number_of_guests"].ToString();
                        details[5] = reader["Checkin_date"].ToString();
                        details[6] = reader["Checkout_date"].ToString();
                        
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return details;
        }

    }
}
