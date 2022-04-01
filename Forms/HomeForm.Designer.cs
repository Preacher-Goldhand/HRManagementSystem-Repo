
namespace HRManagementSystem
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.HomePanelLabel = new System.Windows.Forms.Panel();
            this.HomeSalaryOverview = new System.Windows.Forms.Label();
            this.HomeOverviewLabel = new System.Windows.Forms.Label();
            this.HomeEmployeeDLabel = new System.Windows.Forms.Label();
            this.HomeSalaryPictureBox = new System.Windows.Forms.PictureBox();
            this.HomeOverviewPictureBox = new System.Windows.Forms.PictureBox();
            this.HomeEmployeePictureBox = new System.Windows.Forms.PictureBox();
            this.HomePictureBox = new System.Windows.Forms.PictureBox();
            this.HomeNameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HomePanelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeSalaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeOverviewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeEmployeePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePanelLabel
            // 
            this.HomePanelLabel.BackColor = System.Drawing.Color.White;
            this.HomePanelLabel.Controls.Add(this.HomeSalaryOverview);
            this.HomePanelLabel.Controls.Add(this.HomeOverviewLabel);
            this.HomePanelLabel.Controls.Add(this.HomeEmployeeDLabel);
            this.HomePanelLabel.Controls.Add(this.HomeSalaryPictureBox);
            this.HomePanelLabel.Controls.Add(this.HomeOverviewPictureBox);
            this.HomePanelLabel.Controls.Add(this.HomeEmployeePictureBox);
            this.HomePanelLabel.Location = new System.Drawing.Point(-1, 68);
            this.HomePanelLabel.Name = "HomePanelLabel";
            this.HomePanelLabel.Size = new System.Drawing.Size(803, 358);
            this.HomePanelLabel.TabIndex = 0;
            this.HomePanelLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanelLabel_Paint);
            // 
            // HomeSalaryOverview
            // 
            this.HomeSalaryOverview.AutoSize = true;
            this.HomeSalaryOverview.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeSalaryOverview.ForeColor = System.Drawing.Color.SteelBlue;
            this.HomeSalaryOverview.Location = new System.Drawing.Point(547, 245);
            this.HomeSalaryOverview.Name = "HomeSalaryOverview";
            this.HomeSalaryOverview.Size = new System.Drawing.Size(99, 37);
            this.HomeSalaryOverview.TabIndex = 9;
            this.HomeSalaryOverview.Text = "Salary";
            this.HomeSalaryOverview.Click += new System.EventHandler(this.HomeSalaryOverview_Click);
            // 
            // HomeOverviewLabel
            // 
            this.HomeOverviewLabel.AutoSize = true;
            this.HomeOverviewLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeOverviewLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.HomeOverviewLabel.Location = new System.Drawing.Point(309, 245);
            this.HomeOverviewLabel.Name = "HomeOverviewLabel";
            this.HomeOverviewLabel.Size = new System.Drawing.Size(134, 37);
            this.HomeOverviewLabel.TabIndex = 8;
            this.HomeOverviewLabel.Text = "Overview";
            this.HomeOverviewLabel.Click += new System.EventHandler(this.HomeOverviewLabel_Click);
            // 
            // HomeEmployeeDLabel
            // 
            this.HomeEmployeeDLabel.AutoSize = true;
            this.HomeEmployeeDLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HomeEmployeeDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.HomeEmployeeDLabel.Location = new System.Drawing.Point(87, 245);
            this.HomeEmployeeDLabel.Name = "HomeEmployeeDLabel";
            this.HomeEmployeeDLabel.Size = new System.Drawing.Size(140, 37);
            this.HomeEmployeeDLabel.TabIndex = 7;
            this.HomeEmployeeDLabel.Text = "Employee";
            this.HomeEmployeeDLabel.Click += new System.EventHandler(this.UserIDLabel_Click);
            // 
            // HomeSalaryPictureBox
            // 
            this.HomeSalaryPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomeSalaryPictureBox.Image")));
            this.HomeSalaryPictureBox.Location = new System.Drawing.Point(526, 81);
            this.HomeSalaryPictureBox.Name = "HomeSalaryPictureBox";
            this.HomeSalaryPictureBox.Size = new System.Drawing.Size(131, 128);
            this.HomeSalaryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeSalaryPictureBox.TabIndex = 2;
            this.HomeSalaryPictureBox.TabStop = false;
            this.HomeSalaryPictureBox.Click += new System.EventHandler(this.HomeSalaryPictureBox_Click);
            // 
            // HomeOverviewPictureBox
            // 
            this.HomeOverviewPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomeOverviewPictureBox.Image")));
            this.HomeOverviewPictureBox.Location = new System.Drawing.Point(309, 81);
            this.HomeOverviewPictureBox.Name = "HomeOverviewPictureBox";
            this.HomeOverviewPictureBox.Size = new System.Drawing.Size(131, 128);
            this.HomeOverviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeOverviewPictureBox.TabIndex = 1;
            this.HomeOverviewPictureBox.TabStop = false;
            this.HomeOverviewPictureBox.Click += new System.EventHandler(this.HomeOverviewPictureBox_Click);
            // 
            // HomeEmployeePictureBox
            // 
            this.HomeEmployeePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomeEmployeePictureBox.Image")));
            this.HomeEmployeePictureBox.Location = new System.Drawing.Point(87, 81);
            this.HomeEmployeePictureBox.Name = "HomeEmployeePictureBox";
            this.HomeEmployeePictureBox.Size = new System.Drawing.Size(131, 128);
            this.HomeEmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeEmployeePictureBox.TabIndex = 0;
            this.HomeEmployeePictureBox.TabStop = false;
            this.HomeEmployeePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.HomeEmployeePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeEmployeePictureBox_MouseClick);
            this.HomeEmployeePictureBox.MouseEnter += new System.EventHandler(this.HomeEmployeePictureBox_MouseEnter);
            // 
            // HomePictureBox
            // 
            this.HomePictureBox.BackColor = System.Drawing.Color.SteelBlue;
            this.HomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HomePictureBox.Image")));
            this.HomePictureBox.Location = new System.Drawing.Point(12, 12);
            this.HomePictureBox.Name = "HomePictureBox";
            this.HomePictureBox.Size = new System.Drawing.Size(100, 50);
            this.HomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePictureBox.TabIndex = 1;
            this.HomePictureBox.TabStop = false;
            // 
            // HomeNameLabel
            // 
            this.HomeNameLabel.AutoSize = true;
            this.HomeNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeNameLabel.ForeColor = System.Drawing.Color.White;
            this.HomeNameLabel.Location = new System.Drawing.Point(118, 21);
            this.HomeNameLabel.Name = "HomeNameLabel";
            this.HomeNameLabel.Size = new System.Drawing.Size(82, 32);
            this.HomeNameLabel.TabIndex = 2;
            this.HomeNameLabel.Text = "Home";
            this.HomeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(650, 21);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(138, 31);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.HomeNameLabel);
            this.Controls.Add(this.HomePictureBox);
            this.Controls.Add(this.HomePanelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.HomePanelLabel.ResumeLayout(false);
            this.HomePanelLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeSalaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeOverviewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeEmployeePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HomePanelLabel;
        private System.Windows.Forms.PictureBox HomePictureBox;
        private System.Windows.Forms.Label HomeNameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox HomeEmployeePictureBox;
        private System.Windows.Forms.PictureBox HomeSalaryPictureBox;
        private System.Windows.Forms.PictureBox HomeOverviewPictureBox;
        private System.Windows.Forms.Label HomeSalaryOverview;
        private System.Windows.Forms.Label HomeOverviewLabel;
        private System.Windows.Forms.Label HomeEmployeeDLabel;
    }
}