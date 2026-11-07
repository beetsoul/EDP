namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            num1 = new TextBox();
            num2 = new TextBox();
            cbOperator = new ComboBox();
            BtnCompute = new Button();
            label2 = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // num1
            // 
            num1.Font = new Font("Segoe UI", 15F);
            num1.Location = new Point(27, 84);
            num1.Multiline = true;
            num1.Name = "num1";
            num1.Size = new Size(289, 43);
            num1.TabIndex = 1;
            // 
            // num2
            // 
            num2.Font = new Font("Segoe UI", 15F);
            num2.Location = new Point(30, 200);
            num2.Multiline = true;
            num2.Name = "num2";
            num2.Size = new Size(289, 43);
            num2.TabIndex = 2;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Segoe UI", 18F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "*", "/", "-" });
            cbOperator.Location = new Point(141, 144);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(58, 40);
            cbOperator.TabIndex = 3;
            // 
            // BtnCompute
            // 
            BtnCompute.BackColor = Color.FromArgb(64, 64, 64);
            BtnCompute.BackgroundImageLayout = ImageLayout.None;
            BtnCompute.FlatStyle = FlatStyle.Flat;
            BtnCompute.Font = new Font("Segoe UI", 15F);
            BtnCompute.ForeColor = Color.White;
            BtnCompute.Location = new Point(101, 364);
            BtnCompute.Name = "BtnCompute";
            BtnCompute.Size = new Size(138, 51);
            BtnCompute.TabIndex = 4;
            BtnCompute.Text = "Compute";
            BtnCompute.UseVisualStyleBackColor = false;
            BtnCompute.Click += BtnCompute_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(36, 257);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 5;
            label2.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 22F);
            lblTotal.Location = new Point(47, 301);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(98, 41);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "00000";
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(349, 442);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(BtnCompute);
            Controls.Add(cbOperator);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label1);
            Name = "FrmBasicCalculator";
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1;
        private TextBox num2;
        private ComboBox cbOperator;
        private Button BtnCompute;
        private Label label2;
        private Label lblTotal;
    }
}
