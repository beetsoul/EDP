namespace LabStream
{
    partial class FrmLabStream
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
            txtInput = new TextBox();
            btnCreate = new Button();
            btnRegisteration = new Button();
            BtnOpenTextFile = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.White;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("Segoe UI", 11F);
            txtInput.ForeColor = Color.FromArgb(31, 58, 95);
            txtInput.Location = new Point(27, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(250, 70);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Black;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(167, 88);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 45);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRegisteration
            // 
            btnRegisteration.BackColor = Color.Black;
            btnRegisteration.Cursor = Cursors.Hand;
            btnRegisteration.FlatAppearance.BorderSize = 0;
            btnRegisteration.FlatStyle = FlatStyle.Flat;
            btnRegisteration.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisteration.ForeColor = Color.White;
            btnRegisteration.Location = new Point(9, 88);
            btnRegisteration.Name = "btnRegisteration";
            btnRegisteration.Size = new Size(130, 45);
            btnRegisteration.TabIndex = 2;
            btnRegisteration.Text = "Registration";
            btnRegisteration.UseVisualStyleBackColor = false;
            btnRegisteration.Click += btnRegisteration_Click;
            // 
            // BtnOpenTextFile
            // 
            BtnOpenTextFile.BackColor = Color.Black;
            BtnOpenTextFile.Cursor = Cursors.Hand;
            BtnOpenTextFile.FlatAppearance.BorderSize = 0;
            BtnOpenTextFile.FlatStyle = FlatStyle.Flat;
            BtnOpenTextFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOpenTextFile.ForeColor = Color.White;
            BtnOpenTextFile.Location = new Point(85, 139);
            BtnOpenTextFile.Name = "BtnOpenTextFile";
            BtnOpenTextFile.Size = new Size(130, 45);
            BtnOpenTextFile.TabIndex = 3;
            BtnOpenTextFile.Text = "Open Text File";
            BtnOpenTextFile.UseVisualStyleBackColor = false;
            BtnOpenTextFile.Click += BtnOpenTextFile_Click;
            // 
            // FrmLabStream
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(307, 190);
            Controls.Add(BtnOpenTextFile);
            Controls.Add(btnRegisteration);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLabStream";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCreate;
        private Button btnRegisteration;
        private Button BtnOpenTextFile;
    }
}
