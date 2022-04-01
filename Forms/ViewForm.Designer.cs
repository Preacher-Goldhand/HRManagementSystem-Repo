
namespace HRManagementSystem
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.ViewReturnToHomeButton = new System.Windows.Forms.Button();
            this.ViewPrintButton = new System.Windows.Forms.Button();
            this.ViewRefreshButton = new System.Windows.Forms.Button();
            this.StartViewEmployeeIdValue = new System.Windows.Forms.TextBox();
            this.StrartViewEmployeeIdLabel = new System.Windows.Forms.Label();
            this.ViewEmployeeEducationValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeeEducationLabel = new System.Windows.Forms.Label();
            this.ViewEmployeeDoBValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeeDoBLabel = new System.Windows.Forms.Label();
            this.ViewEmployeePhoneValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeePhoneLabel = new System.Windows.Forms.Label();
            this.ViewEmployeePositionValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeePositionLabel = new System.Windows.Forms.Label();
            this.ViewEmployeeGenderValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeeGenderLabel = new System.Windows.Forms.Label();
            this.ViewEmployeeAddressValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeeAddressLabel = new System.Windows.Forms.Label();
            this.ViewEmployeeNameValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeeNameLabel = new System.Windows.Forms.Label();
            this.ViewEmployeeIdValue = new System.Windows.Forms.TextBox();
            this.ViewEmployeeIdLabel = new System.Windows.Forms.Label();
            this.ViewNameLabel = new System.Windows.Forms.Label();
            this.ViewPictureBox = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.BackColor = System.Drawing.Color.White;
            this.ViewPanel.Controls.Add(this.ViewReturnToHomeButton);
            this.ViewPanel.Controls.Add(this.ViewPrintButton);
            this.ViewPanel.Controls.Add(this.ViewRefreshButton);
            this.ViewPanel.Controls.Add(this.StartViewEmployeeIdValue);
            this.ViewPanel.Controls.Add(this.StrartViewEmployeeIdLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeeEducationValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeeEducationLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeeDoBValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeeDoBLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeePhoneValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeePhoneLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeePositionValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeePositionLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeeGenderValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeeGenderLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeeAddressValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeeAddressLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeeNameValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeeNameLabel);
            this.ViewPanel.Controls.Add(this.ViewEmployeeIdValue);
            this.ViewPanel.Controls.Add(this.ViewEmployeeIdLabel);
            this.ViewPanel.Location = new System.Drawing.Point(1, 68);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1282, 662);
            this.ViewPanel.TabIndex = 0;
            this.ViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPanel_Paint);
            // 
            // ViewReturnToHomeButton
            // 
            this.ViewReturnToHomeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewReturnToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewReturnToHomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewReturnToHomeButton.ForeColor = System.Drawing.Color.White;
            this.ViewReturnToHomeButton.Location = new System.Drawing.Point(679, 609);
            this.ViewReturnToHomeButton.Name = "ViewReturnToHomeButton";
            this.ViewReturnToHomeButton.Size = new System.Drawing.Size(126, 39);
            this.ViewReturnToHomeButton.TabIndex = 39;
            this.ViewReturnToHomeButton.Text = "Home";
            this.ViewReturnToHomeButton.UseVisualStyleBackColor = false;
            this.ViewReturnToHomeButton.Click += new System.EventHandler(this.ViewReturnToHomeButton_Click);
            // 
            // ViewPrintButton
            // 
            this.ViewPrintButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPrintButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewPrintButton.ForeColor = System.Drawing.Color.White;
            this.ViewPrintButton.Location = new System.Drawing.Point(435, 609);
            this.ViewPrintButton.Name = "ViewPrintButton";
            this.ViewPrintButton.Size = new System.Drawing.Size(126, 39);
            this.ViewPrintButton.TabIndex = 38;
            this.ViewPrintButton.Text = "Print";
            this.ViewPrintButton.UseVisualStyleBackColor = false;
            this.ViewPrintButton.Click += new System.EventHandler(this.ViewPrintButton_Click);
            // 
            // ViewRefreshButton
            // 
            this.ViewRefreshButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewRefreshButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewRefreshButton.ForeColor = System.Drawing.Color.White;
            this.ViewRefreshButton.Location = new System.Drawing.Point(825, 28);
            this.ViewRefreshButton.Name = "ViewRefreshButton";
            this.ViewRefreshButton.Size = new System.Drawing.Size(126, 39);
            this.ViewRefreshButton.TabIndex = 37;
            this.ViewRefreshButton.Text = "Refresh";
            this.ViewRefreshButton.UseVisualStyleBackColor = false;
            this.ViewRefreshButton.Click += new System.EventHandler(this.ViewRefreshButton_Click);
            // 
            // StartViewEmployeeIdValue
            // 
            this.StartViewEmployeeIdValue.Location = new System.Drawing.Point(521, 38);
            this.StartViewEmployeeIdValue.Name = "StartViewEmployeeIdValue";
            this.StartViewEmployeeIdValue.Size = new System.Drawing.Size(221, 23);
            this.StartViewEmployeeIdValue.TabIndex = 36;
            // 
            // StrartViewEmployeeIdLabel
            // 
            this.StrartViewEmployeeIdLabel.AutoSize = true;
            this.StrartViewEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StrartViewEmployeeIdLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.StrartViewEmployeeIdLabel.Location = new System.Drawing.Point(246, 24);
            this.StrartViewEmployeeIdLabel.Name = "StrartViewEmployeeIdLabel";
            this.StrartViewEmployeeIdLabel.Size = new System.Drawing.Size(176, 37);
            this.StrartViewEmployeeIdLabel.TabIndex = 35;
            this.StrartViewEmployeeIdLabel.Text = "Employee ID";
            // 
            // ViewEmployeeEducationValue
            // 
            this.ViewEmployeeEducationValue.Location = new System.Drawing.Point(967, 532);
            this.ViewEmployeeEducationValue.Name = "ViewEmployeeEducationValue";
            this.ViewEmployeeEducationValue.Size = new System.Drawing.Size(218, 23);
            this.ViewEmployeeEducationValue.TabIndex = 34;
            // 
            // ViewEmployeeEducationLabel
            // 
            this.ViewEmployeeEducationLabel.AutoSize = true;
            this.ViewEmployeeEducationLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeeEducationLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeeEducationLabel.Location = new System.Drawing.Point(689, 518);
            this.ViewEmployeeEducationLabel.Name = "ViewEmployeeEducationLabel";
            this.ViewEmployeeEducationLabel.Size = new System.Drawing.Size(272, 37);
            this.ViewEmployeeEducationLabel.TabIndex = 33;
            this.ViewEmployeeEducationLabel.Text = "Employee Education";
            // 
            // ViewEmployeeDoBValue
            // 
            this.ViewEmployeeDoBValue.Location = new System.Drawing.Point(967, 395);
            this.ViewEmployeeDoBValue.Name = "ViewEmployeeDoBValue";
            this.ViewEmployeeDoBValue.Size = new System.Drawing.Size(218, 23);
            this.ViewEmployeeDoBValue.TabIndex = 32;
            this.ViewEmployeeDoBValue.TextChanged += new System.EventHandler(this.EmployeeEmployeeAddressValue_TextChanged);
            // 
            // ViewEmployeeDoBLabel
            // 
            this.ViewEmployeeDoBLabel.AutoSize = true;
            this.ViewEmployeeDoBLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeeDoBLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeeDoBLabel.Location = new System.Drawing.Point(689, 380);
            this.ViewEmployeeDoBLabel.Name = "ViewEmployeeDoBLabel";
            this.ViewEmployeeDoBLabel.Size = new System.Drawing.Size(208, 37);
            this.ViewEmployeeDoBLabel.TabIndex = 31;
            this.ViewEmployeeDoBLabel.Text = "Employee DoB ";
            // 
            // ViewEmployeePhoneValue
            // 
            this.ViewEmployeePhoneValue.Location = new System.Drawing.Point(332, 532);
            this.ViewEmployeePhoneValue.Name = "ViewEmployeePhoneValue";
            this.ViewEmployeePhoneValue.Size = new System.Drawing.Size(217, 23);
            this.ViewEmployeePhoneValue.TabIndex = 30;
            // 
            // ViewEmployeePhoneLabel
            // 
            this.ViewEmployeePhoneLabel.AutoSize = true;
            this.ViewEmployeePhoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeePhoneLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeePhoneLabel.Location = new System.Drawing.Point(54, 518);
            this.ViewEmployeePhoneLabel.Name = "ViewEmployeePhoneLabel";
            this.ViewEmployeePhoneLabel.Size = new System.Drawing.Size(233, 37);
            this.ViewEmployeePhoneLabel.TabIndex = 29;
            this.ViewEmployeePhoneLabel.Text = "Employee Phone ";
            // 
            // ViewEmployeePositionValue
            // 
            this.ViewEmployeePositionValue.Location = new System.Drawing.Point(332, 394);
            this.ViewEmployeePositionValue.Name = "ViewEmployeePositionValue";
            this.ViewEmployeePositionValue.Size = new System.Drawing.Size(218, 23);
            this.ViewEmployeePositionValue.TabIndex = 28;
            // 
            // ViewEmployeePositionLabel
            // 
            this.ViewEmployeePositionLabel.AutoSize = true;
            this.ViewEmployeePositionLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeePositionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeePositionLabel.Location = new System.Drawing.Point(54, 379);
            this.ViewEmployeePositionLabel.Name = "ViewEmployeePositionLabel";
            this.ViewEmployeePositionLabel.Size = new System.Drawing.Size(252, 37);
            this.ViewEmployeePositionLabel.TabIndex = 27;
            this.ViewEmployeePositionLabel.Text = "Employee Position";
            // 
            // ViewEmployeeGenderValue
            // 
            this.ViewEmployeeGenderValue.Location = new System.Drawing.Point(967, 254);
            this.ViewEmployeeGenderValue.Name = "ViewEmployeeGenderValue";
            this.ViewEmployeeGenderValue.Size = new System.Drawing.Size(221, 23);
            this.ViewEmployeeGenderValue.TabIndex = 26;
            // 
            // ViewEmployeeGenderLabel
            // 
            this.ViewEmployeeGenderLabel.AutoSize = true;
            this.ViewEmployeeGenderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeeGenderLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeeGenderLabel.Location = new System.Drawing.Point(689, 240);
            this.ViewEmployeeGenderLabel.Name = "ViewEmployeeGenderLabel";
            this.ViewEmployeeGenderLabel.Size = new System.Drawing.Size(237, 37);
            this.ViewEmployeeGenderLabel.TabIndex = 25;
            this.ViewEmployeeGenderLabel.Text = "Employee Gender";
            // 
            // ViewEmployeeAddressValue
            // 
            this.ViewEmployeeAddressValue.Location = new System.Drawing.Point(332, 255);
            this.ViewEmployeeAddressValue.Name = "ViewEmployeeAddressValue";
            this.ViewEmployeeAddressValue.Size = new System.Drawing.Size(218, 23);
            this.ViewEmployeeAddressValue.TabIndex = 21;
            this.ViewEmployeeAddressValue.TextChanged += new System.EventHandler(this.ViewEmployeeAddressValue_TextChanged);
            // 
            // ViewEmployeeAddressLabel
            // 
            this.ViewEmployeeAddressLabel.AutoSize = true;
            this.ViewEmployeeAddressLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeeAddressLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeeAddressLabel.Location = new System.Drawing.Point(54, 240);
            this.ViewEmployeeAddressLabel.Name = "ViewEmployeeAddressLabel";
            this.ViewEmployeeAddressLabel.Size = new System.Drawing.Size(247, 37);
            this.ViewEmployeeAddressLabel.TabIndex = 20;
            this.ViewEmployeeAddressLabel.Text = "Employee Address";
            this.ViewEmployeeAddressLabel.Click += new System.EventHandler(this.ViewEmployeeAddressLabel_Click);
            // 
            // ViewEmployeeNameValue
            // 
            this.ViewEmployeeNameValue.Location = new System.Drawing.Point(967, 144);
            this.ViewEmployeeNameValue.Name = "ViewEmployeeNameValue";
            this.ViewEmployeeNameValue.Size = new System.Drawing.Size(221, 23);
            this.ViewEmployeeNameValue.TabIndex = 19;
            // 
            // ViewEmployeeNameLabel
            // 
            this.ViewEmployeeNameLabel.AutoSize = true;
            this.ViewEmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeeNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeeNameLabel.Location = new System.Drawing.Point(689, 130);
            this.ViewEmployeeNameLabel.Name = "ViewEmployeeNameLabel";
            this.ViewEmployeeNameLabel.Size = new System.Drawing.Size(224, 37);
            this.ViewEmployeeNameLabel.TabIndex = 18;
            this.ViewEmployeeNameLabel.Text = "Employee Name";
            // 
            // ViewEmployeeIdValue
            // 
            this.ViewEmployeeIdValue.Location = new System.Drawing.Point(329, 145);
            this.ViewEmployeeIdValue.Name = "ViewEmployeeIdValue";
            this.ViewEmployeeIdValue.Size = new System.Drawing.Size(221, 23);
            this.ViewEmployeeIdValue.TabIndex = 17;
            this.ViewEmployeeIdValue.TextChanged += new System.EventHandler(this.ViewEmployeeIdValue_TextChanged);
            // 
            // ViewEmployeeIdLabel
            // 
            this.ViewEmployeeIdLabel.AutoSize = true;
            this.ViewEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewEmployeeIdLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewEmployeeIdLabel.Location = new System.Drawing.Point(54, 131);
            this.ViewEmployeeIdLabel.Name = "ViewEmployeeIdLabel";
            this.ViewEmployeeIdLabel.Size = new System.Drawing.Size(176, 37);
            this.ViewEmployeeIdLabel.TabIndex = 16;
            this.ViewEmployeeIdLabel.Text = "Employee ID";
            // 
            // ViewNameLabel
            // 
            this.ViewNameLabel.AutoSize = true;
            this.ViewNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewNameLabel.ForeColor = System.Drawing.Color.White;
            this.ViewNameLabel.Location = new System.Drawing.Point(102, 21);
            this.ViewNameLabel.Name = "ViewNameLabel";
            this.ViewNameLabel.Size = new System.Drawing.Size(210, 32);
            this.ViewNameLabel.TabIndex = 4;
            this.ViewNameLabel.Text = "Employee Details";
            // 
            // ViewPictureBox
            // 
            this.ViewPictureBox.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ViewPictureBox.Image")));
            this.ViewPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ViewPictureBox.Name = "ViewPictureBox";
            this.ViewPictureBox.Size = new System.Drawing.Size(84, 50);
            this.ViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ViewPictureBox.TabIndex = 3;
            this.ViewPictureBox.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1282, 754);
            this.Controls.Add(this.ViewNameLabel);
            this.Controls.Add(this.ViewPictureBox);
            this.Controls.Add(this.ViewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ViewPanel.ResumeLayout(false);
            this.ViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Label ViewNameLabel;
        private System.Windows.Forms.PictureBox ViewPictureBox;
        private System.Windows.Forms.TextBox ViewEmployeeAddressValue;
        private System.Windows.Forms.Label ViewEmployeeAddressLabel;
        private System.Windows.Forms.TextBox ViewEmployeeNameValue;
        private System.Windows.Forms.Label ViewEmployeeNameLabel;
        private System.Windows.Forms.TextBox ViewEmployeeIdValue;
        private System.Windows.Forms.Label ViewEmployeeIdLabel;
        private System.Windows.Forms.TextBox ViewEmployeeGenderValue;
        private System.Windows.Forms.Label ViewEmployeeGenderLabel;
        private System.Windows.Forms.TextBox ViewEmployeePositionValue;
        private System.Windows.Forms.Label ViewEmployeePositionLabel;
        private System.Windows.Forms.TextBox ViewEmployeePhoneValue;
        private System.Windows.Forms.Label ViewEmployeePhoneLabel;
        private System.Windows.Forms.Label ViewEmployeeDoBLabel;
        private System.Windows.Forms.TextBox ViewEmployeeDoBValue;
        private System.Windows.Forms.TextBox ViewEmployeeEducationValue;
        private System.Windows.Forms.Label ViewEmployeeEducationLabel;
        private System.Windows.Forms.TextBox StartViewEmployeeIdValue;
        private System.Windows.Forms.Label StrartViewEmployeeIdLabel;
        private System.Windows.Forms.Button ViewRefreshButton;
        private System.Windows.Forms.Button ViewPrintButton;
        private System.Windows.Forms.Button ViewReturnToHomeButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}