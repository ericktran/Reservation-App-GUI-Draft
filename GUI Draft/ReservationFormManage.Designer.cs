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
            this.ApprovedReservationDataGrid = new System.Windows.Forms.DataGridView();
            this.artistLogInDatabaseDataSet = new GUI_Draft.ArtistLogInDatabaseDataSet();
            this.eventReservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventReservationTableAdapter = new GUI_Draft.ArtistLogInDatabaseDataSetTableAdapters.EventReservationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedReservationDataGrid)).BeginInit();
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
            // ApprovedReservationDataGrid
            // 
            this.ApprovedReservationDataGrid.AllowUserToDeleteRows = false;
            this.ApprovedReservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApprovedReservationDataGrid.Location = new System.Drawing.Point(12, 44);
            this.ApprovedReservationDataGrid.Name = "ApprovedReservationDataGrid";
            this.ApprovedReservationDataGrid.Size = new System.Drawing.Size(1142, 789);
            this.ApprovedReservationDataGrid.TabIndex = 3;
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
            // ManageReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 865);
            this.Controls.Add(this.ApprovedReservationDataGrid);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateDataButton);
            this.Name = "ManageReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Reservation";
            this.Load += new System.EventHandler(this.ManageReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedReservationDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistLogInDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventReservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdateDataButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.DataGridView ApprovedReservationDataGrid;
        private ArtistLogInDatabaseDataSet artistLogInDatabaseDataSet;
        private System.Windows.Forms.BindingSource eventReservationBindingSource;
        private ArtistLogInDatabaseDataSetTableAdapters.EventReservationTableAdapter eventReservationTableAdapter;
    }
}