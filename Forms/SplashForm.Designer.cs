
namespace HRManagementSystem
{
    partial class SplashForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashNameLabel = new System.Windows.Forms.Label();
            this.SplashLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashProgressBar = new System.Windows.Forms.ProgressBar();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashNameLabel
            // 
            this.SplashNameLabel.AutoSize = true;
            this.SplashNameLabel.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SplashNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SplashNameLabel.Location = new System.Drawing.Point(65, 9);
            this.SplashNameLabel.Name = "SplashNameLabel";
            this.SplashNameLabel.Size = new System.Drawing.Size(677, 65);
            this.SplashNameLabel.TabIndex = 0;
            this.SplashNameLabel.Text = "HR MANAGEMENT SYSTEM";
            this.SplashNameLabel.Click += new System.EventHandler(this.SplashNameLabel_Click);
            // 
            // SplashLogoPictureBox
            // 
            this.SplashLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SplashLogoPictureBox.Image")));
            this.SplashLogoPictureBox.Location = new System.Drawing.Point(267, 77);
            this.SplashLogoPictureBox.Name = "SplashLogoPictureBox";
            this.SplashLogoPictureBox.Size = new System.Drawing.Size(220, 265);
            this.SplashLogoPictureBox.TabIndex = 2;
            this.SplashLogoPictureBox.TabStop = false;
            this.SplashLogoPictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SplashProgressBar
            // 
            this.SplashProgressBar.ForeColor = System.Drawing.Color.SteelBlue;
            this.SplashProgressBar.Location = new System.Drawing.Point(267, 348);
            this.SplashProgressBar.Name = "SplashProgressBar";
            this.SplashProgressBar.Size = new System.Drawing.Size(220, 23);
            this.SplashProgressBar.TabIndex = 3;
            this.SplashProgressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // SplashTimer
            // 
            this.SplashTimer.Enabled = true;
            // 
            // SplashButton
            // 
            this.SplashButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SplashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplashButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SplashButton.ForeColor = System.Drawing.Color.White;
            this.SplashButton.Location = new System.Drawing.Point(314, 388);
            this.SplashButton.Name = "SplashButton";
            this.SplashButton.Size = new System.Drawing.Size(126, 39);
            this.SplashButton.TabIndex = 11;
            this.SplashButton.Text = "Enter";
            this.SplashButton.UseVisualStyleBackColor = false;
            this.SplashButton.Click += new System.EventHandler(this.SplashButton_Click);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplashButton);
            this.Controls.Add(this.SplashProgressBar);
            this.Controls.Add(this.SplashLogoPictureBox);
            this.Controls.Add(this.SplashNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SplashForm";
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashNameLabel;
        private System.Windows.Forms.PictureBox SplashLogoPictureBox;
        private System.Windows.Forms.ProgressBar SplashProgressBar;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Button SplashButton;
    }
}

