namespace BasicThreading
{
    partial class FrmBasicThread
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
            lblStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 18F);
            lblStatus.Location = new Point(-2, 58);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(388, 32);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "-Before Starting Thread-";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // btnRun
            // 
            btnRun.BackColor = SystemColors.ActiveBorder;
            btnRun.Cursor = Cursors.Hand;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Segoe UI", 10F);
            btnRun.Location = new Point(144, 125);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(100, 35);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 261);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBasicThread";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BasicThread";
            ResumeLayout(false);
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
    }
}
