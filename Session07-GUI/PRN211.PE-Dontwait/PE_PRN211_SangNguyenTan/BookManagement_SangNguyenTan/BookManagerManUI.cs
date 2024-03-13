using Services;

namespace BookManagement_SangNguyenTan
{
    public partial class BookManagerManUI : Form
    {
        public BookManagerManUI()
        {
            InitializeComponent();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void BookManagerManUI_Load(object sender, EventArgs e)
        {
            //gọi Services để cung cấp data vào grid/table
            BookService bookService = new BookService();

            dgvBookList.DataSource = null;  //xoá trắng grid
            dgvBookList.DataSource = bookService.GetAllBook();

        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult anwser = MessageBox.Show("Do you want to exit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(anwser == DialogResult.Yes)
                Application.Exit();
        }
    }
}
