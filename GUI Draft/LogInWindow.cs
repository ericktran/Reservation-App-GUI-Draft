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
        public static string test2 = "";

        public LogIn()
        {
            InitializeComponent();
            this.AcceptButton = LogInButton;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            UsernameLabelTxt = UsernameTxt.Text;
            test2 = PasswordTxt.Text;
            /* SqlConnection sqlConnection = default(SqlConnection);
             sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Ly\Desktop\GUI Draft\GUI Draft\ArtistLogInDatabase.mdf;Integrated Security=True;Connect Timeout=30");

             SqlCommand sqlCommand = default(SqlCommand);
             sqlConnection.Open();
             sqlCommand = new SqlCommand("SELECT Username,Password FROM LoginInfo WHERE Username = @Username AND Password = @Password");
             //string query = "Select* from LoginInfo where Username ='" + UsernameTxt.Text.Trim() + "' and Password ='" + PasswordTxt.Text.Trim() + "'";
             SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
             SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

             sqlCommand.Parameters.Add(uName);
             sqlCommand.Parameters.Add(uPassword);
             SqlDataReader dataReader = sqlCommand.ExecuteReader();
             if (dataReader.HasRows)*/
            if (UsernameTxt.Text == "admin" && PasswordTxt.Text == "admin")
            {
                this.Hide();
                AdminMenu NewMenu = new AdminMenu();
                NewMenu.Show();
            }
            else if (UsernameTxt.Text == "test" && PasswordTxt.Text == "test")
            {
                this.Hide();
                MainMenuForm TestMenu = new MainMenuForm();
                TestMenu.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password.");
            }
            //sqlConnection.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
