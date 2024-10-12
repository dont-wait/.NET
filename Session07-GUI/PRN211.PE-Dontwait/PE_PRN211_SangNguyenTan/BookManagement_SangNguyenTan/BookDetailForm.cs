using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_SangNguyenTan
{

    public partial class BookDetailForm : Form
    {
        //vì DetailForm cx là 1 class, nên nó cx có prop bth.
        //hơn bth, là có class có thể render (Bố/Cha class của SDK lo phần kế thừa)

        //public int Yob { get; set; } = 2003;
        public Book SelectedBook { get; set; } = null;
        //mặc định form này mở lên, ko có Book nào cả
        //nếu muốn có Book thì phải
        //.SelectedBook = cuốn muốn gán vào!!! 
        //Mượn dto để thể hiện thông qua get set hoi
        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            //MỞ MÀN HÌNH DETAIL THÌ TA SẼ:
            //1. FILL ĐẦY CATEGORY DROP DOWN- LẤY DATA TỪ TABLE CATEGORY
            //2. NẾU LÀ EDIT 1 CUỐN SÁCH THÌ FILL DATA CỦA CUỐN SÁCH MÚN
            //   EDIT VÀO CÁC Ô TƯƠNG ỨNG
            //3. NẾU LÀ TẠO MỚI CUỐN SÁCH THÌ CỨ ĐỂ MÀN HÌNH TRẮNG TRƠN V ĐÓ
            //CHỜ USER NHẬP - KO CẦN LÀM GÌ THÊM
            //if (SelectedBook == null)
            //    lblHeader.Text = "Add a new book";
            //else
            //    lblHeader.Text = "Update a book";
            //đổ full data vào cbo
            BookCategoryService cat = new BookCategoryService();
            cboBookCategoryId.DataSource = cat.GetAllCategories();  //hàm số II 

            //chọn cột để hiển thị trên Cbo
            cboBookCategoryId.DisplayMember = "BookGenreType";

            //chọn cột để lấy value thực sự cần dùng - what you see is not what you get
            //Chọn Self Help cho user -> code map sang value 5 của cột
            //BookCategory, dùng làm FK đẩy vào table book
            cboBookCategoryId.ValueMember = "BookCategoryId";

            //vi diệu
            //nhảy đến giá trị bất kì mình thích trong combo
            //cboBookCategoryId.SelectedValue = 5;//default với mình 
            //là sách self help

            //CHECK HÀNG, CÓ PHẢI LÀ EDIT HAY KO
            //CHECK BIẾN SELECTEDBOOK COI CÓ DC SET KHÁC NULL KO
            //NẾU CÓ SÁCH THÌ FILL VÀO CÁC Ô
            if (SelectedBook != null)
            {
                lblHeader.Text = "Update a book...";
                
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookId.Enabled = false; //KO CHO EDIT MA CUON SACH 
                
                txtBookName.Text = SelectedBook.BookName;
                
                txtAuthor.Text = SelectedBook.Author;
                
                txtDescription.Text = SelectedBook.Description;
                
                txtPrice.Text = SelectedBook.Price.ToString();
                
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                
                dtpPublicationDate.Value = SelectedBook.PublicationDate;
                
                cboBookCategoryId.SelectedValue =
                    SelectedBook.BookCategoryId;//default với mình 
                //tuỳ sách cate gì thì jump đên số đó!!!

            }
            else
                lblHeader.Text = "Create a new book...";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ta phải new một cuốn sách với các info từ ô text
            //gõ ô text để update hoặc tạo mới, thì rõ ràng là phải đưa ô text vào một cuốn sách
            //ko care sách mới hay cũ, phải new trong Ram cái đã
            //nếu là sách cũ edit mode thì cuốn sách new có id của Book Selected
            //nếu là sách ADD MODE, thì cuốn này có cái ID mới và mong nó không trùng id đám sách cũ đang có -> INSERT XUỐNG DB
            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                Author = txtAuthor.Text,
                BookCategoryId = int.Parse(cboBookCategoryId.SelectedValue.ToString())
            };
            //Object initiazation
            //gửi xuống DB qua BOOKSERVICE  
            BookService service = new();
            //check mode EDIT HAY NEW
            if (SelectedBook != null) //flag variable 
                service.UpdateBookFromUI(book);
            else 
                service.AddBookFromUI(book);
            //cho dù new/hay edit thì xong phải tắt form cái màn hình này
            Close();    // hàm của class Cha Form
            //Đóng màn hình Detail thì phải F5 cái lướt grid
            //bên Main Form phải refresh lưới ở ngây chỗ sau Detail
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboBookCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
