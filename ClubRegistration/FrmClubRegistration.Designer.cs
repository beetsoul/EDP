namespace ClubRegistration
{
    partial class FrmClubRegistration
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grpRegistration = new GroupBox();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            lblGender = new Label();
            lblAge = new Label();
            txtAge = new TextBox();
            txtMiddleName = new TextBox();
            lblMiddleName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lblProgram = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            btnRegister = new Button();
            btnUpdate = new Button();
            grpList = new GroupBox();
            dataGridView = new DataGridView();
            btnRefresh = new Button();
            grpRegistration.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // grpRegistration
            // 
            grpRegistration.BackColor = SystemColors.ActiveCaption;
            grpRegistration.Controls.Add(cmbGender);
            grpRegistration.Controls.Add(cmbProgram);
            grpRegistration.Controls.Add(lblGender);
            grpRegistration.Controls.Add(lblAge);
            grpRegistration.Controls.Add(txtAge);
            grpRegistration.Controls.Add(txtMiddleName);
            grpRegistration.Controls.Add(lblMiddleName);
            grpRegistration.Controls.Add(txtFirstName);
            grpRegistration.Controls.Add(lblFirstName);
            grpRegistration.Controls.Add(txtLastName);
            grpRegistration.Controls.Add(lblLastName);
            grpRegistration.Controls.Add(lblProgram);
            grpRegistration.Controls.Add(txtStudentId);
            grpRegistration.Controls.Add(lblStudentId);
            grpRegistration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            grpRegistration.ForeColor = Color.Black;
            grpRegistration.Location = new Point(16, 15);
            grpRegistration.Name = "grpRegistration";
            grpRegistration.Size = new Size(558, 235);
            grpRegistration.TabIndex = 0;
            grpRegistration.TabStop = false;
            grpRegistration.Text = "Club Registration";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.ForeColor = Color.Black;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Rather not to say" });
            cmbGender.Location = new Point(124, 184);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(170, 29);
            cmbGender.TabIndex = 14;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.White;
            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProgram.FlatStyle = FlatStyle.Flat;
            cmbProgram.ForeColor = Color.Black;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Hospitality Management", "BS in Business Administration" });
            cmbProgram.Location = new Point(284, 54);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(250, 29);
            cmbProgram.TabIndex = 13;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.ForeColor = Color.Black;
            lblGender.Location = new Point(121, 159);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 21);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.ForeColor = Color.Black;
            lblAge.Location = new Point(15, 160);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 21);
            lblAge.TabIndex = 11;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.ForeColor = Color.Black;
            txtAge.Location = new Point(18, 185);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 29);
            txtAge.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(370, 120);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(170, 29);
            txtMiddleName.TabIndex = 9;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.ForeColor = Color.Black;
            lblMiddleName.Location = new Point(367, 95);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(110, 21);
            lblMiddleName.TabIndex = 8;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(194, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 29);
            txtFirstName.TabIndex = 7;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Location = new Point(191, 95);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 21);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(18, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 29);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.Black;
            lblLastName.Location = new Point(15, 95);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(87, 21);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.ForeColor = Color.Black;
            lblProgram.Location = new Point(281, 29);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(77, 21);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program:";
            // 
            // txtStudentId
            // 
            txtStudentId.BackColor = Color.White;
            txtStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtStudentId.ForeColor = Color.Black;
            txtStudentId.Location = new Point(18, 55);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(256, 29);
            txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.ForeColor = Color.Black;
            lblStudentId.Location = new Point(15, 30);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(92, 21);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(128, 128, 255);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(580, 25);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 40);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(580, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // grpList
            // 
            grpList.Controls.Add(dataGridView);
            grpList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            grpList.ForeColor = Color.Black;
            grpList.Location = new Point(15, 265);
            grpList.Name = "grpList";
            grpList.Size = new Size(715, 250);
            grpList.TabIndex = 3;
            grpList.TabStop = false;
            grpList.Text = "List Of Club Members";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(18, 22, 28);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 32;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(18, 22, 28);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(10, 28);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 28;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(699, 212);
            dataGridView.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlDark;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(580, 210);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(735, 524);
            Controls.Add(btnRefresh);
            Controls.Add(grpList);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(grpRegistration);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClubRegistration";
            Load += FrmClubRegistration_Load;
            grpRegistration.ResumeLayout(false);
            grpRegistration.PerformLayout();
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRegistration;
        private Label lblProgram;
        private TextBox txtStudentId;
        private Label lblStudentId;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblMiddleName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblGender;
        private Label lblAge;
        private TextBox txtAge;
        private TextBox txtMiddleName;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private Button btnRegister;
        private Button btnUpdate;
        private GroupBox grpList;
        private DataGridView dataGridView;
        private Button btnRefresh;
    }
}
