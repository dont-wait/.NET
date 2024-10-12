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
            txtDescription = new TextBox();
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
            lblHeader.Size = new Size(448, 81);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Controls.Add(lblBookDesciption);
            grbSearchCriteria.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(25, 141);
            grbSearchCriteria.Margin = new Padding(3, 4, 3, 4);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Padding = new Padding(3, 4, 3, 4);
            grbSearchCriteria.Size = new Size(923, 157);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(778, 61);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 51);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(595, 64);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(163, 39);
            txtDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(146, 64);
            txtBookName.Margin = new Padding(3, 4, 3, 4);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(185, 39);
            txtBookName.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(7, 68);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(146, 32);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookDesciption
            // 
            lblBookDesciption.AutoSize = true;
            lblBookDesciption.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookDesciption.ForeColor = Color.Yellow;
            lblBookDesciption.Location = new Point(378, 67);
            lblBookDesciption.Name = "lblBookDesciption";
            lblBookDesciption.Size = new Size(211, 32);
            lblBookDesciption.TabIndex = 3;
            lblBookDesciption.Text = "Book Description";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(25, 332);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(118, 32);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(38, 43);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(210, 51);
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
            btnDelete.Location = new Point(38, 203);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(210, 51);
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
            btnUpdate.Location = new Point(38, 123);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(210, 51);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(962, 655);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(210, 51);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(34, 369);
            dgvBookList.Margin = new Padding(3, 4, 3, 4);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(626, 303);
            dgvBookList.TabIndex = 1;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopyRight.ForeColor = Color.Yellow;
            lblCopyRight.Location = new Point(32, 676);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(154, 23);
            lblCopyRight.TabIndex = 13;
            lblCopyRight.Text = "© 2024 dont-wait";
            // 
            // grbAction
            // 
            grbAction.Controls.Add(btnUpdate);
            grbAction.Controls.Add(btnDelete);
            grbAction.Controls.Add(btnCreate);
            grbAction.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAction.ForeColor = Color.Yellow;
            grbAction.Location = new Point(687, 359);
            grbAction.Margin = new Padding(3, 4, 3, 4);
            grbAction.Name = "grbAction";
            grbAction.Padding = new Padding(3, 4, 3, 4);
            grbAction.Size = new Size(272, 281);
            grbAction.TabIndex = 2;
            grbAction.TabStop = false;
            grbAction.Text = " Action ";
            // 
            // BookManagerManUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1186, 721);
            Controls.Add(grbAction);
            Controls.Add(lblCopyRight);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "BookManagerManUI";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtDescription;
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
