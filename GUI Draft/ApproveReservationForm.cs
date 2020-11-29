﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Draft
{
    public partial class ApproveReservationForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Ly\Desktop\GUI Draft\GUI Draft\ArtistLogInDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public ApproveReservationForm()
        {
            InitializeComponent();
        }

        private void ApproveReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artistLogInDatabaseDataSet.PendingReservations' table. You can move, or remove it, as needed.
            this.pendingReservationsTableAdapter.Fill(this.artistLogInDatabaseDataSet.PendingReservations);

        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            con.Open();
            String fillTable = "Select TOP 1 * From dbo.PendingReservations";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, con);
            DataTable pendingTable = new DataTable();
            sqlDataAdapter.Fill(pendingTable);
            String tableID = pendingTable.Rows[0][0].ToString();
            int tableIDNum = Int32.Parse(tableID);
            if (tableIDNum > -1)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update dbo.PendingReservations Set EmployeeID = '" + LogIn.UsernameLabelTxt + "' WHERE PendingID = " + tableIDNum;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Insert into dbo.EventReservation ([ArtistID] , [VenueID] , [EventDateTime], [EmployeeID]) SELECT ArtistID , VenueID , EventDateTime, EmployeeID FROM dbo.PendingReservations WHERE PendingID = " + tableIDNum;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Approved.", "Reservation Approved Window", MessageBoxButtons.OK);
                cmd.CommandText = "Delete from dbo.PendingReservations where PendingID = " + tableIDNum;
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("There are no pending reservations.", "Invalid", MessageBoxButtons.OK);
            }
            this.pendingReservationsTableAdapter.Fill(this.artistLogInDatabaseDataSet.PendingReservations);
            con.Close();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            String remove = "DELETE FROM dbo.PendingReservations WHERE PendingID = @rowID";

            using (SqlCommand deleteRecord = new SqlCommand(remove, con))
            {
                con.Open();
                if (dataGridView1.SelectedRows.Count == 0)
                {

                    MessageBox.Show("No row selected !");
                }
                else if (dataGridView1.CurrentCell.RowIndex > 0)
                {

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show("Entry Deleted", "Delete Confirmation", MessageBoxButtons.OK);
                }
                con.Close();

            }
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            con.Open();
            this.Update();
            this.Refresh();
            this.pendingReservationsTableAdapter.Update(this.artistLogInDatabaseDataSet.PendingReservations);
            con.Close();
            MessageBox.Show("Updated Info", "Update", MessageBoxButtons.OK);
        }
    }
}
