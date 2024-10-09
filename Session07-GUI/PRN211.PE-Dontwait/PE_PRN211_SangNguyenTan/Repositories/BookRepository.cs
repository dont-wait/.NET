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
        private BookManagementDbContext _context; //trar ve db
        //KO NEW, SẼ NEW Ở TỪNG HÀM TRONG REPO
        public List<Book> GetBooks() {
            // _context = new BookManagementDbContext();
            _context = new();
            return _context.Books.ToList();
        }
    }
}
