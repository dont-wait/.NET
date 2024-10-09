using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Calculator
{
    partial class Programmer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnNgoacPhai = new Button();
            txbInput = new TextBox();
            btnDivide = new Button();
            btnNgoacTrai = new Button();
            btnProduct = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnAdd = new Button();
            btnResult = new Button();
            btnSubtract = new Button();
            btnThree = new Button();
            btnOne = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnPoint = new Button();
            btnChangeOposite = new Button();
            menuStrip1 = new MenuStrip();
            mnsOption = new ToolStripMenuItem();
            classicToolStripMenuItem = new ToolStripMenuItem();
            btnRight = new Button();
            menuStrip2 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            cmbBitwise = new ComboBox();
            btnZero = new Button();
            btnPer = new Button();
            btnA = new Button();
            btnB = new Button();
            btnD = new Button();
            btnC = new Button();
            btnE = new Button();
            btnF = new Button();
            btnLeft = new Button();
            btnClearEntry = new Button();
            btnDelete = new Button();
            btnTwo = new Button();
            txbDecResult = new TextBox();
            txbHexResult = new TextBox();
            lblHex = new Label();
            lblDec = new Label();
            lblBin = new Label();
            lblOct = new Label();
            txbOctResult = new TextBox();
            txbBinResult = new TextBox();
            txbResult = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNgoacPhai
            // 
            btnNgoacPhai.BackColor = Color.Yellow;
            btnNgoacPhai.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNgoacPhai.Location = new Point(264, 429);
            btnNgoacPhai.Name = "btnNgoacPhai";
            btnNgoacPhai.Size = new Size(118, 66);
            btnNgoacPhai.TabIndex = 59;
            btnNgoacPhai.Text = ")";
            btnNgoacPhai.UseVisualStyleBackColor = false;
            btnNgoacPhai.Click += btnNgoacPhai_Click;
            // 
            // txbInput
            // 
            txbInput.BackColor = Color.LightGray;
            txbInput.BorderStyle = BorderStyle.None;
            txbInput.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbInput.Location = new Point(26, 70);
            txbInput.Name = "txbInput";
            txbInput.Size = new Size(581, 44);
            txbInput.TabIndex = 56;
            txbInput.Text = "\r\n0\r\n";
            txbInput.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Yellow;
            btnDivide.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDivide.Location = new Point(512, 429);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(118, 66);
            btnDivide.TabIndex = 55;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnNgoacTrai
            // 
            btnNgoacTrai.BackColor = Color.Yellow;
            btnNgoacTrai.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNgoacTrai.Location = new Point(140, 429);
            btnNgoacTrai.Name = "btnNgoacTrai";
            btnNgoacTrai.Size = new Size(118, 66);
            btnNgoacTrai.TabIndex = 53;
            btnNgoacTrai.Text = "(";
            btnNgoacTrai.UseVisualStyleBackColor = false;
            btnNgoacTrai.Click += btnNgoacTrai_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Yellow;
            btnProduct.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnProduct.Location = new Point(512, 501);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(118, 66);
            btnProduct.TabIndex = 52;
            btnProduct.Text = "*";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.White;
            btnNine.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnNine.Location = new Point(388, 501);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(118, 66);
            btnNine.TabIndex = 51;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.White;
            btnEight.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnEight.Location = new Point(264, 501);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(118, 66);
            btnEight.TabIndex = 50;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.White;
            btnSeven.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSeven.Location = new Point(140, 501);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(118, 66);
            btnSeven.TabIndex = 49;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Yellow;
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdd.Location = new Point(512, 645);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 66);
            btnAdd.TabIndex = 48;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Yellow;
            btnResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnResult.Location = new Point(512, 717);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(118, 66);
            btnResult.TabIndex = 47;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Yellow;
            btnSubtract.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSubtract.Location = new Point(512, 573);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(118, 66);
            btnSubtract.TabIndex = 46;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.White;
            btnThree.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnThree.Location = new Point(388, 645);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(118, 66);
            btnThree.TabIndex = 45;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.White;
            btnOne.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnOne.Location = new Point(140, 645);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(118, 66);
            btnOne.TabIndex = 43;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.White;
            btnSix.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSix.Location = new Point(388, 573);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(118, 66);
            btnSix.TabIndex = 42;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.White;
            btnFive.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFive.Location = new Point(264, 573);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(118, 66);
            btnFive.TabIndex = 41;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.White;
            btnFour.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnFour.Location = new Point(140, 573);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(118, 66);
            btnFour.TabIndex = 40;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.White;
            btnPoint.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPoint.Location = new Point(388, 717);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(118, 66);
            btnPoint.TabIndex = 39;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            // 
            // btnChangeOposite
            // 
            btnChangeOposite.BackColor = Color.White;
            btnChangeOposite.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnChangeOposite.Location = new Point(140, 717);
            btnChangeOposite.Name = "btnChangeOposite";
            btnChangeOposite.Size = new Size(118, 66);
            btnChangeOposite.TabIndex = 38;
            btnChangeOposite.Text = "+/-";
            btnChangeOposite.UseVisualStyleBackColor = false;
            btnChangeOposite.Click += btnChangeOposite_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsOption, classicToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(663, 28);
            menuStrip1.TabIndex = 60;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsOption
            // 
            mnsOption.Name = "mnsOption";
            mnsOption.Size = new Size(106, 24);
            mnsOption.Text = "Programmer";
            mnsOption.Click += mnsOption_Click;
            // 
            // classicToolStripMenuItem
            // 
            classicToolStripMenuItem.Name = "classicToolStripMenuItem";
            classicToolStripMenuItem.Size = new Size(67, 24);
            classicToolStripMenuItem.Text = "Classic";
            classicToolStripMenuItem.Click += classicToolStripMenuItem_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.Yellow;
            btnRight.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRight.Location = new Point(264, 357);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(118, 66);
            btnRight.TabIndex = 64;
            btnRight.Text = ">>";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(663, 24);
            menuStrip2.TabIndex = 71;
            menuStrip2.Text = "menuStrip2";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // cmbBitwise
            // 
            cmbBitwise.BackColor = Color.FromArgb(255, 255, 128);
            cmbBitwise.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbBitwise.FormattingEnabled = true;
            cmbBitwise.Items.AddRange(new object[] { "AND", "OR", "NOT", "XOR" });
            cmbBitwise.Location = new Point(16, 308);
            cmbBitwise.Name = "cmbBitwise";
            cmbBitwise.Size = new Size(118, 43);
            cmbBitwise.TabIndex = 74;
            cmbBitwise.Text = "Bitwise";
            cmbBitwise.SelectedIndexChanged += cmbBitwise_SelectedIndexChanged;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.White;
            btnZero.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnZero.Location = new Point(264, 717);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(118, 66);
            btnZero.TabIndex = 75;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            // 
            // btnPer
            // 
            btnPer.BackColor = Color.Yellow;
            btnPer.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPer.Location = new Point(388, 429);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(118, 66);
            btnPer.TabIndex = 77;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = false;
            btnPer.Click += btnPer_Click;
            // 
            // btnA
            // 
            btnA.BackColor = Color.Yellow;
            btnA.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnA.Location = new Point(16, 357);
            btnA.Name = "btnA";
            btnA.Size = new Size(118, 66);
            btnA.TabIndex = 82;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Yellow;
            btnB.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnB.Location = new Point(16, 429);
            btnB.Name = "btnB";
            btnB.Size = new Size(118, 66);
            btnB.TabIndex = 81;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Yellow;
            btnD.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnD.Location = new Point(16, 573);
            btnD.Name = "btnD";
            btnD.Size = new Size(118, 66);
            btnD.TabIndex = 80;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Yellow;
            btnC.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnC.Location = new Point(16, 501);
            btnC.Name = "btnC";
            btnC.Size = new Size(118, 66);
            btnC.TabIndex = 79;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.Yellow;
            btnE.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnE.Location = new Point(16, 645);
            btnE.Name = "btnE";
            btnE.Size = new Size(118, 66);
            btnE.TabIndex = 78;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // btnF
            // 
            btnF.BackColor = Color.Yellow;
            btnF.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnF.Location = new Point(16, 717);
            btnF.Name = "btnF";
            btnF.Size = new Size(118, 66);
            btnF.TabIndex = 83;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            btnF.Click += btnF_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.Yellow;
            btnLeft.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLeft.Location = new Point(140, 357);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(118, 66);
            btnLeft.TabIndex = 84;
            btnLeft.Text = "<<";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.Yellow;
            btnClearEntry.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnClearEntry.Location = new Point(388, 357);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(118, 66);
            btnClearEntry.TabIndex = 87;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDelete.Location = new Point(512, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 66);
            btnDelete.TabIndex = 86;
            btnDelete.Text = "X";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.White;
            btnTwo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnTwo.Location = new Point(264, 645);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(118, 66);
            btnTwo.TabIndex = 88;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            // 
            // txbDecResult
            // 
            txbDecResult.BackColor = Color.LightGray;
            txbDecResult.BorderStyle = BorderStyle.None;
            txbDecResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbDecResult.Location = new Point(88, 183);
            txbDecResult.Name = "txbDecResult";
            txbDecResult.Size = new Size(366, 34);
            txbDecResult.TabIndex = 90;
            txbDecResult.Text = "0";
            // 
            // txbHexResult
            // 
            txbHexResult.BackColor = Color.LightGray;
            txbHexResult.BorderStyle = BorderStyle.None;
            txbHexResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbHexResult.Location = new Point(88, 153);
            txbHexResult.Name = "txbHexResult";
            txbHexResult.Size = new Size(366, 34);
            txbHexResult.TabIndex = 91;
            txbHexResult.Text = "0";
            // 
            // lblHex
            // 
            lblHex.AutoSize = true;
            lblHex.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHex.Location = new Point(26, 161);
            lblHex.Name = "lblHex";
            lblHex.Size = new Size(56, 26);
            lblHex.TabIndex = 92;
            lblHex.Text = "HEX";
            lblHex.Click += lblHex_Click;
            // 
            // lblDec
            // 
            lblDec.AutoSize = true;
            lblDec.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDec.Location = new Point(26, 191);
            lblDec.Name = "lblDec";
            lblDec.Size = new Size(56, 26);
            lblDec.TabIndex = 95;
            lblDec.Text = "DEC";
            lblDec.Click += lblDec_Click;
            // 
            // lblBin
            // 
            lblBin.AutoSize = true;
            lblBin.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBin.Location = new Point(26, 252);
            lblBin.Name = "lblBin";
            lblBin.Size = new Size(50, 26);
            lblBin.TabIndex = 99;
            lblBin.Text = "BIN";
            lblBin.Click += lblBin_Click;
            // 
            // lblOct
            // 
            lblOct.AutoSize = true;
            lblOct.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOct.Location = new Point(26, 222);
            lblOct.Name = "lblOct";
            lblOct.Size = new Size(58, 26);
            lblOct.TabIndex = 98;
            lblOct.Text = "OCT";
            lblOct.Click += lblOct_Click;
            // 
            // txbOctResult
            // 
            txbOctResult.BackColor = Color.LightGray;
            txbOctResult.BorderStyle = BorderStyle.None;
            txbOctResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbOctResult.Location = new Point(88, 214);
            txbOctResult.Name = "txbOctResult";
            txbOctResult.Size = new Size(366, 34);
            txbOctResult.TabIndex = 97;
            txbOctResult.Text = "0";
            // 
            // txbBinResult
            // 
            txbBinResult.BackColor = Color.LightGray;
            txbBinResult.BorderStyle = BorderStyle.None;
            txbBinResult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            txbBinResult.Location = new Point(88, 244);
            txbBinResult.Name = "txbBinResult";
            txbBinResult.Size = new Size(366, 34);
            txbBinResult.TabIndex = 96;
            txbBinResult.Text = "0";
            // 
            // txbResult
            // 
            txbResult.BackColor = Color.LightGray;
            txbResult.BorderStyle = BorderStyle.None;
            txbResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbResult.Location = new Point(26, 114);
            txbResult.Name = "txbResult";
            txbResult.Size = new Size(581, 44);
            txbResult.TabIndex = 100;
            txbResult.TextAlign = HorizontalAlignment.Right;
            // 
            // Programmer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(txbResult);
            Controls.Add(lblBin);
            Controls.Add(lblOct);
            Controls.Add(txbOctResult);
            Controls.Add(txbBinResult);
            Controls.Add(lblDec);
            Controls.Add(lblHex);
            Controls.Add(txbHexResult);
            Controls.Add(txbDecResult);
            Controls.Add(btnTwo);
            Controls.Add(btnClearEntry);
            Controls.Add(btnDelete);
            Controls.Add(btnLeft);
            Controls.Add(btnF);
            Controls.Add(btnA);
            Controls.Add(btnB);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnE);
            Controls.Add(btnPer);
            Controls.Add(btnZero);
            Controls.Add(cmbBitwise);
            Controls.Add(btnRight);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(btnNgoacPhai);
            Controls.Add(txbInput);
            Controls.Add(btnDivide);
            Controls.Add(btnNgoacTrai);
            Controls.Add(btnProduct);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnAdd);
            Controls.Add(btnResult);
            Controls.Add(btnSubtract);
            Controls.Add(btnThree);
            Controls.Add(btnOne);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnPoint);
            Controls.Add(btnChangeOposite);
            Name = "Programmer";
            Size = new Size(663, 921);
            Load += Programmer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNgoacPhai;
        private TextBox txtResultFinal;
        private TextBox txbInput;
        private Button btnDivide;
        private Button btnClear;
        private Button btnNgoacTrai;
        private Button btnProduct;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnAdd;
        private Button btnResult;
        private Button btnSubtract;
        private Button btnThree;
        private Button btnOne;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnPoint;
        private Button btnChangeOposite;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsOption;
        private ToolStripMenuItem classicToolStripMenuItem;
        private Button btnRight;
        private Button btnLeft;
        private Button btnClearEntry;
        private Button btnDelete;
      
        private MenuStrip menuStrip2;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ComboBox cmbBitwise;
        private Button btnZero;
        private Button btnPer;
        private Button btnA;
        private Button btnB;
        private Button btnD;
        private Button btnC;
        private Button btnE;
        private Button btnF;
        private Button btnTwo;
        private TextBox txbDecResult;
        private TextBox txbHexResult;
        private Label lblHex;
        private Label label1;
        private Label label3;
        private Label lblDec;
        private Label lblBin;
        private Label lblOct;
        private TextBox txbOctResult;
        private TextBox txbBinResult;
        private TextBox txbResult;
    }
}