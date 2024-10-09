using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Programmer : UserControl
    {
        private CalculatorCasio calculatorCasio;
        private string currentMode = "Dec";
        private Stack<string> calculationStack = new Stack<string>();


        public Programmer(CalculatorCasio calculatorCasio)
        {
            InitializeComponent();
            this.calculatorCasio = calculatorCasio;
            cmbBitwise.DropDownStyle = ComboBoxStyle.DropDownList;

            txbInput.TextChanged += txbInput_TextChanged;

            btnOne.Click += NumberButton_Click;
            btnTwo.Click += NumberButton_Click;
            btnThree.Click += NumberButton_Click;
            btnFour.Click += NumberButton_Click;
            btnFive.Click += NumberButton_Click;
            btnSix.Click += NumberButton_Click;
            btnSeven.Click += NumberButton_Click;
            btnEight.Click += NumberButton_Click;
            btnNine.Click += NumberButton_Click;

        }

        private void Programmer_Load(object sender, EventArgs e)
        {

        }


        private void cmbBitwise_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seletedMode = cmbBitwise.SelectedItem.ToString();
            currentMode = seletedMode;
            switch (currentMode)
            {
                case "Bin":
                    btnTwo.Enabled = false;
                    btnThree.Enabled = false;
                    btnFour.Enabled = false;
                    btnFive.Enabled = false;
                    btnSix.Enabled = false;
                    btnSeven.Enabled = false;
                    btnEight.Enabled = false;
                    btnNine.Enabled = false;
                    break;
            }

        }

        private void classicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            calculatorCasio.Visible = false;

            MessageBox.Show("Switched to Classic mode");
        }

        private void mnsOption_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're in Classtion mode");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AppendToInput(string value)
        {
            txbInput.Text += value;
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            AppendToInput(btn.Text);
        }


        private void ShowCalculationHistory()
        {
            MessageBox.Show(string.Join("\n", calculationStack));
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbInput.Text.Length > 0)
                txbInput.Text = txbInput.Text.Substring(0, txbInput.Text.Length - 1);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txbInput.Text, out int number))
            {
                string binaryResult = ConvertBase(number, 2);
                string hexResult = ConvertBase(number, 16);
                string octResult = ConvertBase(number, 8);
                string decResult = ConvertBase(number, 10);
                txbBinResult.Text = binaryResult;
                txbHexResult.Text = hexResult;
                txbOctResult.Text = octResult;
                txbDecResult.Text = decResult;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid decimal number.");
            }
        }
        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txbInput.Text, out int number))
            {
                string binaryResult = ConvertBase(number, 2);
                string hexResult = ConvertBase(number, 16);
                string octResult = ConvertBase(number, 8);
                string decResult = ConvertBase(number, 10);

                txbBinResult.Text = binaryResult;
                txbHexResult.Text = hexResult;
                txbOctResult.Text = octResult;
                txbDecResult.Text = decResult;
            }
            else
            {
                // Nếu đầu vào không hợp lệ, bạn có thể làm sạch các ô kết quả
                txbBinResult.Clear();
                txbHexResult.Clear();
                txbOctResult.Clear();
                txbDecResult.Clear();
            }
        }

        private void btnChangeOposite_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbInput.Text, out double num))
            {
                txbInput.Text = (-num).ToString();
            }
            else if (double.TryParse(txbResult.Text, out num))
            {
                txbResult.Text = (-num).ToString();
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txbInput.Clear();
            txbResult.Clear();
        }

        private string ConvertBase(int n, int baseValue)
        {
            Stack<int> st = new Stack<int>();
            int tmp = n;
            string result = "";

            while (tmp != 0)
            {
                st.Push(tmp % baseValue);
                tmp /= baseValue;
            }
            while (st.Count > 0)
            {
                int x = st.Pop();
                if (x < 10)
                    result += x.ToString();
                else
                {
                    switch (x)
                    {
                        case 10: result += "A"; break;
                        case 11: result += "B"; break;
                        case 12: result += "C"; break;
                        case 13: result += "D"; break;
                        case 14: result += "E"; break;
                        case 15: result += "F"; break;
                    }
                }
            }
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnPer_Click(object sender, EventArgs e)
        {

        }

        private void btnNgoacPhai_Click(object sender, EventArgs e)
        {

        }

        private void btnNgoacTrai_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {

        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }

        private void btnF_Click(object sender, EventArgs e)
        {

        }

        private void lblHex_Click(object sender, EventArgs e)
        {

        }

        private void lblDec_Click(object sender, EventArgs e)
        {

        }

        private void lblOct_Click(object sender, EventArgs e)
        {

        }

        private void lblBin_Click(object sender, EventArgs e)
        {

        }
    }
}
