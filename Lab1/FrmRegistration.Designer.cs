namespace Lab1
{
    partial class FrmRegistration
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
            lblTitle = new Label();
            lblStudentNo = new Label();
            txtStudentNo = new TextBox();
            lblProgram = new Label();
            cboProgram = new ComboBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblMI = new Label();
            txtMI = new TextBox();
            txtAge = new TextBox();
            lblAge = new Label();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblBirthday = new Label();
            dtpBirthday = new DateTimePicker();
            lblContact = new Label();
            txtContact = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(19, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registration";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 9.75F);
            lblStudentNo.ForeColor = Color.Black;
            lblStudentNo.Location = new Point(12, 76);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(77, 17);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(100, 70);
            txtStudentNo.MaxLength = 11;
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(220, 25);
            txtStudentNo.TabIndex = 2;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 9.75F);
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(357, 76);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(59, 17);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // cboProgram
            // 
            cboProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProgram.FlatStyle = FlatStyle.Flat;
            cboProgram.FormattingEnabled = true;
            cboProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Business Administration", "BS Computer Engineering", "BS Criminology", "BS Tourism Management", "BS Hospitality Management" });
            cboProgram.Location = new Point(424, 73);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new Size(265, 25);
            cboProgram.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(19, 101);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(70, 17);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(345, 107);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 17);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(100, 101);
            txtLastName.MaxLength = 100;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 25);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(424, 104);
            txtFirstName.MaxLength = 100;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 25);
            txtFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            lblMI.AutoSize = true;
            lblMI.Font = new Font("Segoe UI", 9.75F);
            lblMI.ForeColor = Color.Black;
            lblMI.Location = new Point(599, 107);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(29, 17);
            lblMI.TabIndex = 9;
            lblMI.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(639, 104);
            txtMI.MaxLength = 2;
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(50, 25);
            txtMI.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(100, 132);
            txtAge.MaxLength = 3;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(80, 25);
            txtAge.TabIndex = 11;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9.75F);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(53, 135);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 17);
            lblAge.TabIndex = 12;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.75F);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(365, 138);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 17);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FlatStyle = FlatStyle.Flat;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(424, 135);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(120, 25);
            cboGender.TabIndex = 14;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 9.75F);
            lblBirthday.ForeColor = Color.Black;
            lblBirthday.Location = new Point(29, 163);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(55, 17);
            lblBirthday.TabIndex = 15;
            lblBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(90, 163);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(220, 25);
            dtpBirthday.TabIndex = 16;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContact.ForeColor = Color.Black;
            lblContact.Location = new Point(339, 171);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(77, 17);
            lblContact.TabIndex = 17;
            lblContact.Text = "Contact No.";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(424, 166);
            txtContact.MaxLength = 11;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(218, 25);
            txtContact.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(286, 212);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 40);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(709, 263);
            Controls.Add(btnRegister);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(dtpBirthday);
            Controls.Add(lblBirthday);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(txtMI);
            Controls.Add(lblMI);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(cboProgram);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudentNo;
        private TextBox txtStudentNo;
        private Label lblProgram;
        private ComboBox cboProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblMI;
        private TextBox txtMI;
        private TextBox txtAge;
        private Label lblAge;
        private Label lblGender;
        private ComboBox cboGender;
        private Label lblBirthday;
        private DateTimePicker dtpBirthday;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnRegister;
    }
}