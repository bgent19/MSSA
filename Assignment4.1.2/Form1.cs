namespace Assignment4._1._2
{
    public partial class Form1 : Form
    {

        private readonly ICalculator _calculator;
        public Form1()
        {
            InitializeComponent();
            _calculator = new MathCalculator();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFirstNumber.Text, out double firstNumber) ||
                !double.TryParse(textBoxSecondNumber.Text, out double secondNumber))
            {
                MessageBox.Show("Please enter valid numbers in both fields.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxResult.Text = _calculator.Add(firstNumber, secondNumber).ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFirstNumber.Text, out double firstNumber) ||
                !double.TryParse(textBoxSecondNumber.Text, out double secondNumber))
            {
                MessageBox.Show("Please enter valid numbers in both fields.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxResult.Text = _calculator.Subtract(firstNumber, secondNumber).ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFirstNumber.Text, out double firstNumber) ||
                !double.TryParse(textBoxSecondNumber.Text, out double secondNumber))
            {
                MessageBox.Show("Please enter valid numbers in both fields.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxResult.Text = _calculator.Multiply(firstNumber, secondNumber).ToString();
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFirstNumber.Text, out double firstNumber) ||
                !double.TryParse(textBoxSecondNumber.Text, out double secondNumber))
            {
                MessageBox.Show("Please enter valid numbers in both fields.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                textBoxResult.Text = _calculator.Divide(firstNumber, secondNumber).ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
