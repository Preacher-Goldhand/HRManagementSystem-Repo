
namespace HRManagementSystem
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.EmployeeEmployeeDGV = new System.Windows.Forms.DataGridView();
            this.EmployeeReturnToHomeButton = new System.Windows.Forms.Button();
            this.EmployeeDeleteButton = new System.Windows.Forms.Button();
            this.EmployeeEditButton = new System.Windows.Forms.Button();
            this.EmployeeAddButton = new System.Windows.Forms.Button();
            this.EmployeeEmployeeGenderValue = new System.Windows.Forms.ComboBox();
            this.EmpoloyeeEmployeeGenderLabel = new System.Windows.Forms.Label();
            this.EmployeeEmployeeEducationValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeEmployeePhoneValue = new System.Windows.Forms.TextBox();
            this.EmployeeEmployeePhoneLabel = new System.Windows.Forms.Label();
            this.EmployeeEmployeeDOBValue = new System.Windows.Forms.DateTimePicker();
            this.EmployeeEmployeeDOBLabel = new System.Windows.Forms.Label();
            this.EmployeeEmployeePositionValue = new System.Windows.Forms.ComboBox();
            this.EmployeeEmployeePositionLabel = new System.Windows.Forms.Label();
            this.EmployeeEmployeeAddressValue = new System.Windows.Forms.TextBox();
            this.EmployeeEmployeeAddressLabel = new System.Windows.Forms.Label();
            this.EmployeeEmployeeNameValue = new System.Windows.Forms.TextBox();
            this.EmployeeEmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeEmployeeIdValue = new System.Windows.Forms.TextBox();
            this.EmployeeEmployeeIdLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeEmployeePictureBox = new System.Windows.Forms.PictureBox();
            this.EmployeePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeEmployeeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeEmployeePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.BackColor = System.Drawing.Color.White;
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeDGV);
            this.EmployeePanel.Controls.Add(this.EmployeeReturnToHomeButton);
            this.EmployeePanel.Controls.Add(this.EmployeeDeleteButton);
            this.EmployeePanel.Controls.Add(this.EmployeeEditButton);
            this.EmployeePanel.Controls.Add(this.EmployeeAddButton);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeGenderValue);
            this.EmployeePanel.Controls.Add(this.EmpoloyeeEmployeeGenderLabel);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeEducationValue);
            this.EmployeePanel.Controls.Add(this.label1);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeePhoneValue);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeePhoneLabel);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeDOBValue);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeDOBLabel);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeePositionValue);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeePositionLabel);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeAddressValue);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeAddressLabel);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeNameValue);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeNameLabel);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeIdValue);
            this.EmployeePanel.Controls.Add(this.EmployeeEmployeeIdLabel);
            this.EmployeePanel.Location = new System.Drawing.Point(0, 72);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(1608, 689);
            this.EmployeePanel.TabIndex = 0;
            this.EmployeePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EmployeePanel_Paint);
            // 
            // EmployeeEmployeeDGV
            // 
            this.EmployeeEmployeeDGV.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeEmployeeDGV.GridColor = System.Drawing.Color.Black;
            this.EmployeeEmployeeDGV.Location = new System.Drawing.Point(544, 26);
            this.EmployeeEmployeeDGV.Name = "EmployeeEmployeeDGV";
            this.EmployeeEmployeeDGV.RowTemplate.Height = 25;
            this.EmployeeEmployeeDGV.Size = new System.Drawing.Size(830, 639);
            this.EmployeeEmployeeDGV.TabIndex = 30;
            this.EmployeeEmployeeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeeReturnToHomeButton
            // 
            this.EmployeeReturnToHomeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EmployeeReturnToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeReturnToHomeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeReturnToHomeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeReturnToHomeButton.Location = new System.Drawing.Point(146, 635);
            this.EmployeeReturnToHomeButton.Name = "EmployeeReturnToHomeButton";
            this.EmployeeReturnToHomeButton.Size = new System.Drawing.Size(126, 39);
            this.EmployeeReturnToHomeButton.TabIndex = 29;
            this.EmployeeReturnToHomeButton.Text = "Home";
            this.EmployeeReturnToHomeButton.UseVisualStyleBackColor = false;
            this.EmployeeReturnToHomeButton.Click += new System.EventHandler(this.EmployeeReturnToHomeButton_Click);
            // 
            // EmployeeDeleteButton
            // 
            this.EmployeeDeleteButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EmployeeDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeDeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeDeleteButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeDeleteButton.Location = new System.Drawing.Point(281, 590);
            this.EmployeeDeleteButton.Name = "EmployeeDeleteButton";
            this.EmployeeDeleteButton.Size = new System.Drawing.Size(126, 39);
            this.EmployeeDeleteButton.TabIndex = 28;
            this.EmployeeDeleteButton.Text = "Delete";
            this.EmployeeDeleteButton.UseVisualStyleBackColor = false;
            this.EmployeeDeleteButton.Click += new System.EventHandler(this.EmployeeDeleteButton_Click);
            // 
            // EmployeeEditButton
            // 
            this.EmployeeEditButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeEditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeEditButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeEditButton.Location = new System.Drawing.Point(146, 590);
            this.EmployeeEditButton.Name = "EmployeeEditButton";
            this.EmployeeEditButton.Size = new System.Drawing.Size(126, 39);
            this.EmployeeEditButton.TabIndex = 27;
            this.EmployeeEditButton.Text = "Edit";
            this.EmployeeEditButton.UseVisualStyleBackColor = false;
            this.EmployeeEditButton.Click += new System.EventHandler(this.EmployeeEditButton_Click);
            // 
            // EmployeeAddButton
            // 
            this.EmployeeAddButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EmployeeAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeAddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeAddButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeAddButton.Location = new System.Drawing.Point(12, 590);
            this.EmployeeAddButton.Name = "EmployeeAddButton";
            this.EmployeeAddButton.Size = new System.Drawing.Size(126, 39);
            this.EmployeeAddButton.TabIndex = 26;
            this.EmployeeAddButton.Text = "Add";
            this.EmployeeAddButton.UseVisualStyleBackColor = false;
            this.EmployeeAddButton.Click += new System.EventHandler(this.EmployeeAddButton_Click);
            // 
            // EmployeeEmployeeGenderValue
            // 
            this.EmployeeEmployeeGenderValue.FormattingEnabled = true;
            this.EmployeeEmployeeGenderValue.Items.AddRange(new object[] {
            "Male",
            "Female "});
            this.EmployeeEmployeeGenderValue.Location = new System.Drawing.Point(278, 247);
            this.EmployeeEmployeeGenderValue.Name = "EmployeeEmployeeGenderValue";
            this.EmployeeEmployeeGenderValue.Size = new System.Drawing.Size(165, 23);
            this.EmployeeEmployeeGenderValue.TabIndex = 25;
            this.EmployeeEmployeeGenderValue.SelectedIndexChanged += new System.EventHandler(this.EmpoloyeeEmployeeGenderValue_SelectedIndexChanged);
            // 
            // EmpoloyeeEmployeeGenderLabel
            // 
            this.EmpoloyeeEmployeeGenderLabel.AutoSize = true;
            this.EmpoloyeeEmployeeGenderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmpoloyeeEmployeeGenderLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmpoloyeeEmployeeGenderLabel.Location = new System.Drawing.Point(0, 232);
            this.EmpoloyeeEmployeeGenderLabel.Name = "EmpoloyeeEmployeeGenderLabel";
            this.EmpoloyeeEmployeeGenderLabel.Size = new System.Drawing.Size(237, 37);
            this.EmpoloyeeEmployeeGenderLabel.TabIndex = 24;
            this.EmpoloyeeEmployeeGenderLabel.Text = "Employee Gender";
            // 
            // EmployeeEmployeeEducationValue
            // 
            this.EmployeeEmployeeEducationValue.FormattingEnabled = true;
            this.EmployeeEmployeeEducationValue.Items.AddRange(new object[] {
            "High School Graduate ",
            "Bachelor of Arts",
            "Bachelor of Education",
            "Bachelor of Engineering",
            "Bachelor of Science",
            "Master of Arts",
            "Master of Business Administration",
            "Master of Education",
            "Master of Engineering",
            "Master of Science",
            "Doctor of Philosophy ",
            "Doctor of Engineering",
            "Doctor of Science"});
            this.EmployeeEmployeeEducationValue.Location = new System.Drawing.Point(281, 534);
            this.EmployeeEmployeeEducationValue.Name = "EmployeeEmployeeEducationValue";
            this.EmployeeEmployeeEducationValue.Size = new System.Drawing.Size(162, 23);
            this.EmployeeEmployeeEducationValue.TabIndex = 23;
            this.EmployeeEmployeeEducationValue.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(0, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Employee Education";
            // 
            // EmployeeEmployeePhoneValue
            // 
            this.EmployeeEmployeePhoneValue.Location = new System.Drawing.Point(278, 469);
            this.EmployeeEmployeePhoneValue.Name = "EmployeeEmployeePhoneValue";
            this.EmployeeEmployeePhoneValue.Size = new System.Drawing.Size(165, 23);
            this.EmployeeEmployeePhoneValue.TabIndex = 21;
            this.EmployeeEmployeePhoneValue.TextChanged += new System.EventHandler(this.EmployeeEmployeePhoneValue_TextChanged);
            // 
            // EmployeeEmployeePhoneLabel
            // 
            this.EmployeeEmployeePhoneLabel.AutoSize = true;
            this.EmployeeEmployeePhoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeEmployeePhoneLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEmployeePhoneLabel.Location = new System.Drawing.Point(0, 455);
            this.EmployeeEmployeePhoneLabel.Name = "EmployeeEmployeePhoneLabel";
            this.EmployeeEmployeePhoneLabel.Size = new System.Drawing.Size(233, 37);
            this.EmployeeEmployeePhoneLabel.TabIndex = 20;
            this.EmployeeEmployeePhoneLabel.Text = "Employee Phone ";
            // 
            // EmployeeEmployeeDOBValue
            // 
            this.EmployeeEmployeeDOBValue.Location = new System.Drawing.Point(278, 314);
            this.EmployeeEmployeeDOBValue.Name = "EmployeeEmployeeDOBValue";
            this.EmployeeEmployeeDOBValue.Size = new System.Drawing.Size(218, 23);
            this.EmployeeEmployeeDOBValue.TabIndex = 19;
            this.EmployeeEmployeeDOBValue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EmployeeEmployeeDOBLabel
            // 
            this.EmployeeEmployeeDOBLabel.AutoSize = true;
            this.EmployeeEmployeeDOBLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeEmployeeDOBLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEmployeeDOBLabel.Location = new System.Drawing.Point(0, 302);
            this.EmployeeEmployeeDOBLabel.Name = "EmployeeEmployeeDOBLabel";
            this.EmployeeEmployeeDOBLabel.Size = new System.Drawing.Size(201, 37);
            this.EmployeeEmployeeDOBLabel.TabIndex = 18;
            this.EmployeeEmployeeDOBLabel.Text = "Employee DoB";
            this.EmployeeEmployeeDOBLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EmployeeEmployeePositionValue
            // 
            this.EmployeeEmployeePositionValue.FormattingEnabled = true;
            this.EmployeeEmployeePositionValue.Items.AddRange(new object[] {
            "Accountant",
            "Manager",
            "Junior Developer",
            "Medium Developer",
            "Senior Developer",
            "Receptionist ",
            "Marketing Sepcialist "});
            this.EmployeeEmployeePositionValue.Location = new System.Drawing.Point(275, 391);
            this.EmployeeEmployeePositionValue.Name = "EmployeeEmployeePositionValue";
            this.EmployeeEmployeePositionValue.Size = new System.Drawing.Size(168, 23);
            this.EmployeeEmployeePositionValue.TabIndex = 17;
            this.EmployeeEmployeePositionValue.SelectedIndexChanged += new System.EventHandler(this.EmployeeEmployeePositionValue_SelectedIndexChanged);
            // 
            // EmployeeEmployeePositionLabel
            // 
            this.EmployeeEmployeePositionLabel.AutoSize = true;
            this.EmployeeEmployeePositionLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeEmployeePositionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEmployeePositionLabel.Location = new System.Drawing.Point(0, 377);
            this.EmployeeEmployeePositionLabel.Name = "EmployeeEmployeePositionLabel";
            this.EmployeeEmployeePositionLabel.Size = new System.Drawing.Size(252, 37);
            this.EmployeeEmployeePositionLabel.TabIndex = 16;
            this.EmployeeEmployeePositionLabel.Text = "Employee Position";
            // 
            // EmployeeEmployeeAddressValue
            // 
            this.EmployeeEmployeeAddressValue.Location = new System.Drawing.Point(278, 173);
            this.EmployeeEmployeeAddressValue.Name = "EmployeeEmployeeAddressValue";
            this.EmployeeEmployeeAddressValue.Size = new System.Drawing.Size(218, 23);
            this.EmployeeEmployeeAddressValue.TabIndex = 15;
            // 
            // EmployeeEmployeeAddressLabel
            // 
            this.EmployeeEmployeeAddressLabel.AutoSize = true;
            this.EmployeeEmployeeAddressLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeEmployeeAddressLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEmployeeAddressLabel.Location = new System.Drawing.Point(0, 159);
            this.EmployeeEmployeeAddressLabel.Name = "EmployeeEmployeeAddressLabel";
            this.EmployeeEmployeeAddressLabel.Size = new System.Drawing.Size(247, 37);
            this.EmployeeEmployeeAddressLabel.TabIndex = 14;
            this.EmployeeEmployeeAddressLabel.Text = "Employee Address";
            // 
            // EmployeeEmployeeNameValue
            // 
            this.EmployeeEmployeeNameValue.Location = new System.Drawing.Point(278, 105);
            this.EmployeeEmployeeNameValue.Name = "EmployeeEmployeeNameValue";
            this.EmployeeEmployeeNameValue.Size = new System.Drawing.Size(162, 23);
            this.EmployeeEmployeeNameValue.TabIndex = 13;
            this.EmployeeEmployeeNameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeeEmployeeNameLabel
            // 
            this.EmployeeEmployeeNameLabel.AutoSize = true;
            this.EmployeeEmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeEmployeeNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEmployeeNameLabel.Location = new System.Drawing.Point(0, 91);
            this.EmployeeEmployeeNameLabel.Name = "EmployeeEmployeeNameLabel";
            this.EmployeeEmployeeNameLabel.Size = new System.Drawing.Size(224, 37);
            this.EmployeeEmployeeNameLabel.TabIndex = 12;
            this.EmployeeEmployeeNameLabel.Text = "Employee Name";
            this.EmployeeEmployeeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeEmployeeIdValue
            // 
            this.EmployeeEmployeeIdValue.Location = new System.Drawing.Point(275, 40);
            this.EmployeeEmployeeIdValue.Name = "EmployeeEmployeeIdValue";
            this.EmployeeEmployeeIdValue.Size = new System.Drawing.Size(162, 23);
            this.EmployeeEmployeeIdValue.TabIndex = 11;
            this.EmployeeEmployeeIdValue.TextChanged += new System.EventHandler(this.EmployeeEmployeeIdValue_TextChanged);
            // 
            // EmployeeEmployeeIdLabel
            // 
            this.EmployeeEmployeeIdLabel.AutoSize = true;
            this.EmployeeEmployeeIdLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmployeeEmployeeIdLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.EmployeeEmployeeIdLabel.Location = new System.Drawing.Point(0, 26);
            this.EmployeeEmployeeIdLabel.Name = "EmployeeEmployeeIdLabel";
            this.EmployeeEmployeeIdLabel.Size = new System.Drawing.Size(176, 37);
            this.EmployeeEmployeeIdLabel.TabIndex = 10;
            this.EmployeeEmployeeIdLabel.Text = "Employee ID";
            this.EmployeeEmployeeIdLabel.Click += new System.EventHandler(this.PasswordLabale_Click);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmployeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(118, 25);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(270, 32);
            this.EmployeeNameLabel.TabIndex = 3;
            this.EmployeeNameLabel.Text = "Employee Information";
            this.EmployeeNameLabel.Click += new System.EventHandler(this.EmployeeNameLabel_Click);
            // 
            // EmployeeEmployeePictureBox
            // 
            this.EmployeeEmployeePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeEmployeePictureBox.Image")));
            this.EmployeeEmployeePictureBox.Location = new System.Drawing.Point(12, 10);
            this.EmployeeEmployeePictureBox.Name = "EmployeeEmployeePictureBox";
            this.EmployeeEmployeePictureBox.Size = new System.Drawing.Size(100, 56);
            this.EmployeeEmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeeEmployeePictureBox.TabIndex = 4;
            this.EmployeeEmployeePictureBox.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1428, 786);
            this.Controls.Add(this.EmployeeEmployeePictureBox);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.EmployeePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.EmployeePanel.ResumeLayout(false);
            this.EmployeePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeEmployeeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeEmployeePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.TextBox EmployeeEmployeeIdValue;
        private System.Windows.Forms.Label EmployeeEmployeeIdLabel;
        private System.Windows.Forms.TextBox EmployeeEmployeeNameValue;
        private System.Windows.Forms.Label EmployeeEmployeeNameLabel;
        private System.Windows.Forms.TextBox EmployeeEmployeeAddressValue;
        private System.Windows.Forms.Label EmployeeEmployeeAddressLabel;
        private System.Windows.Forms.Label EmployeeEmployeePositionLabel;
        private System.Windows.Forms.Label EmployeeEmployeeDOBLabel;
        private System.Windows.Forms.ComboBox EmployeeEmployeePositionValue;
        private System.Windows.Forms.DateTimePicker EmployeeEmployeeDOBValue;
        private System.Windows.Forms.TextBox EmployeeEmployeePhoneValue;
        private System.Windows.Forms.Label EmployeeEmployeePhoneLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmployeeEmployeeEducationValue;
        private System.Windows.Forms.ComboBox EmployeeEmployeeGenderValue;
        private System.Windows.Forms.Label EmpoloyeeEmployeeGenderLabel;
        private System.Windows.Forms.Button EmployeeReturnToHomeButton;
        private System.Windows.Forms.Button EmployeeDeleteButton;
        private System.Windows.Forms.Button EmployeeEditButton;
        private System.Windows.Forms.Button EmployeeAddButton;
        private System.Windows.Forms.PictureBox EmployeeEmployeePictureBox;
        private System.Windows.Forms.DataGridView EmployeeEmployeeDGV;
    }
}