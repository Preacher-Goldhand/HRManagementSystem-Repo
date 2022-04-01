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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CompanyLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Exit from the app
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Logging conditions
            if (UserIdValue.Text == "" || PasswordValue.Text == "")
            {
                MessageBox.Show("Enter User Id or Password");
            }
            else if (UserIdValue.Text == "Admin" && PasswordValue.Text == "hrsystem123")
            {
                HomeForm home = new HomeForm();
                home.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect User Id or Password");
            }
           
        }

        private void PasswordValue_TextChanged(object sender, EventArgs e)
        {
            //Hiding the password value by stars
            PasswordValue.PasswordChar = '*';
        }
    }
}
