
namespace N01421653_Project
{
    partial class Form2
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
            this.lblBookingId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txBookingId = new System.Windows.Forms.TextBox();
            this.lblNoOfGuests = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.txtNumberOfGuests = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGetBookingDetails = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCheckinDate = new System.Windows.Forms.Label();
            this.dateTimePickerCheckin = new System.Windows.Forms.DateTimePicker();
            this.lblCheckoutDate = new System.Windows.Forms.Label();
            this.dateTimePickerCheckout = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingId.Location = new System.Drawing.Point(34, 18);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(107, 25);
            this.lblBookingId.TabIndex = 0;
            this.lblBookingId.Text = "Booking ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(34, 61);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(34, 113);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 25);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(34, 157);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(113, 25);
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "Room Type";
            // 
            // txBookingId
            // 
            this.txBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBookingId.Location = new System.Drawing.Point(224, 18);
            this.txBookingId.Name = "txBookingId";
            this.txBookingId.Size = new System.Drawing.Size(300, 30);
            this.txBookingId.TabIndex = 4;
            this.txBookingId.Tag = "Booking ID";
            // 
            // lblNoOfGuests
            // 
            this.lblNoOfGuests.AutoSize = true;
            this.lblNoOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfGuests.Location = new System.Drawing.Point(34, 206);
            this.lblNoOfGuests.Name = "lblNoOfGuests";
            this.lblNoOfGuests.Size = new System.Drawing.Size(169, 25);
            this.lblNoOfGuests.TabIndex = 5;
            this.lblNoOfGuests.Text = "Number of Guests";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(224, 61);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(300, 30);
            this.txtCustomerName.TabIndex = 6;
            this.txtCustomerName.Tag = "Customer Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(224, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 30);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Tag = "Phone Number";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Deluxe",
            "Suite"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(224, 157);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(136, 33);
            this.comboBoxRoomType.TabIndex = 8;
            this.comboBoxRoomType.Tag = "Room Type";
            this.comboBoxRoomType.Text = "--Select--";
            // 
            // txtNumberOfGuests
            // 
            this.txtNumberOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfGuests.Location = new System.Drawing.Point(224, 206);
            this.txtNumberOfGuests.Name = "txtNumberOfGuests";
            this.txtNumberOfGuests.Size = new System.Drawing.Size(136, 30);
            this.txtNumberOfGuests.TabIndex = 9;
            this.txtNumberOfGuests.Tag = "Number of Guests";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(60, 316);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 98);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(259, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 98);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGetBookingDetails
            // 
            this.btnGetBookingDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGetBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBookingDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetBookingDetails.Location = new System.Drawing.Point(435, 316);
            this.btnGetBookingDetails.Name = "btnGetBookingDetails";
            this.btnGetBookingDetails.Size = new System.Drawing.Size(159, 98);
            this.btnGetBookingDetails.TabIndex = 12;
            this.btnGetBookingDetails.Text = "Get Booking Details";
            this.btnGetBookingDetails.UseVisualStyleBackColor = false;
            this.btnGetBookingDetails.Click += new System.EventHandler(this.btnGetBookingDetails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(668, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 98);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCheckinDate
            // 
            this.lblCheckinDate.AutoSize = true;
            this.lblCheckinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckinDate.Location = new System.Drawing.Point(405, 165);
            this.lblCheckinDate.Name = "lblCheckinDate";
            this.lblCheckinDate.Size = new System.Drawing.Size(137, 25);
            this.lblCheckinDate.TabIndex = 14;
            this.lblCheckinDate.Text = "Check-in Date";
            // 
            // dateTimePickerCheckin
            // 
            this.dateTimePickerCheckin.Location = new System.Drawing.Point(564, 168);
            this.dateTimePickerCheckin.Name = "dateTimePickerCheckin";
            this.dateTimePickerCheckin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckin.TabIndex = 15;
            this.dateTimePickerCheckin.Tag = "Checkin Date";
            // 
            // lblCheckoutDate
            // 
            this.lblCheckoutDate.AutoSize = true;
            this.lblCheckoutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckoutDate.Location = new System.Drawing.Point(405, 211);
            this.lblCheckoutDate.Name = "lblCheckoutDate";
            this.lblCheckoutDate.Size = new System.Drawing.Size(149, 25);
            this.lblCheckoutDate.TabIndex = 16;
            this.lblCheckoutDate.Text = "Check-out Date";
            // 
            // dateTimePickerCheckout
            // 
            this.dateTimePickerCheckout.Location = new System.Drawing.Point(564, 211);
            this.dateTimePickerCheckout.Name = "dateTimePickerCheckout";
            this.dateTimePickerCheckout.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckout.TabIndex = 17;
            this.dateTimePickerCheckout.Tag = "Checkout Date";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(978, 476);
            this.Controls.Add(this.dateTimePickerCheckout);
            this.Controls.Add(this.lblCheckoutDate);
            this.Controls.Add(this.dateTimePickerCheckin);
            this.Controls.Add(this.lblCheckinDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetBookingDetails);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNumberOfGuests);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblNoOfGuests);
            this.Controls.Add(this.txBookingId);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblBookingId);
            this.Name = "Form2";
            this.Text = "Room Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txBookingId;
        private System.Windows.Forms.Label lblNoOfGuests;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.TextBox txtNumberOfGuests;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGetBookingDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCheckinDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckin;
        private System.Windows.Forms.Label lblCheckoutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckout;
    }
}