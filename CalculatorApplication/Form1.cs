namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();

            cbOperator.Items.AddRange(new string[] { "+", "-", "*", "/" });
            cbOperator.SelectedIndex = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    break;
                case "-":
                    cal.CalculateEvent += cal.GetDifference;
                    break;
                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    break;
                case "/":
                    cal.CalculateEvent += cal.GetQuotient;
                    break;
            }

            var total = cal.Invoke(num1, num2);
            lblDisplayTotal.Text = total.ToString();

            cal.CalculateEvent -= cal.GetSum;
            cal.CalculateEvent -= cal.GetDifference;
            cal.CalculateEvent -= cal.GetProduct;
            cal.CalculateEvent -= cal.GetQuotient;
        }
    }
}
