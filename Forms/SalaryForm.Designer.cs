
namespace HRManagementSystem
{
    partial class SalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            this.SalaryPanelLabel = new System.Windows.Forms.Panel();
            this.SalaryRichBox = new System.Windows.Forms.RichTextBox();
            this.SalaryReturnToHomeButton = new System.Windows.Forms.Button();
            this.SalaryFetchDataButton = new System.Windows.Forms.Button();
            this.SalaryPrintButton = new System.Windows.Forms.Button();
            this.SalaryViewButton = new System.Windows.Forms.Button();
            this.SalaryEmployeeWorkedDaysValue = new System.Windows.Forms.TextBox();
            this.SalaryEmployeeWorkedDaysLabel = new System.Windows.Forms.Label();
            this.SalaryEmployeePositionValue = new System.Windows.Forms.TextBox();
            this.SalaryEmployeePositionLabel = new System.Windows.Forms.Label();
            this.SalaryEmployeeNameValue = new System.Windows.Forms.TextBox();
            this.SalaryEmployeeNameLabel = new System.Windows.Forms.Label();
            this.SalaryEmployeeIdValue = new System.Windows.Forms.TextBox();
            this.SalaryEmployeeIdLabel = new System.Windows.Forms.Label();
            this.SalaryEmployeePictureBox = new System.Windows.Forms.PictureBox();
            this.SalaryNameLabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SalaryPanelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEmployeePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryPanelLabel
            // 
            this.SalaryPanelLabel.BackColor = System.Drawing.Color.White;
            this.SalaryPanelLabel.Controls.Add(this.SalaryRichBox);
            this.SalaryPanelLabel.Controls.Add(this.SalaryReturnToHomeButton);
            this.SalaryPanelLabel.Controls.Add(this.SalaryFetchDataButton);
            this.SalaryPanelLabel.Controls.Add(this.SalaryPrintButton);
            this.SalaryPanelLabel.Controls.Add(this.SalaryViewButton);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeeWorkedDaysValue);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeeWorkedDaysLabel);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeePositionValue);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeePositionLabel);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeeNameValue);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeeNameLabel);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeeIdValue);
            this.SalaryPanelLabel.Controls.Add(this.SalaryEmployeeIdLabel);
            this.SalaryPanelLabel.Location = new System.Drawing.Point(1, 79);
            this.SalaryPanelLabel.Name = "SalaryPanelLabel";
            this.SalaryPanelLabel.Size = new System.Drawing.Size(1576, 575);
            this.SalaryPanelLabel.TabIndex = 0;
            // 
            // SalaryRichBox
            // 
            this.SalaryRichBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalaryRichBox.ForeColor = System.Drawing.Color.Black;
            this.SalaryRichBox.Location = new System.Drawing.Point(777, 43);
            this.SalaryRichBox.Name = "SalaryRichBox";
            this.SalaryRichBox.Size = new System.Drawing.Size(766, 437);
            this.SalaryRichBox.TabIndex = 34;
            this.SalaryRichBox.Text = "";
            this.SalaryRichBox.TextChanged += new System.EventHandler(this.SalaryRichBox_TextChanged);
            // 
            // SalaryReturnToHomeButton
            // 
            this.SalaryReturnToHomeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SalaryReturnToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryReturnToHomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalaryReturnToHomeButton.ForeColor = System.Drawing.Color.White;
            this.SalaryReturnToHomeButton.Location = new System.Drawing.Point(164, 455);
            this.SalaryReturnToHomeButton.Name = "SalaryReturnToHomeButton";
            this.SalaryReturnToHomeButton.Size = new System.Drawing.Size(126, 39);
            this.SalaryReturnToHomeButton.TabIndex = 33;
            this.SalaryReturnToHomeButton.Text = "Home";
            this.SalaryReturnToHomeButton.UseVisualStyleBackColor = false;
            this.SalaryReturnToHomeButton.Click += new System.EventHandler(this.SalaryReturnToHomeButton_Click);
            // 
            // SalaryFetchDataButton
            // 
            this.SalaryFetchDataButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SalaryFetchDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryFetchDataButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalaryFetchDataButton.ForeColor = System.Drawing.Color.White;
            this.SalaryFetchDataButton.Location = new System.Drawing.Point(579, 43);
            this.SalaryFetchDataButton.Name = "SalaryFetchDataButton";
            this.SalaryFetchDataButton.Size = new System.Drawing.Size(126, 39);
            this.SalaryFetchDataButton.TabIndex = 32;
            this.SalaryFetchDataButton.Text = "Fetch Data";
            this.SalaryFetchDataButton.UseVisualStyleBackColor = false;
            this.SalaryFetchDataButton.Click += new System.EventHandler(this.SalaryFetchDataButton_Click);
            // 
            // SalaryPrintButton
            // 
            this.SalaryPrintButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SalaryPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryPrintButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalaryPrintButton.ForeColor = System.Drawing.Color.White;
            this.SalaryPrintButton.Location = new System.Drawing.Point(1169, 506);
            this.SalaryPrintButton.Name = "SalaryPrintButton";
            this.SalaryPrintButton.Size = new System.Drawing.Size(126, 39);
            this.SalaryPrintButton.TabIndex = 31;
            this.SalaryPrintButton.Text = "Print";
            this.SalaryPrintButton.UseVisualStyleBackColor = false;
            this.SalaryPrintButton.Click += new System.EventHandler(this.SalaryPrintButton_Click);
            // 
            // SalaryViewButton
            // 
            this.SalaryViewButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SalaryViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryViewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalaryViewButton.ForeColor = System.Drawing.Color.White;
            this.SalaryViewButton.Location = new System.Drawing.Point(392, 455);
            this.SalaryViewButton.Name = "SalaryViewButton";
            this.SalaryViewButton.Size = new System.Drawing.Size(126, 39);
            this.SalaryViewButton.TabIndex = 30;
            this.SalaryViewButton.Text = "View";
            this.SalaryViewButton.UseVisualStyleBackColor = false;
            this.SalaryViewButton.Click += new System.EventHandler(this.SalaryViewButton_Click);
            // 
            // SalaryEmployeeWorkedDaysValue
            // 
            this.SalaryEmployeeWorkedDaysValue.Location = new System.Drawing.Point(344, 344);
            this.SalaryEmployeeWorkedDaysValue.Name = "SalaryEmployeeWorkedDaysValue";
            this.SalaryEmployeeWorkedDaysValue.Size = new System.Drawing.Size(162, 23);
            this.SalaryEmployeeWorkedDaysValue.TabIndex = 21;
            // 
            // SalaryEmployeeWorkedDaysLabel
            // 
            this.SalaryEmployeeWorkedDaysLabel.AutoSize = true;
            this.SalaryEmployeeWorkedDaysLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalaryEmployeeWorkedDaysLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SalaryEmployeeWorkedDaysLabel.Location = new System.Drawing.Point(66, 330);
            this.SalaryEmployeeWorkedDaysLabel.Name = "SalaryEmployeeWorkedDaysLabel";
            this.SalaryEmployeeWorkedDaysLabel.Size = new System.Drawing.Size(186, 37);
            this.SalaryEmployeeWorkedDaysLabel.TabIndex = 20;
            this.SalaryEmployeeWorkedDaysLabel.Text = "Worked Days";
            this.SalaryEmployeeWorkedDaysLabel.Click += new System.EventHandler(this.SalaryEmployeeWorkedDaysLabel_Click);
            // 
            // SalaryEmployeePositionValue
            // 
            this.SalaryEmployeePositionValue.Location = new System.Drawing.Point(341, 233);
            this.SalaryEmployeePositionValue.Name = "SalaryEmployeePositionValue";
            this.SalaryEmployeePositionValue.Size = new System.Drawing.Size(162, 23);
            this.SalaryEmployeePositionValue.TabIndex = 19;
            // 
            // SalaryEmployeePositionLabel
            // 
            this.SalaryEmployeePositionLabel.AutoSize = true;
            this.SalaryEmployeePositionLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalaryEmployeePositionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SalaryEmployeePositionLabel.Location = new System.Drawing.Point(66, 219);
            this.SalaryEmployeePositionLabel.Name = "SalaryEmployeePositionLabel";
            this.SalaryEmployeePositionLabel.Size = new System.Drawing.Size(252, 37);
            this.SalaryEmployeePositionLabel.TabIndex = 18;
            this.SalaryEmployeePositionLabel.Text = "Employee Position";
            this.SalaryEmployeePositionLabel.Click += new System.EventHandler(this.SalaryEmployeePositionLabel_Click);
            // 
            // SalaryEmployeeNameValue
            // 
            this.SalaryEmployeeNameValue.Location = new System.Drawing.Point(344, 145);
            this.SalaryEmployeeNameValue.Name = "SalaryEmployeeNameValue";
            this.SalaryEmployeeNameValue.Size = new System.Drawing.Size(162, 23);
            this.SalaryEmployeeNameValue.TabIndex = 17;
            // 
            // SalaryEmployeeNameLabel
            // 
            this.SalaryEmployeeNameLabel.AutoSize = true;
            this.SalaryEmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalaryEmployeeNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SalaryEmployeeNameLabel.Location = new System.Drawing.Point(66, 131);
            this.SalaryEmployeeNameLabel.Name = "SalaryEmployeeNameLabel";
            this.SalaryEmployeeNameLabel.Size = new System.Drawing.Size(224, 37);
            this.SalaryEmployeeNameLabel.TabIndex = 16;
            this.SalaryEmployeeNameLabel.Text = "Employee Name";
            // 
            // SalaryEmployeeIdValue
            // 
            this.SalaryEmployeeIdValue.Location = new System.Drawing.Point(341, 57);
            this.SalaryEmployeeIdValue.Name = "SalaryEmployeeIdValue";
            this.SalaryEmployeeIdValue.Size = new System.Drawing.Size(162, 23);
            this.SalaryEmployeeIdValue.TabIndex = 15;
            this.SalaryEmployeeIdValue.TextChanged += new System.EventHandler(this.SalaryEmployeeIdValue_TextChanged);
            // 
            // SalaryEmployeeIdLabel
            // 
            this.SalaryEmployeeIdLabel.AutoSize = true;
            this.SalaryEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SalaryEmployeeIdLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SalaryEmployeeIdLabel.Location = new System.Drawing.Point(66, 43);
            this.SalaryEmployeeIdLabel.Name = "SalaryEmployeeIdLabel";
            this.SalaryEmployeeIdLabel.Size = new System.Drawing.Size(176, 37);
            this.SalaryEmployeeIdLabel.TabIndex = 14;
            this.SalaryEmployeeIdLabel.Text = "Employee ID";
            // 
            // SalaryEmployeePictureBox
            // 
            this.SalaryEmployeePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SalaryEmployeePictureBox.Image")));
            this.SalaryEmployeePictureBox.Location = new System.Drawing.Point(12, 12);
            this.SalaryEmployeePictureBox.Name = "SalaryEmployeePictureBox";
            this.SalaryEmployeePictureBox.Size = new System.Drawing.Size(100, 61);
            this.SalaryEmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalaryEmployeePictureBox.TabIndex = 6;
            this.SalaryEmployeePictureBox.TabStop = false;
            // 
            // SalaryNameLabel
            // 
            this.SalaryNameLabel.AutoSize = true;
            this.SalaryNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SalaryNameLabel.ForeColor = System.Drawing.Color.White;
            this.SalaryNameLabel.Location = new System.Drawing.Point(118, 30);
            this.SalaryNameLabel.Name = "SalaryNameLabel";
            this.SalaryNameLabel.Size = new System.Drawing.Size(229, 32);
            this.SalaryNameLabel.TabIndex = 5;
            this.SalaryNameLabel.Text = "Salary Information";
            this.SalaryNameLabel.Click += new System.EventHandler(this.EmployeeNameLabel_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1575, 678);
            this.Controls.Add(this.SalaryEmployeePictureBox);
            this.Controls.Add(this.SalaryNameLabel);
            this.Controls.Add(this.SalaryPanelLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.SalaryPanelLabel.ResumeLayout(false);
            this.SalaryPanelLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryEmployeePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SalaryPanelLabel;
        private System.Windows.Forms.PictureBox SalaryEmployeePictureBox;
        private System.Windows.Forms.Label SalaryNameLabel;
        private System.Windows.Forms.TextBox SalaryEmployeeNameValue;
        private System.Windows.Forms.Label SalaryEmployeeNameLabel;
        private System.Windows.Forms.TextBox SalaryEmployeeIdValue;
        private System.Windows.Forms.Label SalaryEmployeeIdLabel;
        private System.Windows.Forms.TextBox SalaryEmployeeWorkedDaysValue;
        private System.Windows.Forms.Label SalaryEmployeeWorkedDaysLabel;
        private System.Windows.Forms.TextBox SalaryEmployeePositionValue;
        private System.Windows.Forms.Label SalaryEmployeePositionLabel;
        private System.Windows.Forms.Button SalaryReturnToHomeButton;
        private System.Windows.Forms.Button SalaryFetchDataButton;
        private System.Windows.Forms.Button SalaryPrintButton;
        private System.Windows.Forms.Button SalaryViewButton;
        private System.Windows.Forms.RichTextBox SalaryRichBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}