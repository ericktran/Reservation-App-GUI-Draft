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
            this.Hide();
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
                dataGridView1.DataSource = null;
                dataGridView1.Update();
                dataGridView1.Refresh();
                dataGridView1.DataSource = eventReservationBindingSource;
                this.eventReservationTableAdapter.Update(this.artistLogInDatabaseDataSet.EventReservation);
                MessageBox.Show("Updated Info", "Update", MessageBoxButtons.OK);
                this.Update();
                this.Refresh();
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Update();
                dataGridView1.Refresh();
                dataGridView1.DataSource = eventReservationBindingSource;
                this.eventReservationTableAdapter.FillByArtistID(this.artistLogInDatabaseDataSet.EventReservation, LogIn.UsernameLabelTxt);
                this.Update();
                this.Refresh();
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
