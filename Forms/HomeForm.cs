using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserIDLabel_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
            this.Hide();
        }

        private void HomePanelLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeOverviewLabel_Click(object sender, EventArgs e)
        {
            ViewForm overview = new ViewForm();
            overview.Show();
            this.Hide();

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void HomeEmployeePictureBox_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void HomeEmployeePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            EmployeeForm pic = new EmployeeForm();
            pic.Show();
            this.Hide();
        }

        private void HomeOverviewPictureBox_Click(object sender, EventArgs e)
        {
            ViewForm overview = new ViewForm();
            overview.Show();
            this.Hide();
        }

        private void HomeSalaryPictureBox_Click(object sender, EventArgs e)
        {
            SalaryForm salary = new SalaryForm();
            salary.Show();
            this.Hide();
        }

        private void HomeSalaryOverview_Click(object sender, EventArgs e)
        {
            SalaryForm salary = new SalaryForm();
            salary.Show();
            this.Hide();
        }
    }
}
