
namespace HRManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.LoginPictureBox = new System.Windows.Forms.PictureBox();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.PasswordLabale = new System.Windows.Forms.Label();
            this.UserIdValue = new System.Windows.Forms.TextBox();
            this.PasswordValue = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(314, 65);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "HRSoftware";
            this.ProductNameLabel.Click += new System.EventHandler(this.CompanyLabel_Click);
            // 
            // LoginPictureBox
            // 
            this.LoginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoginPictureBox.Image")));
            this.LoginPictureBox.Location = new System.Drawing.Point(12, 99);
            this.LoginPictureBox.Name = "LoginPictureBox";
            this.LoginPictureBox.Size = new System.Drawing.Size(280, 278);
            this.LoginPictureBox.TabIndex = 5;
            this.LoginPictureBox.TabStop = false;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UserIDLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserIDLabel.Location = new System.Drawing.Point(315, 124);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(110, 37);
            this.UserIDLabel.TabIndex = 6;
            this.UserIDLabel.Text = "User ID";
            // 
            // PasswordLabale
            // 
            this.PasswordLabale.AutoSize = true;
            this.PasswordLabale.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PasswordLabale.ForeColor = System.Drawing.Color.SteelBlue;
            this.PasswordLabale.Location = new System.Drawing.Point(315, 238);
            this.PasswordLabale.Name = "PasswordLabale";
            this.PasswordLabale.Size = new System.Drawing.Size(138, 37);
            this.PasswordLabale.TabIndex = 7;
            this.PasswordLabale.Text = "Password";
            this.PasswordLabale.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserIdValue
            // 
            this.UserIdValue.Location = new System.Drawing.Point(487, 138);
            this.UserIdValue.Name = "UserIdValue";
            this.UserIdValue.Size = new System.Drawing.Size(178, 23);
            this.UserIdValue.TabIndex = 8;
            // 
            // PasswordValue
            // 
            this.PasswordValue.Location = new System.Drawing.Point(487, 253);
            this.PasswordValue.Name = "PasswordValue";
            this.PasswordValue.Size = new System.Drawing.Size(178, 23);
            this.PasswordValue.TabIndex = 9;
            this.PasswordValue.TextChanged += new System.EventHandler(this.PasswordValue_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(405, 338);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 39);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(539, 338);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 39);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Exit";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordValue);
            this.Controls.Add(this.UserIdValue);
            this.Controls.Add(this.PasswordLabale);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.LoginPictureBox);
            this.Controls.Add(this.ProductNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.PictureBox LoginPictureBox;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label PasswordLabale;
        private System.Windows.Forms.TextBox UserIdValue;
        private System.Windows.Forms.TextBox PasswordValue;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ClearButton;
    }
}