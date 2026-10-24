namespace LabStream
{
    partial class FrmOpenTextFile
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
            lvShowText = new ListView();
            columnHeader1 = new ColumnHeader();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            BtnBack = new Button();
            BtnClear = new Button();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.BackColor = Color.White;
            lvShowText.BorderStyle = BorderStyle.FixedSingle;
            lvShowText.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lvShowText.ForeColor = Color.Black;
            lvShowText.FullRowSelect = true;
            lvShowText.HeaderStyle = ColumnHeaderStyle.None;
            lvShowText.Location = new Point(20, 18);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(504, 300);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 480;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Black;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.Transparent;
            btnOpen.Location = new Point(208, 324);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(121, 43);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Black;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.ForeColor = Color.Transparent;
            BtnBack.Location = new Point(71, 324);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(121, 43);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.Black;
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.Transparent;
            BtnClear.Location = new Point(345, 324);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(121, 43);
            BtnClear.TabIndex = 3;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(544, 372);
            Controls.Add(BtnClear);
            Controls.Add(BtnBack);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Font = new Font("Consolas", 10F);
            ForeColor = Color.FromArgb(236, 239, 244);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmOpenTextFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private ColumnHeader columnHeader1;
        private Button btnOpen;
        private OpenFileDialog openFileDialog1;
        private Button BtnBack;
        private Button BtnClear;
    }
}
