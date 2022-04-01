using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HRManagementSystem
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            //Timer settings for ProgressBar
            SplashTimer.Enabled = true;
            SplashTimer.Start();
            SplashTimer.Interval = 25;
            SplashProgressBar.Maximum = 100;
            SplashTimer.Tick += new EventHandler(SplashTimerTick);
            
        }
        void SplashTimerTick(object sender, EventArgs e)
        {
            if (SplashProgressBar.Value != 100)
            {
                SplashProgressBar.Value += 25;                
            }
            else
            {
                SplashTimer.Stop();                
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        private void SplashNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void SplashButton_Click(object sender, EventArgs e)
        {
            LoginForm enter = new LoginForm();
            enter.Show();
            this.Hide();
        }
    }
}
