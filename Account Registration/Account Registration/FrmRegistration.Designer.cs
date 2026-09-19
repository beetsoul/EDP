namespace Account_Registration
{
    partial class FrmRegistration
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
            label1 = new Label();
            txtBoxStudentNo = new TextBox();
            txtBoxProgram = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxLastName = new TextBox();
            txtBoxFirstName = new TextBox();
            txtBoxMiddleName = new TextBox();
            label5 = new Label();
            cbProgram = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtBoxAge = new TextBox();
            txtBoxContactNo = new TextBox();
            label8 = new Label();
            txtBoxAddress = new TextBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // txtBoxStudentNo
            // 
            txtBoxStudentNo.Location = new Point(12, 33);
            txtBoxStudentNo.Name = "txtBoxStudentNo";
            txtBoxStudentNo.Size = new Size(188, 23);
            txtBoxStudentNo.TabIndex = 1;
            // 
            // txtBoxProgram
            // 
            txtBoxProgram.AutoSize = true;
            txtBoxProgram.Font = new Font("Segoe UI", 12F);
            txtBoxProgram.Location = new Point(208, 9);
            txtBoxProgram.Name = "txtBoxProgram";
            txtBoxProgram.Size = new Size(74, 21);
            txtBoxProgram.TabIndex = 2;
            txtBoxProgram.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(208, 68);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 4;
            label4.Text = "First Name";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(12, 92);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(188, 23);
            txtBoxLastName.TabIndex = 5;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(208, 92);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(188, 23);
            txtBoxFirstName.TabIndex = 6;
            // 
            // txtBoxMiddleName
            // 
            txtBoxMiddleName.Location = new Point(402, 92);
            txtBoxMiddleName.Name = "txtBoxMiddleName";
            txtBoxMiddleName.Size = new Size(188, 23);
            txtBoxMiddleName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(402, 68);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 8;
            label5.Text = "Middle Name";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Computer Engineering" });
            cbProgram.Location = new Point(208, 33);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(264, 23);
            cbProgram.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 118);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 10;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(210, 118);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 11;
            label7.Text = "Contact No.:";
            // 
            // txtBoxAge
            // 
            txtBoxAge.Location = new Point(12, 142);
            txtBoxAge.Name = "txtBoxAge";
            txtBoxAge.Size = new Size(188, 23);
            txtBoxAge.TabIndex = 12;
            // 
            // txtBoxContactNo
            // 
            txtBoxContactNo.Location = new Point(208, 142);
            txtBoxContactNo.Name = "txtBoxContactNo";
            txtBoxContactNo.Size = new Size(188, 23);
            txtBoxContactNo.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 168);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 14;
            label8.Text = "Address";
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.Location = new Point(12, 192);
            txtBoxAddress.Multiline = true;
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(581, 165);
            txtBoxAddress.TabIndex = 15;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(259, 365);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(605, 400);
            Controls.Add(btnNext);
            Controls.Add(txtBoxAddress);
            Controls.Add(label8);
            Controls.Add(txtBoxContactNo);
            Controls.Add(txtBoxAge);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbProgram);
            Controls.Add(label5);
            Controls.Add(txtBoxMiddleName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(txtBoxLastName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBoxProgram);
            Controls.Add(txtBoxStudentNo);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxStudentNo;
        private Label txtBoxProgram;
        private Label label3;
        private Label label4;
        private TextBox txtBoxLastName;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxMiddleName;
        private Label label5;
        private ComboBox cbProgram;
        private Label label6;
        private Label label7;
        private TextBox txtBoxAge;
        private TextBox txtBoxContactNo;
        private Label label8;
        private TextBox txtBoxAddress;
        private Button btnNext;
    }
}
