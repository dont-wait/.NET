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
            btnSave.Location = new Point(845, 123);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 48);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(12, 33);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(498, 65);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(845, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(149, 48);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(20, 113);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(116, 25);
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookId.ForeColor = Color.Yellow;
            lblBookId.Location = new Point(20, 59);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(84, 25);
            lblBookId.TabIndex = 4;
            lblBookId.Text = "Book ID";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(214, 59);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(452, 25);
            txtBookId.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(214, 301);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(143, 25);
            txtQuantity.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(461, 295);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(22, 166);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 25);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Descprition";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(20, 259);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(159, 25);
            lblPublicationDate.TabIndex = 9;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(20, 301);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(89, 25);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(20, 355);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(75, 25);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(18, 408);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(94, 25);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Category";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(214, 113);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(452, 25);
            txtBookName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(214, 169);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(452, 74);
            txtDescription.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(523, 298);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(143, 25);
            txtPrice.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(214, 352);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(452, 25);
            txtAuthor.TabIndex = 6;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(214, 259);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(179, 25);
            dtpPublicationDate.TabIndex = 3;
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(214, 411);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(156, 25);
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
            grbBookInfo.Location = new Point(12, 111);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(797, 505);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = "  Book Info";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1024, 574);
            Controls.Add(btnCancel);
            Controls.Add(lblHeader);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
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