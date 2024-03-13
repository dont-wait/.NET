namespace Zodiac
{
    partial class ZodiacManager
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
            lblWelcome = new Label();
            btnShowImage = new Button();
            picImage = new PictureBox();
            pnlImage = new Panel();
            btnQuit = new Button();
            btnCheckZodiac = new Button();
            lblDay = new Label();
            lblMonth = new Label();
            lblYourZodiac = new Label();
            txbBirthDay = new TextBox();
            txbMonth = new TextBox();
            lblNoCopyright = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnlImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Red;
            lblWelcome.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Yellow;
            lblWelcome.Location = new Point(-1, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(559, 86);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Zodiac Calculator";
            // 
            // btnShowImage
            // 
            btnShowImage.FlatStyle = FlatStyle.Flat;
            btnShowImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowImage.Location = new Point(162, 316);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(154, 34);
            btnShowImage.TabIndex = 3;
            btnShowImage.Text = "show Image";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // picImage
            // 
            picImage.BackColor = Color.WhiteSmoke;
            picImage.Location = new Point(13, 15);
            picImage.Name = "picImage";
            picImage.Size = new Size(336, 346);
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
            picImage.TabIndex = 3;
            picImage.TabStop = false;
            picImage.Click += pictureBox2_Click;
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.BackColor = Color.FromArgb(255, 128, 255);
            pnlImage.Controls.Add(picImage);
            pnlImage.Location = new Point(495, 89);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(366, 383);
            pnlImage.TabIndex = 4;
            pnlImage.Paint += pnlImage_Paint;
            // 
            // btnQuit
            // 
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(322, 316);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(154, 34);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.FlatStyle = FlatStyle.Flat;
            btnCheckZodiac.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckZodiac.Location = new Point(2, 316);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(154, 34);
            btnCheckZodiac.TabIndex = 2;
            btnCheckZodiac.Text = "Check Zodiac";
            btnCheckZodiac.UseVisualStyleBackColor = true;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Red;
            lblDay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDay.ForeColor = Color.Yellow;
            lblDay.Location = new Point(26, 140);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(114, 21);
            lblDay.TabIndex = 7;
            lblDay.Text = "Your birthday";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BackColor = Color.Red;
            lblMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.Yellow;
            lblMonth.Location = new Point(26, 187);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(141, 21);
            lblMonth.TabIndex = 8;
            lblMonth.Text = "Your birth month";
            // 
            // lblYourZodiac
            // 
            lblYourZodiac.AutoSize = true;
            lblYourZodiac.BackColor = Color.Red;
            lblYourZodiac.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblYourZodiac.ForeColor = Color.Yellow;
            lblYourZodiac.Location = new Point(2, 492);
            lblYourZodiac.Name = "lblYourZodiac";
            lblYourZodiac.Size = new Size(302, 45);
            lblYourZodiac.TabIndex = 5;
            lblYourZodiac.Text = "Your Zodiac sign is";
            // 
            // txbBirthDay
            // 
            txbBirthDay.Location = new Point(194, 140);
            txbBirthDay.Name = "txbBirthDay";
            txbBirthDay.Size = new Size(100, 23);
            txbBirthDay.TabIndex = 0;
            // 
            // txbMonth
            // 
            txbMonth.Location = new Point(194, 189);
            txbMonth.Name = "txbMonth";
            txbMonth.Size = new Size(100, 23);
            txbMonth.TabIndex = 1;
            // 
            // lblNoCopyright
            // 
            lblNoCopyright.FlatStyle = FlatStyle.Flat;
            lblNoCopyright.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoCopyright.Location = new Point(13, 553);
            lblNoCopyright.Name = "lblNoCopyright";
            lblNoCopyright.Size = new Size(154, 34);
            lblNoCopyright.TabIndex = 9;
            lblNoCopyright.Text = "© 2024 - Sang.NT";
            lblNoCopyright.UseVisualStyleBackColor = true;
            // 
            // ZodiacManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(921, 599);
            Controls.Add(lblNoCopyright);
            Controls.Add(txbMonth);
            Controls.Add(txbBirthDay);
            Controls.Add(lblYourZodiac);
            Controls.Add(lblMonth);
            Controls.Add(lblDay);
            Controls.Add(btnCheckZodiac);
            Controls.Add(btnQuit);
            Controls.Add(pnlImage);
            Controls.Add(btnShowImage);
            Controls.Add(lblWelcome);
            ForeColor = Color.Yellow;
            Name = "ZodiacManager";
            Text = "Welcome to Zodiac calculator";
            Load += ZodiacManager_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnlImage.ResumeLayout(false);
            pnlImage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShowImage;
        private PictureBox picImage;
        private Panel pnlImage;
        private Button btnQuit;
        private Button btnCheckZodiac;
        private Label lblDay;
        private Label lblMonth;
        private Label lblYourZodiac;
        private TextBox txbBirthDay;
        private TextBox txbMonth;
        private Button lblNoCopyright;
    }
}
