
namespace N01421653_Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNoOfPeople = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePickerTable = new System.Windows.Forms.DateTimePicker();
            this.lblBookingFor = new System.Windows.Forms.Label();
            this.radioButtonLunch = new System.Windows.Forms.RadioButton();
            this.radioButtonDinner = new System.Windows.Forms.RadioButton();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNumOfPeople = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetBookingDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.Location = new System.Drawing.Point(36, 36);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(139, 25);
            this.lblReservationID.TabIndex = 1;
            this.lblReservationID.Text = "Reservation ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(36, 80);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(36, 127);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 25);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblNoOfPeople
            // 
            this.lblNoOfPeople.AutoSize = true;
            this.lblNoOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfPeople.Location = new System.Drawing.Point(36, 176);
            this.lblNoOfPeople.Name = "lblNoOfPeople";
            this.lblNoOfPeople.Size = new System.Drawing.Size(173, 25);
            this.lblNoOfPeople.TabIndex = 4;
            this.lblNoOfPeople.Text = "Number Of People";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(36, 225);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // dateTimePickerTable
            // 
            this.dateTimePickerTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTable.Location = new System.Drawing.Point(240, 225);
            this.dateTimePickerTable.Name = "dateTimePickerTable";
            this.dateTimePickerTable.Size = new System.Drawing.Size(244, 30);
            this.dateTimePickerTable.TabIndex = 6;
            this.dateTimePickerTable.Tag = "Date";
            // 
            // lblBookingFor
            // 
            this.lblBookingFor.AutoSize = true;
            this.lblBookingFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingFor.Location = new System.Drawing.Point(36, 276);
            this.lblBookingFor.Name = "lblBookingFor";
            this.lblBookingFor.Size = new System.Drawing.Size(117, 25);
            this.lblBookingFor.TabIndex = 7;
            this.lblBookingFor.Text = "Booking For";
            // 
            // radioButtonLunch
            // 
            this.radioButtonLunch.AutoSize = true;
            this.radioButtonLunch.Checked = true;
            this.radioButtonLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLunch.Location = new System.Drawing.Point(240, 276);
            this.radioButtonLunch.Name = "radioButtonLunch";
            this.radioButtonLunch.Size = new System.Drawing.Size(87, 29);
            this.radioButtonLunch.TabIndex = 8;
            this.radioButtonLunch.TabStop = true;
            this.radioButtonLunch.Text = "Lunch";
            this.radioButtonLunch.UseVisualStyleBackColor = true;
            // 
            // radioButtonDinner
            // 
            this.radioButtonDinner.AutoSize = true;
            this.radioButtonDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDinner.Location = new System.Drawing.Point(369, 276);
            this.radioButtonDinner.Name = "radioButtonDinner";
            this.radioButtonDinner.Size = new System.Drawing.Size(90, 29);
            this.radioButtonDinner.TabIndex = 9;
            this.radioButtonDinner.Text = "Dinner";
            this.radioButtonDinner.UseVisualStyleBackColor = true;
            // 
            // txtReservationID
            // 
            this.txtReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationID.Location = new System.Drawing.Point(240, 36);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(244, 30);
            this.txtReservationID.TabIndex = 10;
            this.txtReservationID.Tag = "Reservation ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(240, 80);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(244, 30);
            this.txtCustomerName.TabIndex = 11;
            this.txtCustomerName.Tag = "Customer Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(240, 127);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(244, 30);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.Tag = "Phone Number";
            // 
            // txtNumOfPeople
            // 
            this.txtNumOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfPeople.Location = new System.Drawing.Point(240, 176);
            this.txtNumOfPeople.Name = "txtNumOfPeople";
            this.txtNumOfPeople.Size = new System.Drawing.Size(244, 30);
            this.txtNumOfPeople.TabIndex = 13;
            this.txtNumOfPeople.Tag = "Number Of People";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(41, 323);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 96);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(238, 323);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 96);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(600, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 96);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetBookingDetails
            // 
            this.btnGetBookingDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGetBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBookingDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetBookingDetails.Location = new System.Drawing.Point(405, 323);
            this.btnGetBookingDetails.Name = "btnGetBookingDetails";
            this.btnGetBookingDetails.Size = new System.Drawing.Size(136, 96);
            this.btnGetBookingDetails.TabIndex = 16;
            this.btnGetBookingDetails.Text = "Get Booking Details";
            this.btnGetBookingDetails.UseVisualStyleBackColor = false;
            this.btnGetBookingDetails.Click += new System.EventHandler(this.btnGetBookingDetails_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetBookingDetails);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNumOfPeople);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.radioButtonDinner);
            this.Controls.Add(this.radioButtonLunch);
            this.Controls.Add(this.lblBookingFor);
            this.Controls.Add(this.dateTimePickerTable);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNoOfPeople);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblReservationID);
            this.Name = "Form3";
            this.Text = "Table Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNoOfPeople;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTable;
        private System.Windows.Forms.Label lblBookingFor;
        private System.Windows.Forms.RadioButton radioButtonLunch;
        private System.Windows.Forms.RadioButton radioButtonDinner;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNumOfPeople;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetBookingDetails;
    }
}