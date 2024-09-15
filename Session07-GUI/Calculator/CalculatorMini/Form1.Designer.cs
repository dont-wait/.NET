namespace CalculatorMini
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
            btnAdd = new Button();
            btnDivide = new Button();
            btnProduct = new Button();
            btnSubtract = new Button();
            btnDelete = new Button();
            txbInputFirstNumber = new TextBox();
            txbInputSecondNumber = new TextBox();
            lblInputFirstNumber = new Label();
            lblInputSecondNumber = new Label();
            txtResult = new TextBox();
            lblResult = new Label();
            lblNoCopy = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(52, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.White;
            btnDivide.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDivide.Location = new Point(250, 107);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(47, 42);
            btnDivide.TabIndex = 1;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.White;
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProduct.Location = new Point(184, 107);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(46, 42);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "*";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.White;
            btnSubtract.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubtract.Location = new Point(121, 107);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(47, 42);
            btnSubtract.TabIndex = 3;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(314, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(47, 42);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txbInputFirstNumber
            // 
            txbInputFirstNumber.BackColor = Color.Snow;
            txbInputFirstNumber.Location = new Point(184, 31);
            txbInputFirstNumber.Name = "txbInputFirstNumber";
            txbInputFirstNumber.Size = new Size(177, 27);
            txbInputFirstNumber.TabIndex = 5;
            txbInputFirstNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // txbInputSecondNumber
            // 
            txbInputSecondNumber.BackColor = Color.White;
            txbInputSecondNumber.Location = new Point(184, 64);
            txbInputSecondNumber.Name = "txbInputSecondNumber";
            txbInputSecondNumber.Size = new Size(177, 27);
            txbInputSecondNumber.TabIndex = 6;
            txbInputSecondNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // lblInputFirstNumber
            // 
            lblInputFirstNumber.AutoSize = true;
            lblInputFirstNumber.BackColor = Color.Red;
            lblInputFirstNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputFirstNumber.ForeColor = Color.Yellow;
            lblInputFirstNumber.Location = new Point(21, 34);
            lblInputFirstNumber.Name = "lblInputFirstNumber";
            lblInputFirstNumber.Size = new Size(136, 20);
            lblInputFirstNumber.TabIndex = 7;
            lblInputFirstNumber.Text = "Nhập số thứ nhất:";
            // 
            // lblInputSecondNumber
            // 
            lblInputSecondNumber.AutoSize = true;
            lblInputSecondNumber.BackColor = Color.Red;
            lblInputSecondNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInputSecondNumber.ForeColor = Color.Yellow;
            lblInputSecondNumber.Location = new Point(21, 64);
            lblInputSecondNumber.Name = "lblInputSecondNumber";
            lblInputSecondNumber.Size = new Size(125, 20);
            lblInputSecondNumber.TabIndex = 8;
            lblInputSecondNumber.Text = "Nhập số thứ hai:\r\n";
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.White;
            txtResult.Location = new Point(184, 175);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(177, 27);
            txtResult.TabIndex = 9;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Red;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResult.ForeColor = Color.Yellow;
            lblResult.Location = new Point(90, 178);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(67, 20);
            lblResult.TabIndex = 10;
            lblResult.Text = "Kết quả:";
            // 
            // lblNoCopy
            // 
            lblNoCopy.AutoSize = true;
            lblNoCopy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoCopy.ForeColor = Color.Yellow;
            lblNoCopy.Location = new Point(0, 214);
            lblNoCopy.Name = "lblNoCopy";
            lblNoCopy.Size = new Size(85, 20);
            lblNoCopy.TabIndex = 11;
            lblNoCopy.Text = "©dontwait";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(376, 234);
            Controls.Add(lblNoCopy);
            Controls.Add(lblResult);
            Controls.Add(txtResult);
            Controls.Add(lblInputSecondNumber);
            Controls.Add(lblInputFirstNumber);
            Controls.Add(txbInputSecondNumber);
            Controls.Add(txbInputFirstNumber);
            Controls.Add(btnDelete);
            Controls.Add(btnSubtract);
            Controls.Add(btnProduct);
            Controls.Add(btnDivide);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Mini";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDivide;
        private Button btnProduct;
        private Button btnSubtract;
        private Button btnDelete;
        private TextBox txbInputFirstNumber;
        private TextBox txbInputSecondNumber;
        private Label lblInputFirstNumber;
        private Label lblInputSecondNumber;
        private TextBox txtResult;
        private Label lblResult;
        private Label lblNoCopy;
    }
}
