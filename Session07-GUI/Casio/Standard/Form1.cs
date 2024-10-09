namespace Standard
{
    public partial class Form1 : Form
    {
        private double num1, num2, result;
        private string? calculation;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void AppendToResult(string value) => txbInput.Text += value;

        private void btnOne_Click(object sender, EventArgs e) => AppendToResult("1");
        private void btnTwo_Click(object sender, EventArgs e) => AppendToResult("2");
        private void btnThree_Click(object sender, EventArgs e) => AppendToResult("3");
        private void btnZero_Click(object sender, EventArgs e) => AppendToResult("0");
        private void btnFour_Click(object sender, EventArgs e) => AppendToResult("4");
        private void btnFive_Click(object sender, EventArgs e) => AppendToResult("5");
        private void btnSix_Click(object sender, EventArgs e) => AppendToResult("6");
        private void btnSeven_Click(object sender, EventArgs e) => AppendToResult("7");
        private void btnEight_Click(object sender, EventArgs e) => AppendToResult("8");
        private void btnNine_Click(object sender, EventArgs e) => AppendToResult("9");
        private void btnPoint_Click(object sender, EventArgs e) => AppendToResult(".");

        private void btnClear_Click(object sender, EventArgs e) => txbInput.Clear();
        private void btnAdd_Click(object sender, EventArgs e) => SetOperation("+");
        private void btnSubtract_Click(object sender, EventArgs e) => SetOperation("-");
        private void btnProduct_Click(object sender, EventArgs e) => SetOperation("*");
        private void btnDivide_Click(object sender, EventArgs e) => SetOperation("/");
        private void btnPow_Click(object sender, EventArgs e) => ProcessInput(x => Math.Pow(x, 2));
        private void btnOneDivideNumber_Click(object sender, EventArgs e) => ProcessInput(num => 1 / num);
        private void btnPercent_Click(object sender, EventArgs e) => ProcessInput(num => num / 100);
        private void btnDeleteOneCharacter_Click(object sender, EventArgs e)
        {
            if (txbInput.Text.Length > 0)
                txbInput.Text = txbInput.Text.Substring(0, txbInput.Text.Length - 1);
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbInput.Text, out num2))
            {
                switch (calculation)
                {
                    case "+":
                        result += num2;
                        break;
                    case "-":
                        result -= num2;
                        break;
                    case "*":
                        result *= num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result /= num2;
                        else
                            MessageBox.Show("Cannot divide by zero.");
                        break;
                }
                txbResult.Text = result.ToString();
                txbInput.Clear();
            }
            else if (string.IsNullOrWhiteSpace(txbInput.Text))
            {
                MessageBox.Show("Please enter a valid number.");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
            }
        }
        private void ProcessInput(Func<double, double> operation)
        {
            if (double.TryParse(txbInput.Text, out num1))
                result = operation(num1);
            else if (double.TryParse(txbResult.Text, out num1))
                result = operation(num1);
            else
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
                return;
            }

            txbResult.Text = result.ToString();
            txbInput.Clear();
        }
        private void SetOperation(string op)
        {
            if (double.TryParse(txbInput.Text, out num1))
            {
                calculation = op;
                result = num1;
                txbInput.Clear();
            }
            else if (double.TryParse(txbResult.Text, out num1))
            {
                calculation = op;
                result = num1;
                txbInput.Clear();
            }
        }

        
    }


}
