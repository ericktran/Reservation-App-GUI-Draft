using System;
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
    public partial class ManageReservationForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Ly\Desktop\GUI Draft\GUI Draft\ArtistLogInDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageReservationForm()
        {
            InitializeComponent();
        }

        
        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artistLogInDatabaseDataSet.EventReservation' table. You can move, or remove it, as needed.
            if (CreateReservationForm.adminCheck == true)
            {
                this.eventReservationTableAdapter.Fill(this.artistLogInDatabaseDataSet.EventReservation);
            }
            else
            {
               this.eventReservationTableAdapter.FillByArtistID(this.artistLogInDatabaseDataSet.EventReservation, LogIn.UsernameLabelTxt);
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CreateReservationForm.adminCheck == true)
            {
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else
            {
                MainMenuForm MainMenu = new MainMenuForm();
                MainMenu.Show();
            }
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            if (CreateReservationForm.adminCheck == true)
            {
                String fillTable = "Select * From dbo.EventReservation";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, con);
                DataTable updateTable = new DataTable();
                sqlDataAdapter.Fill(updateTable);
                dataGridView1.DataSource = updateTable.DefaultView;
                dataGridView1.Update();
                con.Close();
                MessageBox.Show("Updated Info", "Update", MessageBoxButtons.OK);
                
            }
            else
            {
                /*dataGridView1.Invalidate();
                dataGridView1.Update();
                dataGridView1.Refresh();
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
                this.eventReservationTableAdapter.FillByArtistID(this.artistLogInDatabaseDataSet.EventReservation, LogIn.UsernameLabelTxt);
                this.Update();
                this.Refresh();
                Application.DoEvents();*/
                String fillTable = "Select * From dbo.EventReservation WHERE ArtistID = '" + LogIn.UsernameLabelTxt + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, con);
                DataTable updateTable = new DataTable();
                sqlDataAdapter.Fill(updateTable);
                dataGridView1.DataSource = updateTable.DefaultView;
                dataGridView1.Update();
                con.Close();
                MessageBox.Show("Updated Info", "Update", MessageBoxButtons.OK);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            String remove = "DELETE FROM dbo.EventReservation WHERE ReservationID = @rowID";

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
    }
}
