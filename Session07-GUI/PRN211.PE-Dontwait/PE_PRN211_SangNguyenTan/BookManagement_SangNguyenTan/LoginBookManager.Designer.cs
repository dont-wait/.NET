namespace BookManagement_SangNguyenTan
{
    partial class LoginBookManager
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
            grbAccountInfo = new GroupBox();
            btnCancel = new Button();
            btnLogin = new Button();
            llbMissPassword = new LinkLabel();
            txtPasssword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            lblHeader = new Label();
            grbAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // grbAccountInfo
            // 
            grbAccountInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            grbAccountInfo.BackColor = Color.LightSeaGreen;
            grbAccountInfo.Controls.Add(btnCancel);
            grbAccountInfo.Controls.Add(btnLogin);
            grbAccountInfo.Controls.Add(llbMissPassword);
            grbAccountInfo.Controls.Add(txtPasssword);
            grbAccountInfo.Controls.Add(txtEmail);
            grbAccountInfo.Controls.Add(lblPassword);
            grbAccountInfo.Controls.Add(lblEmail);
            grbAccountInfo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAccountInfo.ForeColor = Color.Yellow;
            grbAccountInfo.Location = new Point(142, 161);
            grbAccountInfo.Name = "grbAccountInfo";
            grbAccountInfo.Size = new Size(692, 410);
            grbAccountInfo.TabIndex = 0;
            grbAccountInfo.TabStop = false;
            grbAccountInfo.Text = "Account info";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(404, 259);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(187, 48);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(156, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // llbMissPassword
            // 
            llbMissPassword.AutoSize = true;
            llbMissPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbMissPassword.LinkColor = Color.DimGray;
            llbMissPassword.Location = new Point(451, 218);
            llbMissPassword.Name = "llbMissPassword";
            llbMissPassword.Size = new Size(143, 25);
            llbMissPassword.TabIndex = 5;
            llbMissPassword.TabStop = true;
            llbMissPassword.Text = "Quên mật khẩu";
            // 
            // txtPasssword
            // 
            txtPasssword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasssword.Location = new Point(279, 181);
            txtPasssword.Name = "txtPasssword";
            txtPasssword.PasswordChar = '*';
            txtPasssword.Size = new Size(302, 31);
            txtPasssword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(279, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 31);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "Type your email";
            txtEmail.Click += txtUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(85, 174);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(147, 38);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(85, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(97, 38);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(246, 57);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(448, 81);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Book Manager";
            // 
            // LoginBookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1112, 653);
            Controls.Add(lblHeader);
            Controls.Add(grbAccountInfo);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginBookManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grbAccountInfo.ResumeLayout(false);
            grbAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private GroupBox grbAccountInfo;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private LinkLabel llbMissPassword;
        private TextBox txtPasssword;
        private Button btnLogin;
        private Button btnCancel;
        private Label lblHeader;
    }
}