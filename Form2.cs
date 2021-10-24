using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N01421653_Project
{
    public partial class Form2 : Form
    {
        Room room = new Room();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                RoomDB roomDB = new RoomDB();
                //room.BookingId = int.Parse(txBookingId.Text);
                room.BookingId = roomDB.IncrementId();
                room.CustomerName = txtCustomerName.Text;
                room.Phone = txtPhone.Text;
                room.RoomType = comboBoxRoomType.SelectedItem.ToString();
                room.NumOfGuests = int.Parse(txtNumberOfGuests.Text);
                room.CheckinDate = dateTimePickerCheckin.Text;
                room.CheckoutDate = dateTimePickerCheckout.Text;
                roomDB.AddRoom(room);

                MessageBox.Show("Room booking successful");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txBookingId.Text = "";
            txtCustomerName.Text = "";
            txtPhone.Text = "";
            txtNumberOfGuests.Text = "";
            comboBoxRoomType.Text = "--Select--";
            dateTimePickerCheckin.Value = DateTime.Now;
            dateTimePickerCheckout.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetBookingDetails_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txBookingId) && Validator.IsInt32(txBookingId))
            {
                RoomDB roomDB = new RoomDB();
                int id = int.Parse(txBookingId.Text);
                string[] display = roomDB.GetBookingDetails(id);
                txBookingId.Text = display[0];
                txtCustomerName.Text = display[1];
                txtPhone.Text = display[2];
                comboBoxRoomType.Text = display[3];
                txtNumberOfGuests.Text = display[4];
                dateTimePickerCheckin.Value = DateTime.Parse(display[5]);
                dateTimePickerCheckout.Value = DateTime.Parse(display[6]);

            }

            /*for (int i = 0; i < display.Length; i++)
            {
                txtCustomerName.Text += display[i];
            }*/

        }

        /*private void btnUpdate_Click(object sender, EventArgs e)
        {
            RoomDB roomDB = new RoomDB();
            int updateId = int.Parse(txBookingId.Text);

            roomDB.Update(updateId,room);
        }*/

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtCustomerName) &&
                Validator.IsPresent(txtNumberOfGuests) &&
                Validator.IsInt32(txtNumberOfGuests) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(comboBoxRoomType) &&
                Validator.IsPresent(dateTimePickerCheckin) &&
                Validator.IsPresent(dateTimePickerCheckout);
        }
    }
}
