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

namespace GUI_Draft
{
    public partial class CreateReservationForm : Form
    {
        bool AdminCheck;
        public CreateReservationForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (AdminCheck == true)
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

        private void DateOfShow_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime showdate = DateOfShow.SelectionStart;
        }

        private void TimeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            String showTime = TimeDropDown.SelectedItem.ToString();
        }

        private void CreateReservationForm_Load(object sender, EventArgs e)
        {
            
            if (LogIn.UsernameLabelTxt == "Admin" || LogIn.UsernameLabelTxt == "admin")
            {
                AdminCheck = true;
            }
            else
            {
                AdminCheck = false;
            }
        }
    }
}
