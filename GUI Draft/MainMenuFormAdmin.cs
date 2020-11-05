using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Draft
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn NewLogIn = new LogIn();
            NewLogIn.Show();
        }

        private void CreateReservation_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateReservationForm ReserveForm = new CreateReservationForm();
            ReserveForm.Show();
        }

        private void ManageReservation_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageReservationForm ManageForm = new ManageReservationForm();
            ManageForm.Show();
        }

        private void ApproveReservation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
