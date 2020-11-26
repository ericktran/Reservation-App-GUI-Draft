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
    }
}
