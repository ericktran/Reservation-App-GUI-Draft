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
    public partial class ApproveReservationForm : Form
    {
        public ApproveReservationForm()
        {
            InitializeComponent();
        }

        private void ApproveReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artistLogInDatabaseDataSet.PendingReservations' table. You can move, or remove it, as needed.
            this.pendingReservationsTableAdapter.Fill(this.artistLogInDatabaseDataSet.PendingReservations);

        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }
    }
}
