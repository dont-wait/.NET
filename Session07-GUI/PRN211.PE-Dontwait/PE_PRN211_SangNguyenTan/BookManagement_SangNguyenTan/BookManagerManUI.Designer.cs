namespace BookManagement_SangNguyenTan
{
    partial class BookManagerManUI
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
            lblHeader = new Label();
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookName = new Label();
            lblBookDesciption = new Label();
            lblBookList = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            lblCopyRight = new Label();
            grbAction = new GroupBox();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grbAction.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(1, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(359, 65);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            lblHeader.Click += lblHeader_Click;
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtBookDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Controls.Add(lblBookDesciption);
            grbSearchCriteria.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(22, 106);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(808, 118);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(681, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(521, 48);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(143, 33);
            txtBookDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(128, 48);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(162, 33);
            txtBookName.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(6, 51);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(116, 25);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            lblBookName.Click += label4_Click;
            // 
            // lblBookDesciption
            // 
            lblBookDesciption.AutoSize = true;
            lblBookDesciption.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookDesciption.ForeColor = Color.Yellow;
            lblBookDesciption.Location = new Point(349, 51);
            lblBookDesciption.Name = "lblBookDesciption";
            lblBookDesciption.Size = new Size(166, 25);
            lblBookDesciption.TabIndex = 3;
            lblBookDesciption.Text = "Book Description";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(22, 249);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(93, 25);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(33, 32);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(184, 38);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(33, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(184, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(33, 92);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(184, 38);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(842, 491);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(184, 38);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(30, 277);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.Size = new Size(548, 227);
            dgvBookList.TabIndex = 1;
           
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopyRight.ForeColor = Color.Yellow;
            lblCopyRight.Location = new Point(28, 507);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(114, 17);
            lblCopyRight.TabIndex = 13;
            lblCopyRight.Text = "© 2024 dont-wait";
            lblCopyRight.Click += label1_Click;
            // 
            // grbAction
            // 
            grbAction.Controls.Add(btnUpdate);
            grbAction.Controls.Add(btnDelete);
            grbAction.Controls.Add(btnCreate);
            grbAction.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAction.ForeColor = Color.Yellow;
            grbAction.Location = new Point(601, 269);
            grbAction.Name = "grbAction";
            grbAction.Size = new Size(238, 211);
            grbAction.TabIndex = 2;
            grbAction.TabStop = false;
            grbAction.Text = " Action ";
            // 
            // BookManagerManUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1038, 541);
            Controls.Add(grbAction);
            Controls.Add(lblCopyRight);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            Name = "BookManagerManUI";
            Text = "Book Manager";
            Load += BookManagerManUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grbAction.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCriteria;
        private Label lblBookName;
        private Label lblBookDesciption;
        private Label lblBookList;
        private TextBox txtBookDescription;
        private TextBox txtBookName;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Label lblCopyRight;
        private GroupBox grbAction;
    }
}
