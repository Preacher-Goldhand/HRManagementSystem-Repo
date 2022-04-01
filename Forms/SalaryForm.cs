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
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sql connections settings for SalaryForm
        /// </summary>
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mateusz\Documents\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDetails()
        {
            if (SalaryEmployeeIdValue.Text == "")
            {
                MessageBox.Show("Enter Employee Id");
            }
            else
            {
                connection.Open();
                string query = "SELECT * FROM EmployeeTbl WHERE EmpId = '" + SalaryEmployeeIdValue.Text + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    SalaryEmployeeNameValue.Text = dr["EmpName"].ToString();
                    SalaryEmployeePositionValue.Text = dr["EmpPos"].ToString();
                }
                connection.Close();
            }
        }
        private void EmployeeNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SalaryReturnToHomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void SalaryFetchDataButton_Click(object sender, EventArgs e)
        {
            DisplayDetails();
        }

        private void SalaryEmployeeWorkedDaysLabel_Click(object sender, EventArgs e)
        {

        }
        //Variable for DailyBase and Total
        int dailyBase, total;

        private void SalaryRichBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Printing settings for SalaryForm
            e.Graphics.DrawString("SALARY INFO", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, new Point(260));
            e.Graphics.DrawString("Employee Id: " + SalaryEmployeeIdValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 100));
            e.Graphics.DrawString("Employee Name: " + SalaryEmployeeNameValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 130));
            e.Graphics.DrawString("Employee Position: " + SalaryEmployeePositionValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 160));
            e.Graphics.DrawString("Worked Days: " + SalaryEmployeeWorkedDaysValue.Text, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 190));
            e.Graphics.DrawString("Daily Base: " + dailyBase, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 230));
            e.Graphics.DrawString("Total Salary: " + total, new Font("Times New Roman", 25, FontStyle.Regular), Brushes.Gray, new Point(80, 260));
        }

        private void SalaryPrintButton_Click(object sender, EventArgs e)
        {
            //Printing Preview Dialog checking
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void SalaryEmployeePositionLabel_Click(object sender, EventArgs e)
        {

        }

        private void SalaryEmployeeIdValue_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Filling salary data and settings details for SalaryForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryViewButton_Click(object sender, EventArgs e)
        {
            if (SalaryEmployeePositionValue.Text == "")
            {
                MessageBox.Show("Employee Position missing");
            }
            else if (SalaryEmployeeWorkedDaysValue.Text == "" || Convert.ToInt32(SalaryEmployeeWorkedDaysValue.Text) > 31)
            {
                MessageBox.Show("Enter a valid number of worked days");
            }
            else
            {
                if (SalaryEmployeePositionValue.Text == "Manager")
                {
                    dailyBase = 250;
                }
                else if (SalaryEmployeePositionValue.Text == "Senior Developer")
                {
                    dailyBase = 230;
                }
                else if (SalaryEmployeePositionValue.Text == "Junior Developer")
                {
                    dailyBase = 190;
                }
                else
                {
                    dailyBase = 150;
                }
                total = dailyBase * Convert.ToInt32(SalaryEmployeeWorkedDaysValue.Text);
                SalaryRichBox.Text = "Employee Id:  " + SalaryEmployeeIdValue.Text + "\n" + "Employee Name:  " + SalaryEmployeeNameValue.Text + "\n" + "Employee Position:  " + SalaryEmployeePositionValue.Text + "\n" + "Worked Days:  " + SalaryEmployeeWorkedDaysValue.Text + "\n" + "Daily Base:  " + dailyBase + "\n" + "Total:  " + total;
            }
        }
    }
}
