namespace GUI_Draft
{
    partial class MainMenuForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ManageReservation = new System.Windows.Forms.Button();
            this.CreateReservation = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome";
            // 
            // ManageReservation
            // 
            this.ManageReservation.Location = new System.Drawing.Point(154, 113);
            this.ManageReservation.Name = "ManageReservation";
            this.ManageReservation.Size = new System.Drawing.Size(127, 23);
            this.ManageReservation.TabIndex = 9;
            this.ManageReservation.Text = "Manage Reservation";
            this.ManageReservation.UseVisualStyleBackColor = true;
            this.ManageReservation.Click += new System.EventHandler(this.ManageReservation_Click);
            // 
            // CreateReservation
            // 
            this.CreateReservation.Location = new System.Drawing.Point(154, 84);
            this.CreateReservation.Name = "CreateReservation";
            this.CreateReservation.Size = new System.Drawing.Size(75, 23);
            this.CreateReservation.TabIndex = 8;
            this.CreateReservation.Text = "Reservation";
            this.CreateReservation.UseVisualStyleBackColor = true;
            this.CreateReservation.Click += new System.EventHandler(this.CreateReservation_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(371, 246);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 7;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(41, 68);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManageReservation);
            this.Controls.Add(this.CreateReservation);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ManageReservation;
        private System.Windows.Forms.Button CreateReservation;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label UsernameLabel;
    }
}