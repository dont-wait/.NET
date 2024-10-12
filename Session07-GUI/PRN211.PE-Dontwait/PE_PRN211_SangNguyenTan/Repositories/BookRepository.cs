using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    //CLASS NÀY CHƠI TRỰC TIẾP VỚI DB THÔNG QUA DBCONTEXT( CHỨA CONNECTSTRING)
    //GỌI TRỰC TIẾP BOOKSERVICE
    //UI <--> BOOKSERVICE <--> BOOKREPO --> DBCONTEXT <-> TABLE
    //[1]       [2]             [3]

    //TRONG UI PHẢI KHAI BÁO SERVICE
    //                           Service phải khai báo Repo
    //                                                  đến lượt Repo phải khai báo dbcontext
    //                                                                              context khai báo Connection String
    //TA (REPO) Ở ĐÂY BỊ SERVICE GỌI ĐỂ ĐƯA DATA
    //TA MUỐN GIÚP SERVICE THÌ PHẢI GỌI DBCONTEXT
    //TA CUNG CẤP CÁC HÀM CRUD TABLE CƠ BẢN
    //AddBook() UpdateBook() DeleteBook() GetBooks() GetABook()

    //api/v2/books - lấy hết sách
    //api/v2/books/123564 - lấy cuốn sách có mã...
    public class BookRepository
    {
        private BookManagementDbContext _context; //tra ve db
        //KO NEW, SẼ NEW Ở TỪNG HÀM TRONG REPO
        public List<Book> GetBooks() {
            // _context = new BookManagementDbContext();
            _context = new();
            return _context.Books.ToList();
        }
        //hàm này sẽ cập nhật 1 cuốn sách có sẵn - edit, phải nhứo đến dbcontext như thường lệ
        //cuốn sách book đưa cho hàm này từ trên UI đẩy xuống Service rồi đẩy đến đây là Repo -> gọi dbcontext, tức là chỗ nào đó phải new Book() rồi đẩy vào đây
        public void UpdateBook(Book book)
        {
            _context = new();
            _context.Books.Update(book); //SQL: UPDATE BOOK SET BOOKNAME = ... .... WHERE  
                                         //     BOOKID = book.BookId

            _context.SaveChanges();      //run CÂU SQL
        }

        //HÀM NÀY CẦN NHẬN VÀO NEW BOOK... Ở ĐÂU ĐÓ CHẮC CHẮN ĐI TỪ UI MÀ ĐI XUỐNG SERVICE > REPO > DBContext
        public void AddBook(Book book)
        {
            _context = new();
            _context.Books.Add(book); //SQL: INSERT BOOK VALUES(BOOKID = book.BookId)
            _context.SaveChanges();      //run CÂU SQL
        }

        //lại 1 cuốn sách được new(...){} đâu đó và đưa xuống đây
        public void RemoveBook(Book book)
        {
            _context = new();
            _context.Books.Remove(book); //SQL: DELETE BOOK WHERE BOOKID = book.BookId
            _context.SaveChanges();      //run CÂU SQL
        }
    }
}
