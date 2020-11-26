namespace GUI_Draft
{
    partial class ManageReservationForm
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
            this.components = new System.ComponentModel.Container();
            this.UpdateDataButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistLogInDatabaseDataSet = new GUI_Draft.ArtistLogInDatabaseDataSet();
            this.eventReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventReservationTableAdapter = new GUI_Draft.ArtistLogInDatabaseDataSetTableAdapters.EventReservationTableAdapter();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistLogInDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventReservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateDataButton
            // 
            this.UpdateDataButton.Location = new System.Drawing.Point(1214, 701);
            this.UpdateDataButton.Name = "UpdateDataButton";
            this.UpdateDataButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateDataButton.TabIndex = 0;
            this.UpdateDataButton.Text = "Update";
            this.UpdateDataButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1214, 754);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(1214, 809);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.MainMenuButton.TabIndex = 2;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.artistIDDataGridViewTextBoxColumn,
            this.paymentIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.venueIDDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventDescriptionDataGridViewTextBoxColumn,
            this.eventDateTimeDataGridViewTextBoxColumn,
            this.eventStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventReservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1104, 794);
            this.dataGridView1.TabIndex = 3;
            // 
            // artistLogInDatabaseDataSet
            // 
            this.artistLogInDatabaseDataSet.DataSetName = "ArtistLogInDatabaseDataSet";
            this.artistLogInDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventReservationBindingSource
            // 
            this.eventReservationBindingSource.DataMember = "EventReservation";
            this.eventReservationBindingSource.DataSource = this.artistLogInDatabaseDataSet;
            // 
            // eventReservationTableAdapter
            // 
            this.eventReservationTableAdapter.ClearBeforeFill = true;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "PaymentID";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // venueIDDataGridViewTextBoxColumn
            // 
            this.venueIDDataGridViewTextBoxColumn.DataPropertyName = "VenueID";
            this.venueIDDataGridViewTextBoxColumn.HeaderText = "VenueID";
            this.venueIDDataGridViewTextBoxColumn.Name = "venueIDDataGridViewTextBoxColumn";
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // eventDescriptionDataGridViewTextBoxColumn
            // 
            this.eventDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.HeaderText = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.Name = "eventDescriptionDataGridViewTextBoxColumn";
            // 
            // eventDateTimeDataGridViewTextBoxColumn
            // 
            this.eventDateTimeDataGridViewTextBoxColumn.DataPropertyName = "EventDateTime";
            this.eventDateTimeDataGridViewTextBoxColumn.HeaderText = "EventDateTime";
            this.eventDateTimeDataGridViewTextBoxColumn.Name = "eventDateTimeDataGridViewTextBoxColumn";
            // 
            // eventStatusDataGridViewTextBoxColumn
            // 
            this.eventStatusDataGridViewTextBoxColumn.DataPropertyName = "EventStatus";
            this.eventStatusDataGridViewTextBoxColumn.HeaderText = "EventStatus";
            this.eventStatusDataGridViewTextBoxColumn.Name = "eventStatusDataGridViewTextBoxColumn";
            // 
            // ManageReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 865);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Name = "ManageReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Reservation";
            this.Load += new System.EventHandler(this.ManageReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistLogInDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventReservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ArtistLogInDatabaseDataSet artistLogInDatabaseDataSet;
        private System.Windows.Forms.BindingSource eventReservationBindingSource;
        private ArtistLogInDatabaseDataSetTableAdapters.EventReservationTableAdapter eventReservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventStatusDataGridViewTextBoxColumn;
    }
}