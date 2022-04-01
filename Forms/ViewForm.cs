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

namespace HRManagementSystem
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sql connection settings for ViewForm
        /// </summary>
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mateusz\Documents\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void RefreshData()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
                string query = "SELECT * FROM EmployeeTbl WHERE EmpId='" + StartViewEmployeeIdValue.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ViewEmployeeIdValue.Text = dr["EmpId"].ToString();
                    ViewEmployeeNameValue.Text = dr["EmpName"].ToString();
                    ViewEmployeeAddressValue.Text = dr["EmpAddress"].ToString();
                    ViewEmployeePositionValue.Text = dr["EmpPos"].ToString();
                    ViewEmployeeGenderValue.Text = dr["EmpGen"].ToString();
                    ViewEmployeeDoBValue.Text = dr["EmpDOB"].ToString();
                    ViewEmployeePhoneValue.Text = dr["EmpPhone"].ToString();
                    ViewEmployeeEducationValue.Text = dr["EmpEdu"].ToString();

                }
                connection.Close();
            }
            
        }
        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeEmployeeAddressValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewEmployeeIdValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewReturnToHomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void ViewRefreshButton_Click(object sender, EventArgs e)
        {
            //Checking condition
            if (StartViewEmployeeIdValue.Text == "")
            {
                MessageBox.Show("Missing Employee Id");
            }
            else
            {
                RefreshData();
            }
            
        }

        private void ViewEmployeeAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViewEmployeeAddressValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewPrintButton_Click(object sender, EventArgs e)
        {
            //Printing Preview Dialog for ViewForm
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loading info for printing from textboxes in ViewForm
            e.Graphics.DrawString("EMPLOYEE INFO", new Font("Times New Roman", 25, FontStyle.Bold),Brushes.Black, new Point(260));
            e.Graphics.DrawString("Employee Id: " + ViewEmployeeIdValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80,100));
            e.Graphics.DrawString("Employee Name: " + ViewEmployeeNameValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 130));
            e.Graphics.DrawString("Employee Address: " + ViewEmployeeAddressValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 160));
            e.Graphics.DrawString("Employee Gender: " + ViewEmployeeGenderValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 190));
            e.Graphics.DrawString("Employee Position: " + ViewEmployeePositionValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 220));
            e.Graphics.DrawString("Employee DoB: " + ViewEmployeeDoBValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 250));
            e.Graphics.DrawString("Employee Phone: " + ViewEmployeePhoneValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 280));
            e.Graphics.DrawString("Emplpyee Education: " + ViewEmployeeEducationValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 310));

        }
    }
}
