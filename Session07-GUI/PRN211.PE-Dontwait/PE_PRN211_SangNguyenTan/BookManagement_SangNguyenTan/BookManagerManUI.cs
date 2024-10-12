using Repositories.Entities;
using Services;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BookManagement_SangNguyenTan
{
    public partial class BookManagerManUI : Form
    {
        private BookService _service = new BookService();

        //backing field
        private Book _selected = null; // chờ ai đó chọn 1 dòng trong grid/table
                                       // thì nó được gán bằng = cuốn sách đang được chọn
                                       //đẩy cuốn sách này qua màn hình update

        public BookManagerManUI()
        {
            InitializeComponent();
        }

        //hàm dùng nội bộ gọi là Helper
        private void FillDataGridView()
        {
            dgvBookList.DataSource = null;  //xoá trắng grid
            dgvBookList.DataSource = _service.GetAllBooks();    //nhờ service đọc xuống DB(đi nhờ Repo)
        }
        public void BookManagerManUI_Load(object sender, EventArgs e)
        {
            //gọi Services để cung cấp data vào grid/table
            FillDataGridView();
            //dgvBookList.DataSource = null;  //xoá trắng grid
            //dgvBookList.DataSource = _service.GetAllBooks();
            //                      hàm I trả về all books

        }   //Bad Smells - Robert C.Martin - Clean Code, SOLID, Agile Manifesco
            //HÀM FILL DATA VÀO GRID ĐC GỌI NHIỀU LẦN Ở NÚT CREATE, , UPDATE, DELETE, LOAD FORM
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                MessageBox.Show("Please select a certain book to delete!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //ko thoát hàm tức đã chọn dòng
            //nhờ _service xoá dùm
            DialogResult anwser = MessageBox.Show("Do you really to delete this book", "Delete Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(anwser == DialogResult.No)
            {
                return;
            }

            //sure YES thì xoá
            _service.DeleteBookFromUI(_selected); //thay vì đẩy Book sang Detail Form thì nay ta đẩy xuống hàm xoá
            //F5
            FillDataGridView();

            //VIP???
            _selected = null;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult anwser = MessageBox.Show("Do you want to quit?", "Exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (anwser == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là  class BookDetailForm, khác truyền thống là nó cần render bề mặt!!!
            //Nó là 1 class name nên nó sẽ có _field, prop, method như bth
            //khai báo biến new như bth
            BookDetailForm f = new BookDetailForm();
            //f.Show(); nguy hiểm vì cứ new là có object, là có cửa sổ mới
            f.ShowDialog(); //render đi em 
            //f5 lướt
            FillDataGridView();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 hay nhiều dòng - chìm chuột, cho nên ta
            //lấy dòng đầu tiên đc chọn nếu người ta chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn
                //bóc nó ra, đẩy sang màn hình detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem; //lấy 1 dòng chính là
                //kiểu object tổng quát, nhưng bản chất là BOok do lúc đầu .DataSource = List<Book> của 
                //hàm getAllBook

                //đẩy sang Form Detail
                //khai biến, new, gán prop, show dialog
                //thằng form detail: mở lên, chêck selected khác
                //null hem? khác null mode EDIT, SHOW DATA ĐC GỬI SANG
            }
            //TODO: nếu user chọn Cell thay vì chọn nguyên dòng, reset biến _selected về null
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (_selected != null)
            { //người dùng phải chọn 1 dòng trong Grd
                BookDetailForm f = new BookDetailForm(); //trong đây có đặc tính selectedBook
                                                         //đưa sách sang
                f.SelectedBook = _selected;
                f.ShowDialog();
                FillDataGridView();
            }
            else
                MessageBox.Show("Please select a certain book to edit!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ta sẽ lấy ra 2 chuỗi đang nằm trong txtBookName & txtDescription
            //và ta where trên danh sách books đang có
            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;
            //dgvBookList.DataSource = books.Where(x => false).ToList(); // ko trả về cuốn nào
            //dgvBookList.DataSource = books.Where(x => true).ToList(); // đưa cuốn nào cx đồng ý hết
            dgvBookList.DataSource = books.Where(x => 
                    x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();
            
        }
    }
}
