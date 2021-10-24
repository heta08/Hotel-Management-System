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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtReservationID.Text = "";
            txtCustomerName.Text = "";
            txtPhone.Text = "";
            txtNumOfPeople.Text = "";
            dateTimePickerTable.Value = DateTime.Now;

            

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                TableBooking tableBooking = new TableBooking();
                TableBookingDB tableBookingDB = new TableBookingDB();
                tableBooking.ReservationId = tableBookingDB.IncrementId();
                tableBooking.CustomerName = txtCustomerName.Text;
                tableBooking.Phone = txtPhone.Text;
                tableBooking.NumOfPeople = int.Parse(txtNumOfPeople.Text);
                tableBooking.R_Date = dateTimePickerTable.Text;


                if (radioButtonLunch.Checked)
                {
                    tableBooking.BookingFor = radioButtonLunch.Text;
                }
                else
                {
                    tableBooking.BookingFor = radioButtonDinner.Text;
                }

                tableBookingDB.AddData(tableBooking);

                MessageBox.Show("Room booking successful");
            }
                
        }

        private void btnGetBookingDetails_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtReservationID) && Validator.IsInt32(txtReservationID))
            {
                TableBookingDB tableBookingDB = new TableBookingDB();
                int id = int.Parse(txtReservationID.Text);
                string[] display = tableBookingDB.GetReservationDetails(id);
                txtReservationID.Text = display[0];
                txtCustomerName.Text = display[1];
                txtPhone.Text = display[2];
                txtNumOfPeople.Text = display[3];
                dateTimePickerTable.Text = display[4];
                if (radioButtonLunch.Checked)
                {
                    radioButtonLunch.Text = display[5];
                }
                else
                {
                    radioButtonDinner.Text = display[5];
                }
                /* r.Value = DateTime.Parse(display[5]);
                 dateTimePickerCheckout.Value = DateTime.Parse(display[6]);*/
            }

        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtCustomerName) &&
                Validator.IsPresent(txtPhone) &&
                Validator.IsPresent(txtNumOfPeople) &&
                Validator.IsInt32(txtNumOfPeople) &&
                Validator.IsPresent(dateTimePickerTable);
        }
    }
}
