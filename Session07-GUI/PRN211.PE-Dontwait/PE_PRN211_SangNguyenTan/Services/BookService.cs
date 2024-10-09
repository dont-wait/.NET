using Repositories;
using Repositories.Entities;
using System.ComponentModel;

namespace Services
{
    //3-layer Architecture:
    //[1]                   [2]                         [3]                         SQL SERVER
    //UI-FORMs      ------ Services      ----------- Repositories --------------        DB
    //MainUI        ------ BookService               BookRepository (Book Entity)     Book Table
    //    request/response                  <------>
    //đưa data xuống DB                                 chơi trực tiếp với DB: lên, xuống 
    //lấy data từ DB show                                                      CRUD table thực sự
    //              RAM                                                 DB ĐĨA CỨNG HDD/SSD
    public class BookService
    {
        //CLASS này trung truyển dữ liệu giữa cái Forms UI và CSDL
        //chứa data trong ram và xử lí mọi thuật nếu cần rồi đẩy lên UI
        //hoặc cất xuống DB
        //chứa list các Book đọc từ DB và show lên UI
        //chứa info cuốn sách lấy từ bên màn hình UI dự định cập nhật xuống DB

        //THƯỜNG SẼ CHỨA CÁC HÀM CRUD NHƯNG CHỈ TRONG RAM - LINQ CÓ THỂ NHẢY VÀO

        //giả bộ đã đọc DB lên rồi, giờ show ra màn hình UI
        //tạm thời hard-code danh sách các cuốn sách trong RAM
        //bữa tới học cách lấy DB thực sự
        //lấy xog thì cx phải có n cuốn sách trong RAM


        //gọi Repo để lấy db
        //làm ẩu thì gọi hẳn db :))) -> Còn 2 lớp, KO LINH HOẠT KHI MUỐN THAY DB
        //LÀM 3-LAYER  THÌ SERVICE GỌI REPO, REPO GỌI DBCONTEXT
        //                                                 DBCONTEXT THÌ KẾT NỐI CSDL
        //nhờ ai giúp thì phải khai báo người đó
        private BookRepository _repo = new();
        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }
    }
}
