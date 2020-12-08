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
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\John Ly\Desktop\GUI Draft\GUI Draft\ArtistLogInDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public ManageReservationForm()
        {
            InitializeComponent();
        }

        
        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'artistLogInDatabaseDataSet.EventReservation' table. You can move, or remove it, as needed.
            if (CreateReservationForm.adminCheck == true)
            {
                String fillTable = "Select * From dbo.EventReservation";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, LogIn.con);
                DataTable updateTable = new DataTable();
                sqlDataAdapter.Fill(updateTable);
                dataGridView1.DataSource = updateTable.DefaultView;
                dataGridView1.Update();
                LogIn.con.Close();
            }
            else
            {
                String fillTable = "Select * From dbo.EventReservation WHERE ArtistID = '" + LogIn.UsernameLabelTxt + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, LogIn.con);
                DataTable updateTable = new DataTable();
                sqlDataAdapter.Fill(updateTable);
                dataGridView1.DataSource = updateTable.DefaultView;
                dataGridView1.Update();
                LogIn.con.Close();
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                String fillTable = "Select * From dbo.EventReservation";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, LogIn.con);
                DataTable updateTable = new DataTable();
                sqlDataAdapter.Fill(updateTable);
                dataGridView1.DataSource = updateTable.DefaultView;
                dataGridView1.Update();
                LogIn.con.Close();
                MessageBox.Show("Updated Info", "Update", MessageBoxButtons.OK);
                
            }
            else
            {
                String fillTable = "Select * From dbo.EventReservation WHERE ArtistID = '" + LogIn.UsernameLabelTxt + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, LogIn.con);
                DataTable updateTable = new DataTable();
                sqlDataAdapter.Fill(updateTable);
                dataGridView1.DataSource = updateTable.DefaultView;
                dataGridView1.Update();
                LogIn.con.Close();
                MessageBox.Show("Updated Info", "Update", MessageBoxButtons.OK);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            String remove = "DELETE FROM dbo.EventReservation WHERE ReservationID = @rowID";

            using (SqlCommand deleteRecord = new SqlCommand(remove, LogIn.con))
            {
                LogIn.con.Open();
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
                LogIn.con.Close();

            }
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            String fillTable = "Select * From dbo.EventReservation";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(fillTable, LogIn.con);
            DataTable updateTable = new DataTable();
            sqlDataAdapter.Fill(updateTable);
            dataGridView1.DataSource = updateTable.DefaultView;
            dataGridView1.Update();
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // Exit from the application  
            app.Quit();

            MessageBox.Show("Exported to Excel", "Export Confirmation", MessageBoxButtons.OK);

        }
    }
}
