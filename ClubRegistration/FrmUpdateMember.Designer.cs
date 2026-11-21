namespace ClubRegistration
{
    partial class FrmUpdateMember
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
            lblStudentId = new Label();
            cmbStudentId = new ComboBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblProgram = new Label();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(12, 18);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(95, 21);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // cmbStudentId
            // 
            cmbStudentId.BackColor = Color.White;
            cmbStudentId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudentId.FlatStyle = FlatStyle.Flat;
            cmbStudentId.ForeColor = Color.Black;
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Location = new Point(15, 43);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(280, 25);
            cmbStudentId.TabIndex = 2;
            cmbStudentId.SelectedIndexChanged += cmbStudentId_SelectedIndexChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(9, 74);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(91, 21);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(12, 99);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 25);
            txtLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(9, 130);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 21);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(12, 155);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(280, 25);
            txtFirstName.TabIndex = 6;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMiddleName.ForeColor = Color.Black;
            lblMiddleName.Location = new Point(9, 188);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(115, 21);
            lblMiddleName.TabIndex = 7;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(12, 213);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(280, 25);
            txtMiddleName.TabIndex = 8;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(12, 248);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 21);
            lblAge.TabIndex = 9;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(15, 273);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(67, 25);
            txtAge.TabIndex = 10;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(12, 304);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(70, 21);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.ForeColor = Color.Black;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(15, 329);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(180, 25);
            cmbGender.TabIndex = 12;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.White;
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.FlatStyle = FlatStyle.Flat;
            cmbProgram.ForeColor = Color.Black;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(15, 386);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(277, 25);
            cmbProgram.TabIndex = 13;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(12, 361);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(80, 21);
            lblProgram.TabIndex = 14;
            lblProgram.Text = "Program:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.ControlDark;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Location = new Point(71, 426);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(150, 40);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(308, 478);
            Controls.Add(btnConfirm);
            Controls.Add(lblProgram);
            Controls.Add(cmbProgram);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cmbStudentId);
            Controls.Add(lblStudentId);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private ComboBox cmbStudentId;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Label lblProgram;
        private Button btnConfirm;
    }
}