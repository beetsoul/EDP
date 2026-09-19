namespace CalculatorApplication
{
    partial class FrmCalculator
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
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(223, 49);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(125, 34);
            txtBoxInput1.TabIndex = 0;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(223, 161);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(125, 34);
            txtBoxInput2.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(223, 105);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(125, 31);
            cbOperator.TabIndex = 2;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(223, 222);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(165, 20);
            lblDisplayTotal.TabIndex = 3;
            lblDisplayTotal.Text = "__________________________";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(197, 264);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(172, 35);
            btnEqual.TabIndex = 4;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 55);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 5;
            label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 108);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 6;
            label2.Text = "Choose operator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 7;
            label3.Text = "Enter Second Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 215);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 8;
            label4.Text = "Answer:";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 348);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label lblDisplayTotal;
        private Button btnEqual;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
