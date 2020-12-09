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
    public partial class LogIn : Form
    {
        public static string UsernameLabelTxt = "";

        //Change this to the connection string on user computer to allow the user to access the Database.
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Ly\Desktop\GUI Draft\GUI Draft\ArtistLogInDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public LogIn()
        {
            InitializeComponent();
            this.AcceptButton = LogInButton;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            UsernameLabelTxt = UsernameTxt.Text;
            con.Open();
            String query = "Select ArtistID, ArtistPassword FROM dbo.Artist WHERE ArtistID = '" + UsernameTxt.Text.Trim() + "' AND ArtistPassword = '" + PasswordTxt.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            String queryAdmin = "Select EmployeeID, EmployeePassword FROM dbo.Employee WHERE EmployeeID = '" + UsernameTxt.Text.Trim() + "' AND EmployeePassword = '" + PasswordTxt.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapterAdmin = new SqlDataAdapter(queryAdmin, con);
            DataTable dataTableAdmin = new DataTable();
            sqlDataAdapterAdmin.Fill(dataTableAdmin);

            if (dataTable.Rows.Count == 1)
            {
                this.Hide();
                MainMenuForm TestMenu = new MainMenuForm();
                TestMenu.Show();
            }
            else if (dataTableAdmin.Rows.Count == 1)
            {
                this.Hide();
                AdminMenu NewMenu = new AdminMenu();
                NewMenu.Show();
                CreateReservationForm.adminCheck = true;
            }
            else
            {
                MessageBox.Show("Check your username and password.");
            }
            con.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
