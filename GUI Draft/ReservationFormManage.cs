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
        bool adminCheck;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\John Ly\Desktop\GUI Draft\GUI Draft\ArtistLogInDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public ManageReservationForm()
        {
            InitializeComponent();
        }

        
        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artistLogInDatabaseDataSet.EventReservation' table. You can move, or remove it, as needed.
            this.eventReservationTableAdapter.Fill(this.artistLogInDatabaseDataSet.EventReservation);
            
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            if (LogIn.UsernameLabelTxt == "Admin" || LogIn.UsernameLabelTxt == "admin")
            {
                adminCheck = true;
            }
            else
            {
                adminCheck = false;
            }
            this.Hide();
            if (adminCheck == true)
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
