namespace Assignment4._1._2
{
    public partial class Calculator : Form
    {

        private readonly ICalculator _calculator;
        public Calculator()
        {
            InitializeComponent();
            _calculator = new MathCalculator();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(ValidateNumbers(out double firstNumber, out double secondNumber))
            {
                textBoxResult.Text = _calculator.Add(firstNumber, secondNumber).ToString();
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (ValidateNumbers(out double firstNumber, out double secondNumber))
            {
                textBoxResult.Text = _calculator.Subtract(firstNumber, secondNumber).ToString();
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (ValidateNumbers(out double firstNumber, out double secondNumber))
            {
                textBoxResult.Text = _calculator.Multiply(firstNumber, secondNumber).ToString();
            }
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (ValidateNumbers(out double firstNumber, out double secondNumber))
            {
                try
                {
                    textBoxResult.Text = _calculator.Divide(firstNumber, secondNumber).ToString();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxResult.Text = string.Empty;
                }
            }
        }   

        private bool ValidateNumbers(out double first, out double second)
        {
            if (!double.TryParse(textBoxFirstNumber.Text, out double firstNumber) ||
                !double.TryParse(textBoxSecondNumber.Text, out double secondNumber))
            {
                MessageBox.Show("Please enter valid numbers in both fields.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                first = second = 0;
                textBoxResult.Text = string.Empty;
                return false;
            }


            first = firstNumber;
            second = secondNumber;
            return true;
        }
    }
}
