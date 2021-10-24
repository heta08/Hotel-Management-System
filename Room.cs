using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01421653_Project
{
    public class Room
    {
        public Room()
        {

        }

        public int BookingId { get; set; }

        public string CustomerName { get; set; }

        public string Phone { get; set; }

        public string RoomType { get; set; }

        public int NumOfGuests { get; set; }

        public string CheckinDate { get; set; }

        public string CheckoutDate { get; set; }
    }
}
