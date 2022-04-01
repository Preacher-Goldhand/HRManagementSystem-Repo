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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Setting new SQL connection on the local server.
        /// </summary>
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mateusz\Documents\EmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabale_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeEmployeePhoneValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeEmployeePositionValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeNameLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Adding a new record about an employee to dbo.Employee.Tbl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeAddButton_Click(object sender, EventArgs e)
        {
            if (EmployeeEmployeeIdValue.Text =="" || EmployeeEmployeeNameValue.Text == "" ||EmployeeEmployeeAddressValue.Text =="" ||EmployeeEmployeePhoneValue.Text =="")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    connection.Open();
                    //Order by dbo.EmployeeTbl
                    string query = "INSERT INTO EmployeeTbl VALUES('" + EmployeeEmployeeIdValue.Text + "','" 
                        + EmployeeEmployeeNameValue.Text + "','" 
                        + EmployeeEmployeeAddressValue.Text + "','"
                        + EmployeeEmployeePositionValue.SelectedItem.ToString() + "','"
                        + EmployeeEmployeeDOBValue.Value.Date + "','"
                        + EmployeeEmployeePhoneValue.Text + "','"
                        + EmployeeEmployeeEducationValue.SelectedItem.ToString() + "','" 
                        + EmployeeEmployeeGenderValue.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee successfully added");
                    connection.Close();
                    EmployeeStatus();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        } 

        private void EmpoloyeeEmployeeGenderValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// A function which sets DataGridView and filling data about an employee.
        /// </summary>
        private void EmployeeStatus()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
                string query = "SELECT * FROM EmployeeTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                EmployeeEmployeeDGV.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            EmployeeStatus();
        }
        /// <summary>
        /// Refilling data from the Employee Table to texboxes with values in order by dbo.Employee Tbl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = EmployeeEmployeeDGV.Rows[e.RowIndex];
                EmployeeEmployeeIdValue.Text = dgvRow.Cells[0].Value.ToString();
                EmployeeEmployeeNameValue.Text = dgvRow.Cells[1].Value.ToString();
                EmployeeEmployeeAddressValue.Text = dgvRow.Cells[2].Value.ToString();
                EmployeeEmployeeEducationValue.Text = dgvRow.Cells[6].Value.ToString();
                EmployeeEmployeePositionValue.Text = dgvRow.Cells[3].Value.ToString();
                EmployeeEmployeePhoneValue.Text = dgvRow.Cells[5].Value.ToString();
                EmployeeEmployeeGenderValue.Text = dgvRow.Cells[7].Value.ToString();
            }
            
        }
        /// <summary>
        /// Deleting a record in database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeDeleteButton_Click(object sender, EventArgs e)
        {
            if (EmployeeEmployeeIdValue.Text == "")
            {
                MessageBox.Show("Employee Id missing");
            }
            else
            { 
                try
                {
                    if(connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        string query = "DELETE FROM EmployeeTbl WHERE EmpId='" + EmployeeEmployeeIdValue.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee deleted successfully");
                        connection.Close();
                        EmployeeStatus();
                    }                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }            
        }
        /// <summary>
        /// Editing the Employee Information with exception the Employee Id which is unchangeable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeEditButton_Click(object sender, EventArgs e)
        {
            if (EmployeeEmployeeIdValue.Text == "" || EmployeeEmployeeNameValue.Text == "" || EmployeeEmployeeAddressValue.Text == "" || EmployeeEmployeePhoneValue.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        string query = "UPDATE EmployeeTbl SET EmpName='" + EmployeeEmployeeNameValue.Text +
                            "',EmpAddress='" + EmployeeEmployeeAddressValue.Text +
                            "',EmpPos='" + EmployeeEmployeePositionValue.SelectedItem.ToString() +
                            "',EmpDOB='" + EmployeeEmployeeDOBValue.Value.Date +
                            "',EmpPhone='" + EmployeeEmployeePhoneValue.Text +
                            "',EmpEdu='" + EmployeeEmployeeEducationValue.SelectedItem.ToString() +
                            "',EmpGen='" + EmployeeEmployeeGenderValue.SelectedItem.ToString() + "' WHERE EmpId='" + EmployeeEmployeeIdValue.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated successfully");
                        connection.Close();
                        EmployeeStatus();
                    }                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void EmployeeReturnToHomeButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void EmployeeEmployeeAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeEmployeeAddressValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeEmployeeIdValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
