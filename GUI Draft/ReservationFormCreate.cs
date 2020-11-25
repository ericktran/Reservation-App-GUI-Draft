using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Draft
{
    public partial class CreateReservationForm : Form
    {
        bool adminCheck;
        DateTime showDateTime;
        String showDate;
        String showTime;
        String venue;
        String artist;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\John Ly\Desktop\GUI Draft\GUI Draft\ArtistLogInDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public CreateReservationForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
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

        public void DateOfShow_DateChanged(object sender, DateRangeEventArgs e)
        {
            showDateTime = DateOfShow.SelectionStart;
            showDate = showDateTime.ToShortDateString();
        }

        public void TimeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTime = TimeDropDown.SelectedItem.ToString();
        }

        private void CreateReservationForm_Load(object sender, EventArgs e)
        {
            
            if (LogIn.UsernameLabelTxt == "Admin" || LogIn.UsernameLabelTxt == "admin")
            {
                adminCheck = true;
            }
            else
            {
                adminCheck = false;
            }
        }
        private void SubmitReservation_Click(object sender, EventArgs e)
        {
            con.Open();
            artist = ArtistNameText.Text;
            venue = VenueNameTxt.Text;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into PendingReservations values('" + artist +"','" + venue + "','"+ showDate + "','"+ showTime +"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show(string.Format("{0} {1} {2} {3}", artist, venue, showDate, showTime), "Reservation Confirmation", MessageBoxButtons.OK);
            con.Close();
            //To be continued Plan is to import data into database and have it approved then stored.
        }
    }
}
