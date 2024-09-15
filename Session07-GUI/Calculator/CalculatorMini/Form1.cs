namespace CalculatorMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = $"{Convert.ToDouble(txbInputFirstNumber.Text) + Convert.ToDouble(txbInputSecondNumber.Text)}";

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = $"{Convert.ToDouble(txbInputFirstNumber.Text) - Convert.ToDouble(txbInputSecondNumber.Text)}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = $"{Convert.ToDouble(txbInputFirstNumber.Text) * Convert.ToDouble(txbInputSecondNumber.Text)}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = $"{Convert.ToDouble(txbInputFirstNumber.Text) / Convert.ToDouble(txbInputSecondNumber.Text)}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txbInputFirstNumber.Clear();
            txbInputSecondNumber.Clear();
            txtResult.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
