namespace Calculator
{
    public partial class CalculatorCasio : Form
    {
        public CalculatorCasio() => InitializeComponent();

        private double num1, num2, result;
        private string calculation;

        private void Form1_Load(object sender, EventArgs e) {
            this.MaximizeBox = false;
        }

        private void AppendToResult(string value) => txtResult.Text += value;

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

        private void btnClear_Click(object sender, EventArgs e) => txtResult.Clear();

        private void btnChangeOpposite_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double num))
            {
                txtResult.Text = (-num).ToString();
            }
            else if (double.TryParse(txtResultFinal.Text, out num))
            {
                txtResultFinal.Text = (-num).ToString();
            }
        }

        private void SetOperation(string op)
        {
            if (double.TryParse(txtResult.Text, out num1))
            {
                calculation = op;
                result = num1;
                txtResult.Clear();
            }
            else if (double.TryParse(txtResultFinal.Text, out num1))
            {
                calculation = op;
                result = num1;
                txtResult.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) => SetOperation("+");
        private void btnSubtract_Click(object sender, EventArgs e) => SetOperation("-");
        private void btnProduct_Click(object sender, EventArgs e) => SetOperation("*");
        private void btnDivide_Click(object sender, EventArgs e) => SetOperation("/");

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out num2))
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
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
            else if (string.IsNullOrWhiteSpace(txtResult.Text))
            {
                MessageBox.Show("Please enter a valid number.");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a numeric value.");
            }
        }


        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out num1))
            {
                result = Math.Sqrt(num1);
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
            else if (double.TryParse(txtResultFinal.Text, out num1))
            {
                result = Math.Sqrt(num1);
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out num1))
            {
                result = Math.Pow(num1, 2);
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
            else if (double.TryParse(txtResultFinal.Text, out num1))
            {
                result = Math.Pow(num1, 2);
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
        }

        private void btnOneDivideNumber_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out num1) && num1 != 0)
            {
                result = 1 / num1;
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
            else if (double.TryParse(txtResultFinal.Text, out num1))
            {
                result = num1 / num1;
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out num1))
            {
                result = num1 / 100;
                txtResultFinal.Text = result.ToString();
                txtResult.Clear();
            }
            else if(double.TryParse(txtResultFinal.Text, out num1))
            {
                result = num1 / 100;
                txtResultFinal.Text = result.ToString(); 
                txtResult.Clear();
            }
        }

        private void btnDeleteOneCharacter_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResultFinal.Clear();
        }
    }
}