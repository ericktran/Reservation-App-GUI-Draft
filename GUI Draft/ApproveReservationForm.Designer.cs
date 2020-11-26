﻿namespace GUI_Draft
{
    partial class ApproveReservationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistLogInDatabaseDataSet = new GUI_Draft.ArtistLogInDatabaseDataSet();
            this.pendingReservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pendingReservationsTableAdapter = new GUI_Draft.ArtistLogInDatabaseDataSetTableAdapters.PendingReservationsTableAdapter();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venueNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistLogInDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingReservationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.venueNameDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pendingReservationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // artistLogInDatabaseDataSet
            // 
            this.artistLogInDatabaseDataSet.DataSetName = "ArtistLogInDatabaseDataSet";
            this.artistLogInDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pendingReservationsBindingSource
            // 
            this.pendingReservationsBindingSource.DataMember = "PendingReservations";
            this.pendingReservationsBindingSource.DataSource = this.artistLogInDatabaseDataSet;
            // 
            // pendingReservationsTableAdapter
            // 
            this.pendingReservationsTableAdapter.ClearBeforeFill = true;
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            // 
            // venueNameDataGridViewTextBoxColumn
            // 
            this.venueNameDataGridViewTextBoxColumn.DataPropertyName = "VenueName";
            this.venueNameDataGridViewTextBoxColumn.HeaderText = "VenueName";
            this.venueNameDataGridViewTextBoxColumn.Name = "venueNameDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(760, 473);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(75, 23);
            this.ApproveButton.TabIndex = 1;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(760, 502);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(760, 531);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // ApproveReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 626);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApproveReservationForm";
            this.Text = "ApproveReservationForm";
            this.Load += new System.EventHandler(this.ApproveReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistLogInDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingReservationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ArtistLogInDatabaseDataSet artistLogInDatabaseDataSet;
        private System.Windows.Forms.BindingSource pendingReservationsBindingSource;
        private ArtistLogInDatabaseDataSetTableAdapters.PendingReservationsTableAdapter pendingReservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button MainMenu;
    }
}