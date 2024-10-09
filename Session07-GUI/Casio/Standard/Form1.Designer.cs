namespace Standard
{
    partial class Form1
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
            ComboBox cmbBitwise;
            tbcMode = new TabControl();
            tabPage1 = new TabPage();
            txbInputStandard = new TextBox();
            btnClearEntry = new Button();
            txbResult = new TextBox();
            btnTwo = new Button();
            btnDeleteOneCharacter = new Button();
            btnClear = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            btnPow = new Button();
            btnOneDivideNumber = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            btnProduct = new Button();
            btnPoint = new Button();
            btnZero = new Button();
            btnChangeOpposite = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnThree = new Button();
            btnOne = new Button();
            txbInput = new TextBox();
            tabPage2 = new TabPage();
            txbResultPro = new TextBox();
            lblBin = new Label();
            lblOct = new Label();
            txbOctResult = new TextBox();
            txbBinResult = new TextBox();
            lblDec = new Label();
            lblHex = new Label();
            txbHexResult = new TextBox();
            txbDecResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnDelete = new Button();
            btnLeft = new Button();
            btnF = new Button();
            btnA = new Button();
            btnB = new Button();
            btnD = new Button();
            btnC = new Button();
            btnE = new Button();
            btnPer = new Button();
            button3 = new Button();
            btnRight = new Button();
            btnNgoacPhai = new Button();
            txbInputPro = new TextBox();
            button4 = new Button();
            btnNgoacTrai = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnResult = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            btnChangeOposite = new Button();
            txbResultStandard = new TextBox();
            cmbBitwise = new ComboBox();
            tbcMode.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbBitwise
            // 
            cmbBitwise.BackColor = Color.FromArgb(255, 255, 128);
            cmbBitwise.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBitwise.ForeColor = SystemColors.MenuText;
            cmbBitwise.FormattingEnabled = true;
            cmbBitwise.Items.AddRange(new object[] { "AND", "OR", "NOT", "XOR" });
            cmbBitwise.Location = new Point(28, 252);
            cmbBitwise.Name = "cmbBitwise";
            cmbBitwise.Size = new Size(118, 43);
            cmbBitwise.TabIndex = 120;
            cmbBitwise.Text = "Bitwise";
            // 
            // tbcMode
            // 
            tbcMode.Controls.Add(tabPage1);
            tbcMode.Controls.Add(tabPage2);
            tbcMode.Location = new Point(31, 40);
            tbcMode.Name = "tbcMode";
            tbcMode.SelectedIndex = 0;
            tbcMode.Size = new Size(680, 827);
            tbcMode.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(txbResultStandard);
            tabPage1.Controls.Add(txbInputStandard);
            tabPage1.Controls.Add(btnClearEntry);
            tabPage1.Controls.Add(txbResult);
            tabPage1.Controls.Add(btnTwo);
            tabPage1.Controls.Add(btnDeleteOneCharacter);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(btnPercent);
            tabPage1.Controls.Add(btnDivide);
            tabPage1.Controls.Add(btnSqrt);
            tabPage1.Controls.Add(btnPow);
            tabPage1.Controls.Add(btnOneDivideNumber);
            tabPage1.Controls.Add(btnSubtract);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(btnEqual);
            tabPage1.Controls.Add(btnProduct);
            tabPage1.Controls.Add(btnPoint);
            tabPage1.Controls.Add(btnZero);
            tabPage1.Controls.Add(btnChangeOpposite);
            tabPage1.Controls.Add(btnSix);
            tabPage1.Controls.Add(btnFive);
            tabPage1.Controls.Add(btnFour);
            tabPage1.Controls.Add(btnNine);
            tabPage1.Controls.Add(btnEight);
            tabPage1.Controls.Add(btnSeven);
            tabPage1.Controls.Add(btnThree);
            tabPage1.Controls.Add(btnOne);
            tabPage1.Controls.Add(txbInput);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(672, 794);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Standard";
            // 
            // txbInputStandard
            // 
            txbInputStandard.BackColor = Color.LightGray;
            txbInputStandard.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbInputStandard.Location = new Point(27, 73);
            txbInputStandard.Multiline = true;
            txbInputStandard.Name = "txbInputStandard";
            txbInputStandard.Size = new Size(533, 75);
            txbInputStandard.TabIndex = 114;
            txbInputStandard.Text = "0";
            txbInputStandard.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.Yellow;
            btnClearEntry.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnClearEntry.Location = new Point(148, 268);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(144, 73);
            btnClearEntry.TabIndex = 113;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            // 
            // txbResult
            // 
            txbResult.BackColor = Color.LightGray;
            txbResult.BorderStyle = BorderStyle.None;
            txbResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbResult.Location = new Point(27, 57);
            txbResult.Multiline = true;
            txbResult.Name = "txbResult";
            txbResult.Size = new Size(517, 68);
            txbResult.TabIndex = 112;
            txbResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.White;
            btnTwo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnTwo.Location = new Point(148, 511);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(144, 73);
            btnTwo.TabIndex = 111;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOneCharacter
            // 
            btnDeleteOneCharacter.BackColor = Color.Yellow;
            btnDeleteOneCharacter.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDeleteOneCharacter.Location = new Point(427, 268);
            btnDeleteOneCharacter.Name = "btnDeleteOneCharacter";
            btnDeleteOneCharacter.Size = new Size(133, 73);
            btnDeleteOneCharacter.TabIndex = 110;
            btnDeleteOneCharacter.Text = "x";
            btnDeleteOneCharacter.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnClear.Location = new Point(287, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 73);
            btnClear.TabIndex = 109;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.Yellow;
            btnPercent.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPercent.Location = new Point(27, 268);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(125, 73);
            btnPercent.TabIndex = 108;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Yellow;
            btnDivide.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDivide.Location = new Point(427, 347);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(133, 76);
            btnDivide.TabIndex = 107;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Yellow;
            btnSqrt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSqrt.Location = new Point(287, 347);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(144, 76);
            btnSqrt.TabIndex = 106;
            btnSqrt.Text = "√ ";
            btnSqrt.UseVisualStyleBackColor = false;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Yellow;
            btnPow.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPow.Location = new Point(148, 669);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(144, 73);
            btnPow.TabIndex = 105;
            btnPow.Text = "x^2";
            btnPow.UseVisualStyleBackColor = false;
            // 
            // btnOneDivideNumber
            // 
            btnOneDivideNumber.BackColor = Color.Yellow;
            btnOneDivideNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnOneDivideNumber.Location = new Point(27, 346);
            btnOneDivideNumber.Name = "btnOneDivideNumber";
            btnOneDivideNumber.Size = new Size(125, 77);
            btnOneDivideNumber.TabIndex = 104;
            btnOneDivideNumber.Text = "1/x";
            btnOneDivideNumber.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Yellow;
            btnSubtract.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSubtract.Location = new Point(427, 510);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(133, 74);
            btnSubtract.TabIndex = 103;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Yellow;
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdd.Location = new Point(427, 590);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 77);
            btnAdd.TabIndex = 102;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Yellow;
            btnEqual.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnEqual.Location = new Point(427, 669);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(133, 73);
            btnEqual.TabIndex = 101;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Yellow;
            btnProduct.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnProduct.Location = new Point(427, 429);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(133, 75);
            btnProduct.TabIndex = 100;
            btnProduct.Text = "*";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.Yellow;
            btnPoint.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPoint.Location = new Point(287, 670);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(144, 72);
            btnPoint.TabIndex = 99;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.White;
            btnZero.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnZero.Location = new Point(148, 591);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(144, 76);
            btnZero.TabIndex = 98;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            // 
            // btnChangeOpposite
            // 
            btnChangeOpposite.BackColor = Color.Yellow;
            btnChangeOpposite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnChangeOpposite.Location = new Point(27, 669);
            btnChangeOpposite.Name = "btnChangeOpposite";
            btnChangeOpposite.Size = new Size(125, 73);
            btnChangeOpposite.TabIndex = 97;
            btnChangeOpposite.Text = "+/-";
            btnChangeOpposite.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.White;
            btnSix.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSix.Location = new Point(287, 511);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(144, 73);
            btnSix.TabIndex = 96;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.White;
            btnFive.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFive.Location = new Point(148, 429);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(144, 75);
            btnFive.TabIndex = 95;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.White;
            btnFour.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFour.Location = new Point(27, 510);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(125, 74);
            btnFour.TabIndex = 94;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.White;
            btnNine.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNine.Location = new Point(287, 429);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(144, 75);
            btnNine.TabIndex = 93;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.White;
            btnEight.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnEight.Location = new Point(148, 347);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(144, 76);
            btnEight.TabIndex = 92;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.White;
            btnSeven.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSeven.Location = new Point(27, 429);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(125, 75);
            btnSeven.TabIndex = 91;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.White;
            btnThree.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnThree.Location = new Point(287, 591);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(144, 76);
            btnThree.TabIndex = 90;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.White;
            btnOne.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnOne.Location = new Point(27, 591);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(125, 75);
            btnOne.TabIndex = 89;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            // 
            // txbInput
            // 
            txbInput.BackColor = Color.White;
            txbInput.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbInput.Location = new Point(312, -78);
            txbInput.Multiline = true;
            txbInput.Name = "txbInput";
            txbInput.Size = new Size(490, 80);
            txbInput.TabIndex = 60;
            txbInput.Text = "0";
            txbInput.TextAlign = HorizontalAlignment.Right;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(txbResultPro);
            tabPage2.Controls.Add(lblBin);
            tabPage2.Controls.Add(lblOct);
            tabPage2.Controls.Add(txbOctResult);
            tabPage2.Controls.Add(txbBinResult);
            tabPage2.Controls.Add(lblDec);
            tabPage2.Controls.Add(lblHex);
            tabPage2.Controls.Add(txbHexResult);
            tabPage2.Controls.Add(txbDecResult);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnLeft);
            tabPage2.Controls.Add(btnF);
            tabPage2.Controls.Add(btnA);
            tabPage2.Controls.Add(btnB);
            tabPage2.Controls.Add(btnD);
            tabPage2.Controls.Add(btnC);
            tabPage2.Controls.Add(btnE);
            tabPage2.Controls.Add(btnPer);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(cmbBitwise);
            tabPage2.Controls.Add(btnRight);
            tabPage2.Controls.Add(btnNgoacPhai);
            tabPage2.Controls.Add(txbInputPro);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(btnNgoacTrai);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(btnResult);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(button12);
            tabPage2.Controls.Add(button13);
            tabPage2.Controls.Add(button14);
            tabPage2.Controls.Add(button15);
            tabPage2.Controls.Add(button16);
            tabPage2.Controls.Add(btnChangeOposite);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(672, 794);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Programmer";
            // 
            // txbResultPro
            // 
            txbResultPro.BackColor = Color.LightGray;
            txbResultPro.BorderStyle = BorderStyle.None;
            txbResultPro.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbResultPro.Location = new Point(38, 58);
            txbResultPro.Name = "txbResultPro";
            txbResultPro.Size = new Size(581, 44);
            txbResultPro.TabIndex = 141;
            txbResultPro.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBin
            // 
            lblBin.AutoSize = true;
            lblBin.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBin.Location = new Point(38, 196);
            lblBin.Name = "lblBin";
            lblBin.Size = new Size(50, 26);
            lblBin.TabIndex = 140;
            lblBin.Text = "BIN";
            // 
            // lblOct
            // 
            lblOct.AutoSize = true;
            lblOct.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOct.Location = new Point(38, 166);
            lblOct.Name = "lblOct";
            lblOct.Size = new Size(58, 26);
            lblOct.TabIndex = 139;
            lblOct.Text = "OCT";
            // 
            // txbOctResult
            // 
            txbOctResult.BackColor = Color.LightGray;
            txbOctResult.BorderStyle = BorderStyle.None;
            txbOctResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbOctResult.Location = new Point(100, 158);
            txbOctResult.Name = "txbOctResult";
            txbOctResult.Size = new Size(366, 34);
            txbOctResult.TabIndex = 138;
            txbOctResult.Text = "0";
            // 
            // txbBinResult
            // 
            txbBinResult.BackColor = Color.LightGray;
            txbBinResult.BorderStyle = BorderStyle.None;
            txbBinResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbBinResult.Location = new Point(100, 188);
            txbBinResult.Name = "txbBinResult";
            txbBinResult.Size = new Size(366, 34);
            txbBinResult.TabIndex = 137;
            txbBinResult.Text = "0";
            // 
            // lblDec
            // 
            lblDec.AutoSize = true;
            lblDec.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDec.Location = new Point(38, 135);
            lblDec.Name = "lblDec";
            lblDec.Size = new Size(56, 26);
            lblDec.TabIndex = 136;
            lblDec.Text = "DEC";
            // 
            // lblHex
            // 
            lblHex.AutoSize = true;
            lblHex.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHex.Location = new Point(38, 105);
            lblHex.Name = "lblHex";
            lblHex.Size = new Size(56, 26);
            lblHex.TabIndex = 135;
            lblHex.Text = "HEX";
            // 
            // txbHexResult
            // 
            txbHexResult.BackColor = Color.LightGray;
            txbHexResult.BorderStyle = BorderStyle.None;
            txbHexResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbHexResult.Location = new Point(100, 97);
            txbHexResult.Name = "txbHexResult";
            txbHexResult.Size = new Size(366, 34);
            txbHexResult.TabIndex = 134;
            txbHexResult.Text = "0";
            // 
            // txbDecResult
            // 
            txbDecResult.BackColor = Color.LightGray;
            txbDecResult.BorderStyle = BorderStyle.None;
            txbDecResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbDecResult.Location = new Point(100, 127);
            txbDecResult.Name = "txbDecResult";
            txbDecResult.Size = new Size(366, 34);
            txbDecResult.TabIndex = 133;
            txbDecResult.Text = "0";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(276, 589);
            button1.Name = "button1";
            button1.Size = new Size(118, 66);
            button1.TabIndex = 132;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(400, 301);
            button2.Name = "button2";
            button2.Size = new Size(118, 66);
            button2.TabIndex = 131;
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDelete.Location = new Point(524, 301);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 66);
            btnDelete.TabIndex = 130;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.Yellow;
            btnLeft.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLeft.Location = new Point(152, 301);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(118, 66);
            btnLeft.TabIndex = 129;
            btnLeft.Text = "<<";
            btnLeft.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            btnF.BackColor = Color.Yellow;
            btnF.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnF.Location = new Point(28, 661);
            btnF.Name = "btnF";
            btnF.Size = new Size(118, 66);
            btnF.TabIndex = 128;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            btnA.BackColor = Color.Yellow;
            btnA.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnA.Location = new Point(28, 301);
            btnA.Name = "btnA";
            btnA.Size = new Size(118, 66);
            btnA.TabIndex = 127;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Yellow;
            btnB.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnB.Location = new Point(28, 373);
            btnB.Name = "btnB";
            btnB.Size = new Size(118, 66);
            btnB.TabIndex = 126;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Yellow;
            btnD.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnD.Location = new Point(28, 517);
            btnD.Name = "btnD";
            btnD.Size = new Size(118, 66);
            btnD.TabIndex = 125;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Yellow;
            btnC.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnC.Location = new Point(28, 445);
            btnC.Name = "btnC";
            btnC.Size = new Size(118, 66);
            btnC.TabIndex = 124;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            btnE.BackColor = Color.Yellow;
            btnE.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnE.Location = new Point(28, 589);
            btnE.Name = "btnE";
            btnE.Size = new Size(118, 66);
            btnE.TabIndex = 123;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            // 
            // btnPer
            // 
            btnPer.BackColor = Color.Yellow;
            btnPer.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPer.Location = new Point(400, 373);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(118, 66);
            btnPer.TabIndex = 122;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.Location = new Point(276, 661);
            button3.Name = "button3";
            button3.Size = new Size(118, 66);
            button3.TabIndex = 121;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.Yellow;
            btnRight.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRight.Location = new Point(276, 301);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(118, 66);
            btnRight.TabIndex = 119;
            btnRight.Text = ">>";
            btnRight.UseVisualStyleBackColor = false;
            // 
            // btnNgoacPhai
            // 
            btnNgoacPhai.BackColor = Color.Yellow;
            btnNgoacPhai.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNgoacPhai.Location = new Point(276, 373);
            btnNgoacPhai.Name = "btnNgoacPhai";
            btnNgoacPhai.Size = new Size(118, 66);
            btnNgoacPhai.TabIndex = 118;
            btnNgoacPhai.Text = ")";
            btnNgoacPhai.UseVisualStyleBackColor = false;
            // 
            // txbInputPro
            // 
            txbInputPro.BackColor = Color.LightGray;
            txbInputPro.BorderStyle = BorderStyle.None;
            txbInputPro.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbInputPro.Location = new Point(38, 8);
            txbInputPro.Name = "txbInputPro";
            txbInputPro.Size = new Size(581, 44);
            txbInputPro.TabIndex = 117;
            txbInputPro.Text = "\r\n0\r\n";
            txbInputPro.TextAlign = HorizontalAlignment.Right;
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(524, 373);
            button4.Name = "button4";
            button4.Size = new Size(118, 66);
            button4.TabIndex = 116;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnNgoacTrai
            // 
            btnNgoacTrai.BackColor = Color.Yellow;
            btnNgoacTrai.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNgoacTrai.Location = new Point(152, 373);
            btnNgoacTrai.Name = "btnNgoacTrai";
            btnNgoacTrai.Size = new Size(118, 66);
            btnNgoacTrai.TabIndex = 115;
            btnNgoacTrai.Text = "(";
            btnNgoacTrai.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button5.Location = new Point(524, 445);
            button5.Name = "button5";
            button5.Size = new Size(118, 66);
            button5.TabIndex = 114;
            button5.Text = "*";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.Location = new Point(400, 445);
            button6.Name = "button6";
            button6.Size = new Size(118, 66);
            button6.TabIndex = 113;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button7.Location = new Point(276, 445);
            button7.Name = "button7";
            button7.Size = new Size(118, 66);
            button7.TabIndex = 112;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button8.Location = new Point(152, 445);
            button8.Name = "button8";
            button8.Size = new Size(118, 66);
            button8.TabIndex = 111;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Yellow;
            button9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button9.Location = new Point(524, 589);
            button9.Name = "button9";
            button9.Size = new Size(118, 66);
            button9.TabIndex = 110;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = false;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Yellow;
            btnResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnResult.Location = new Point(524, 661);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(118, 66);
            btnResult.TabIndex = 109;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Yellow;
            button10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button10.Location = new Point(524, 517);
            button10.Name = "button10";
            button10.Size = new Size(118, 66);
            button10.TabIndex = 108;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button11.Location = new Point(400, 589);
            button11.Name = "button11";
            button11.Size = new Size(118, 66);
            button11.TabIndex = 107;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button12.Location = new Point(152, 589);
            button12.Name = "button12";
            button12.Size = new Size(118, 66);
            button12.TabIndex = 106;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.White;
            button13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button13.Location = new Point(400, 517);
            button13.Name = "button13";
            button13.Size = new Size(118, 66);
            button13.TabIndex = 105;
            button13.Text = "6";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.White;
            button14.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button14.Location = new Point(276, 517);
            button14.Name = "button14";
            button14.Size = new Size(118, 66);
            button14.TabIndex = 104;
            button14.Text = "5";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.White;
            button15.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button15.Location = new Point(152, 517);
            button15.Name = "button15";
            button15.Size = new Size(118, 66);
            button15.TabIndex = 103;
            button15.Text = "4";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = Color.White;
            button16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button16.Location = new Point(400, 661);
            button16.Name = "button16";
            button16.Size = new Size(118, 66);
            button16.TabIndex = 102;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = false;
            // 
            // btnChangeOposite
            // 
            btnChangeOposite.BackColor = Color.White;
            btnChangeOposite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnChangeOposite.Location = new Point(152, 661);
            btnChangeOposite.Name = "btnChangeOposite";
            btnChangeOposite.Size = new Size(118, 66);
            btnChangeOposite.TabIndex = 101;
            btnChangeOposite.Text = "+/-";
            btnChangeOposite.UseVisualStyleBackColor = false;
            // 
            // txbResultStandard
            // 
            txbResultStandard.BackColor = Color.LightGray;
            txbResultStandard.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbResultStandard.Location = new Point(27, 141);
            txbResultStandard.Multiline = true;
            txbResultStandard.Name = "txbResultStandard";
            txbResultStandard.Size = new Size(533, 85);
            txbResultStandard.TabIndex = 115;
            txbResultStandard.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 841);
            Controls.Add(tbcMode);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tbcMode.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcMode;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txbInput;
        private TextBox txbInputStandard;
        private Button btnClearEntry;
        private TextBox txbResult;
        private Button btnTwo;
        private Button btnDeleteOneCharacter;
        private Button btnClear;
        private Button btnPercent;
        private Button btnDivide;
        private Button btnSqrt;
        private Button btnPow;
        private Button btnOneDivideNumber;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnEqual;
        private Button btnProduct;
        private Button btnPoint;
        private Button btnZero;
        private Button btnChangeOpposite;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnThree;
        private Button btnOne;
        private TextBox txbResultPro;
        private Label lblBin;
        private Label lblOct;
        private TextBox txbOctResult;
        private TextBox txbBinResult;
        private Label lblDec;
        private Label lblHex;
        private TextBox txbHexResult;
        private TextBox txbDecResult;
        private Button button1;
        private Button button2;
        private Button btnDelete;
        private Button btnLeft;
        private Button btnF;
        private Button btnA;
        private Button btnB;
        private Button btnD;
        private Button btnC;
        private Button btnE;
        private Button btnPer;
        private Button button3;
        private ComboBox cmbBitwise;
        private Button btnRight;
        private Button btnNgoacPhai;
        private TextBox txbInputPro;
        private Button button4;
        private Button btnNgoacTrai;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnResult;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button btnChangeOposite;
        private TextBox txbResultStandard;
    }
}
