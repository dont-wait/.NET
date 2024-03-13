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
        public List<Book> GetAllBook()
        {
            //gọi Repositories, chính xác là gọi class BookRepositories trả về sách từ DB
            List<Book> _arr = new List<Book>();
            _arr.Add(new Book() { BookId = 1, BookName = "Đời Ngắn Đừng Ngủ Dài-Short Life Don’t Sleep Long"
                , Author = "Robin Sharma"
            });

            _arr.Add(new Book()
            {
                BookId = 2,
                BookName = "Tuổi Trẻ Đáng Giá Bao Nhiêu-How Much Is Youth Worth"
                ,
                Author = "Rosie Nguyễn"
            });

            _arr.Add(new Book()
            {
                BookId = 3,
                BookName = "Mình Là Nắng, Việc Của Mình Là Chói Chang-I Am the Sun, My Job Is to Shine Bright"
                ,
                Author = "Kazuko Watanabe"
            });

            //object initialization
            return _arr;
        }

    }
}
