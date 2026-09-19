namespace OrganizationProfile
{
    partial class frmRegistration
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
            lblTitle = new Label();
            txtStudentNo = new TextBox();
            cbPrograms = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtAge = new TextBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            lblStudentNo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblContactNo = new Label();
            label5 = new Label();
            lblFirstName = new Label();
            lblProgram = new Label();
            lblMiddleInitial = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(153, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registration";
            // 
            // txtStudentNo
            // 
            txtStudentNo.BorderStyle = BorderStyle.FixedSingle;
            txtStudentNo.Font = new Font("Segoe UI", 10F);
            txtStudentNo.Location = new Point(111, 73);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(150, 25);
            txtStudentNo.TabIndex = 1;
            // 
            // cbPrograms
            // 
            cbPrograms.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrograms.Font = new Font("Segoe UI", 10F);
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Location = new Point(364, 73);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(222, 25);
            cbPrograms.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(111, 108);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 25);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(364, 107);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 25);
            txtFirstName.TabIndex = 4;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleInitial.Font = new Font("Segoe UI", 10F);
            txtMiddleInitial.Location = new Point(579, 107);
            txtMiddleInitial.MaxLength = 1;
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(40, 25);
            txtMiddleInitial.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 10F);
            txtAge.Location = new Point(111, 143);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 25);
            txtAge.TabIndex = 6;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 10F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(364, 142);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(150, 25);
            cbGender.TabIndex = 7;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.CalendarFont = new Font("Segoe UI", 12F);
            datePickerBirthday.Location = new Point(111, 192);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(196, 23);
            datePickerBirthday.TabIndex = 8;
            // 
            // txtContactNo
            // 
            txtContactNo.BorderStyle = BorderStyle.FixedSingle;
            txtContactNo.Font = new Font("Segoe UI", 10F);
            txtContactNo.Location = new Point(436, 187);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(162, 25);
            txtContactNo.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(64, 64, 64);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(240, 266);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 44);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStudentNo.ForeColor = SystemColors.ActiveCaptionText;
            lblStudentNo.Location = new Point(12, 74);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(101, 21);
            lblStudentNo.TabIndex = 11;
            lblStudentNo.Text = "Student No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(13, 108);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 12;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(60, 144);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 13;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(30, 192);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 14;
            label3.Text = "Birthday";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblContactNo.ForeColor = SystemColors.ActiveCaptionText;
            lblContactNo.Location = new Point(330, 191);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(100, 21);
            lblContactNo.TabIndex = 15;
            lblContactNo.Text = "Contact No.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(293, 143);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 16;
            label5.Text = "Gender";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFirstName.ForeColor = SystemColors.ActiveCaptionText;
            lblFirstName.Location = new Point(272, 107);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 21);
            lblFirstName.TabIndex = 17;
            lblFirstName.Text = "First Name";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProgram.ForeColor = SystemColors.ActiveCaptionText;
            lblProgram.Location = new Point(288, 74);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(76, 21);
            lblProgram.TabIndex = 18;
            lblProgram.Text = "Program";
            // 
            // lblMiddleInitial
            // 
            lblMiddleInitial.AutoSize = true;
            lblMiddleInitial.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMiddleInitial.ForeColor = SystemColors.ActiveCaptionText;
            lblMiddleInitial.Location = new Point(535, 107);
            lblMiddleInitial.Name = "lblMiddleInitial";
            lblMiddleInitial.Size = new Size(38, 21);
            lblMiddleInitial.TabIndex = 19;
            lblMiddleInitial.Text = "M.I.";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(636, 361);
            Controls.Add(lblMiddleInitial);
            Controls.Add(lblProgram);
            Controls.Add(lblFirstName);
            Controls.Add(label5);
            Controls.Add(lblContactNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStudentNo);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(cbPrograms);
            Controls.Add(txtStudentNo);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organization Profile";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtStudentNo;
        private ComboBox cbPrograms;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtAge;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private TextBox txtContactNo;
        private Button btnRegister;
        private Label lblStudentNo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblContactNo;
        private Label label5;
        private Label lblFirstName;
        private Label lblProgram;
        private Label lblMiddleInitial;
    }
}