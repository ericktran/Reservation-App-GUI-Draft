namespace GUI_Draft
{
    partial class CreateReservationForm
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
            this.SubmitReservation = new System.Windows.Forms.Button();
            this.ArtistNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfShow = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.VenueSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SubmitReservation
            // 
            this.SubmitReservation.Location = new System.Drawing.Point(572, 217);
            this.SubmitReservation.Name = "SubmitReservation";
            this.SubmitReservation.Size = new System.Drawing.Size(75, 23);
            this.SubmitReservation.TabIndex = 0;
            this.SubmitReservation.Text = "Reserve";
            this.SubmitReservation.UseVisualStyleBackColor = true;
            this.SubmitReservation.Click += new System.EventHandler(this.SubmitReservation_Click);
            // 
            // ArtistNameText
            // 
            this.ArtistNameText.Location = new System.Drawing.Point(100, 32);
            this.ArtistNameText.Name = "ArtistNameText";
            this.ArtistNameText.Size = new System.Drawing.Size(262, 20);
            this.ArtistNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artist Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Venue Name";
            // 
            // DateOfShow
            // 
            this.DateOfShow.Location = new System.Drawing.Point(121, 98);
            this.DateOfShow.MaxSelectionCount = 1;
            this.DateOfShow.Name = "DateOfShow";
            this.DateOfShow.TabIndex = 5;
            this.DateOfShow.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateOfShow_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date for Show";
            // 
            // TimeDropDown
            // 
            this.TimeDropDown.FormattingEnabled = true;
            this.TimeDropDown.Items.AddRange(new object[] {
            "12:00 AM",
            "12:30 AM",
            "1:00 AM",
            "1:30 AM",
            "2:00 AM",
            "2:30 AM",
            "3:00 AM",
            "3:30 AM",
            "4:00 AM",
            "4:30 AM",
            "5:00 AM",
            "5:30 AM",
            "6:00 AM",
            "6:30 AM",
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM",
            "9:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM"});
            this.TimeDropDown.Location = new System.Drawing.Point(526, 90);
            this.TimeDropDown.Name = "TimeDropDown";
            this.TimeDropDown.Size = new System.Drawing.Size(121, 21);
            this.TimeDropDown.TabIndex = 7;
            this.TimeDropDown.SelectedIndexChanged += new System.EventHandler(this.TimeDropDown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time of Show";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(572, 248);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 9;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // VenueSelection
            // 
            this.VenueSelection.FormattingEnabled = true;
            this.VenueSelection.Items.AddRange(new object[] {
            "1. HouseofBlues",
            "2. ObservatoryOC",
            "3. The Forum",
            "4. Staples Center",
            "5. Honda Center"});
            this.VenueSelection.Location = new System.Drawing.Point(526, 39);
            this.VenueSelection.Name = "VenueSelection";
            this.VenueSelection.Size = new System.Drawing.Size(121, 21);
            this.VenueSelection.TabIndex = 10;
            // 
            // CreateReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 283);
            this.Controls.Add(this.VenueSelection);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateOfShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArtistNameText);
            this.Controls.Add(this.SubmitReservation);
            this.Name = "CreateReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Window";
            this.Load += new System.EventHandler(this.CreateReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitReservation;
        private System.Windows.Forms.TextBox ArtistNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar DateOfShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TimeDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.ComboBox VenueSelection;
    }
}