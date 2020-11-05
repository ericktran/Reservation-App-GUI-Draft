namespace GUI_Draft
{
    partial class AdminMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateReservation = new System.Windows.Forms.Button();
            this.ManageReservation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ApproveReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // CreateReservation
            // 
            this.CreateReservation.Location = new System.Drawing.Point(141, 71);
            this.CreateReservation.Name = "CreateReservation";
            this.CreateReservation.Size = new System.Drawing.Size(75, 23);
            this.CreateReservation.TabIndex = 2;
            this.CreateReservation.Text = "Reservation";
            this.CreateReservation.UseVisualStyleBackColor = true;
            this.CreateReservation.Click += new System.EventHandler(this.CreateReservation_Click);
            // 
            // ManageReservation
            // 
            this.ManageReservation.Location = new System.Drawing.Point(141, 100);
            this.ManageReservation.Name = "ManageReservation";
            this.ManageReservation.Size = new System.Drawing.Size(127, 23);
            this.ManageReservation.TabIndex = 3;
            this.ManageReservation.Text = "Manage Reservation";
            this.ManageReservation.UseVisualStyleBackColor = true;
            this.ManageReservation.Click += new System.EventHandler(this.ManageReservation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            // 
            // ApproveReservation
            // 
            this.ApproveReservation.Location = new System.Drawing.Point(141, 129);
            this.ApproveReservation.Name = "ApproveReservation";
            this.ApproveReservation.Size = new System.Drawing.Size(127, 23);
            this.ApproveReservation.TabIndex = 5;
            this.ApproveReservation.Text = "Approve Reservations";
            this.ApproveReservation.UseVisualStyleBackColor = true;
            this.ApproveReservation.Click += new System.EventHandler(this.ApproveReservation_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 238);
            this.Controls.Add(this.ApproveReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManageReservation);
            this.Controls.Add(this.CreateReservation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreateReservation;
        private System.Windows.Forms.Button ManageReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApproveReservation;
    }
}