
namespace N01421653_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.pictureBoxBookRoom = new System.Windows.Forms.PictureBox();
            this.btnReserveTable = new System.Windows.Forms.Button();
            this.pictureBoxReserveTable = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReserveTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(79, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(66, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(155, 339);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(127, 50);
            this.btnBookRoom.TabIndex = 1;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // pictureBoxBookRoom
            // 
            this.pictureBoxBookRoom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBookRoom.Image")));
            this.pictureBoxBookRoom.Location = new System.Drawing.Point(75, 100);
            this.pictureBoxBookRoom.Name = "pictureBoxBookRoom";
            this.pictureBoxBookRoom.Size = new System.Drawing.Size(297, 211);
            this.pictureBoxBookRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookRoom.TabIndex = 2;
            this.pictureBoxBookRoom.TabStop = false;
            // 
            // btnReserveTable
            // 
            this.btnReserveTable.Location = new System.Drawing.Point(632, 339);
            this.btnReserveTable.Name = "btnReserveTable";
            this.btnReserveTable.Size = new System.Drawing.Size(127, 50);
            this.btnReserveTable.TabIndex = 3;
            this.btnReserveTable.Text = "Reserve Table";
            this.btnReserveTable.UseVisualStyleBackColor = true;
            this.btnReserveTable.Click += new System.EventHandler(this.btnReserveTable_Click);
            // 
            // pictureBoxReserveTable
            // 
            this.pictureBoxReserveTable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReserveTable.Image")));
            this.pictureBoxReserveTable.Location = new System.Drawing.Point(551, 100);
            this.pictureBoxReserveTable.Name = "pictureBoxReserveTable";
            this.pictureBoxReserveTable.Size = new System.Drawing.Size(297, 211);
            this.pictureBoxReserveTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReserveTable.TabIndex = 4;
            this.pictureBoxReserveTable.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(926, 420);
            this.Controls.Add(this.pictureBoxReserveTable);
            this.Controls.Add(this.btnReserveTable);
            this.Controls.Add(this.pictureBoxBookRoom);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hotel Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReserveTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.PictureBox pictureBoxBookRoom;
        private System.Windows.Forms.Button btnReserveTable;
        private System.Windows.Forms.PictureBox pictureBoxReserveTable;
    }
}

