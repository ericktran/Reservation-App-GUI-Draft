using System;
using System.Globalization;
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
        public static bool adminCheck;
        DateTime showDateTime;
        String showDate;
        String showTime;
        int venueID;
        String artist;
        

        public CreateReservationForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
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
            LogIn.con.Open();
            String query = "Select * FROM dbo.Employee WHERE EmployeeID = '" + LogIn.UsernameLabelTxt + "' AND EmployeeisManager = 1";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, LogIn.con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1) 
            {
                adminCheck = true;
            }
            else
            {
                adminCheck = false;
            }
            LogIn.con.Close();
        }
        private void SubmitReservation_Click(object sender, EventArgs e)
        {
            LogIn.con.Open();
            artist = ArtistNameText.Text;
            venueID = VenueSelection.SelectedIndex + 1;
            string venue = VenueSelection.SelectedItem.ToString();
            showDateTime = DateTime.Parse(showDate + " " + showTime);//, "dd/MM/yy h:mm tt", CultureInfo.InvariantCulture);
            SqlCommand cmd = LogIn.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into dbo.PendingReservations([ArtistID],[VenueID],[EventDateTime]) values ('" + artist +"','" + venueID + "','"+ showDateTime + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show(string.Format("{0} {1} {2}", artist, venue, showDateTime), "Reservation Confirmation", MessageBoxButtons.OK);
            LogIn.con.Close();
        }
    }
}
