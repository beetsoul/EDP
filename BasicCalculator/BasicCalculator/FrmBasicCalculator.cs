using System;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            cbOperator.Text = "+";
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text))
            {
                MessageBox.Show("Cannot be empty. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BasicComputation bc = new BasicComputation();

                float x = float.Parse(num1.Text);
                float y = float.Parse(num2.Text);

                {

                }

                switch (cbOperator.Text)
                {
                    case "+":
                        lblTotal.Text = bc.printAddition(x, y).ToString();
                        break;
                    case "-":
                        lblTotal.Text = bc.printSubtraction(x, y).ToString();
                        break;

                    case "*":
                        lblTotal.Text = bc.printMultiplication(x, y).ToString();
                        break;

                    case "/":
                        try
                        {
                            lblTotal.Text = bc.printDivision(x, y).ToString();
                        }
                        catch (DivideByZeroException d)
                        {
                            MessageBox.Show("Cannot divide by zero. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lblTotal.Text = "Error.";
                        }

                        break;
                    default:

                        return;
                }
            }
        }
    }
}
