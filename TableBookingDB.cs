using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01421653_Project
{
    public class TableBookingDB
    {
        SqlConnection connection = HotelBookingDB.GetConnection();

        public int IncrementId()
        {
            try
            {
                connection.Open();
                int customerID = 0;
                string id = "";
                
                string countStatement = "SELECT MAX(Reservation_id) FROM Table_Booking";
                
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
        public void AddData(TableBooking tableBooking)
        {
            string insertStatement =
                "INSERT INTO Table_Booking " +
                "(Reservation_id, Customer_name, Phone, Number_of_people, Date, Booking_for) " +
                "VALUES (@Reservation_id, @Customer_name, @Phone, @Number_of_people, @Date, @Booking_for)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@Reservation_id", this.IncrementId() + 1);
            insertCommand.Parameters.AddWithValue(
                "@Customer_name", tableBooking.CustomerName);
            insertCommand.Parameters.AddWithValue(
                "@Phone", tableBooking.Phone);
            insertCommand.Parameters.AddWithValue(
                "@Number_of_people", tableBooking.NumOfPeople);
            insertCommand.Parameters.AddWithValue(
                "@Date", tableBooking.R_Date);
            insertCommand.Parameters.AddWithValue(
                "@Booking_for", tableBooking.BookingFor);
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

        public string[] GetReservationDetails(int id)
        {
            string selectStatement = "SELECT * FROM Table_Booking WHERE Reservation_id =" + id;

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

                        details[0] = reader["Reservation_id"].ToString();
                        details[1] = reader["Customer_name"].ToString();
                        details[2] = reader["Phone"].ToString();
                        details[3] = reader["Number_of_people"].ToString();
                        details[4] = reader["Date"].ToString();
                        details[5] = reader["Booking_for"].ToString();

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
