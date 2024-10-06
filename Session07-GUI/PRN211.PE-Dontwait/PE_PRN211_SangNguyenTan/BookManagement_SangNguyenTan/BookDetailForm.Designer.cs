namespace BookManagement_SangNguyenTan
{
    partial class BookDetailForm
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
            btnSave = new Button();
            lblHeader = new Label();
            btnCancel = new Button();
            lblBookName = new Label();
            lblBookId = new Label();
            txtBookId = new TextBox();
            txtQuantity = new TextBox();
            lblPrice = new Label();
            lblDescription = new Label();
            lblPublicationDate = new Label();
            lblQuantity = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            txtBookName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtAuthor = new TextBox();
            dtpPublicationDate = new DateTimePicker();
            cboBookCategoryId = new ComboBox();
            grbBookInfo = new GroupBox();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(966, 164);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 64);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(14, 44);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(621, 81);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(966, 299);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 64);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(23, 151);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(146, 32);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookId.ForeColor = Color.Yellow;
            lblBookId.Location = new Point(23, 79);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(105, 32);
            lblBookId.TabIndex = 4;
            lblBookId.Text = "Book ID";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(245, 79);
            txtBookId.Margin = new Padding(3, 4, 3, 4);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(516, 29);
            txtBookId.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(245, 401);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(163, 29);
            txtQuantity.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(527, 393);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(71, 32);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(25, 221);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(146, 32);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Descprition";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(23, 345);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(204, 32);
            lblPublicationDate.TabIndex = 9;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(23, 401);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(113, 32);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(23, 473);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(94, 32);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(21, 544);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(118, 32);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Category";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(245, 151);
            txtBookName.Margin = new Padding(3, 4, 3, 4);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(516, 29);
            txtBookName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(245, 225);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(516, 97);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(598, 397);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(163, 29);
            txtPrice.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(245, 469);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(516, 29);
            txtAuthor.TabIndex = 6;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(245, 345);
            dtpPublicationDate.Margin = new Padding(3, 4, 3, 4);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(204, 29);
            dtpPublicationDate.TabIndex = 3;
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(245, 548);
            cboBookCategoryId.Margin = new Padding(3, 4, 3, 4);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(178, 29);
            cboBookCategoryId.TabIndex = 7;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(14, 148);
            grbBookInfo.Margin = new Padding(3, 4, 3, 4);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Padding = new Padding(3, 4, 3, 4);
            grbBookInfo.Size = new Size(911, 673);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "  Book Info";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1170, 765);
            Controls.Add(btnCancel);
            Controls.Add(lblHeader);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookDetailForm";
            Text = "Add | Update a book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label lblHeader;
        private Button btnCancel;
        private Label lblBookName;
        private Label lblBookId;
        private TextBox txtBookId;
        private TextBox txtQuantity;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblPublicationDate;
        private Label lblQuantity;
        private Label lblAuthor;
        private Label lblCategory;
        private TextBox txtBookName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtAuthor;
        private DateTimePicker dtpPublicationDate;
        private ComboBox cboBookCategoryId;
        private GroupBox grbBookInfo;
    }
}