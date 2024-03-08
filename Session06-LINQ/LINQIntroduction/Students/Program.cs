namespace Students
{
    //THÁCH THỨC DANH HÀI: TA CÓ DANH SÁCH SINH VIÊN
    //List<Student> arr = new List<Student> () {new Student(){"SE1", Name = "AN"},
    //                                          new Student() {},
    //                                          new Student(){}
    //                                         };
    //TA IN TOÀN BỘ SV, TA IN SV Ở TỈNH NÀY, TA IN SV CÓ GPA LỚN HƠN BẰNG 8
    //GPA >=8 BÌNH DƯƠNG
    //ĐƯA LAMBDA VÀO ARR.WHERE( s => {s.Id s.Gpa})
    //TAO LÀ HÀM .WHERE() CỦA LIST ARR, TAO CÓ RẤT NHIỀU SV TRONG TAY
    //TAO THẨY TỪNG SV TÊN LÀ S CHO HÀM CỦA MÀY ĐƯA VÀO. MÀY MÚN LÀM GÌ VỚI S THÌ LÀM
    //2 CƠ CHẾ XỬ LÍ: TAO LIST ĐƯA TỪNG ĐỨA, TỪNG OBJECT, CON SỐ CHO HÀM NGOÀI, BÊN NGOÀI LÀM
    //GÌ THÌ LÀM -> ACTION<>
    //              TAO LIST ĐƯA TỪNG ĐỨA CHO CHÚNG MÀY HÀM NGOÀI, HÀM NGOÀI BÁO TAO KU ĐÓ
    //              CÓ HỢP LỆ KO, TAO LIST KIỂM SOÁT TRỞ LẠI: SUM, COUNT, WHERE...

    //LINQ: Language Intergrated Query: KỸ THUẬT TRUY VẤN DATA TRONG RAM THEO 2 STYLE
    //HÀM LAMBDA - GỐC           -  METHOD SYNTAX
    //CÂU "SQL" VIẾT NGƯỢC       -  QUERY SYNTAX
    //MERGE
    //. XÀI CHUỖI . . . . . BẢN CHẤT LÀ TRẢ VỀ OBJECT CHẤM TIẾP ĐƯỢC
   
    //JAVA: STREAM API, ĐẦU VÀO CỦA HÀM TRAI BAO() SẼ LÀ 1 OBJECT XUẤT PHÁT TỪ INTERFACE
    //CHỈ CÓ DUY NHẤT 1 HÀM - INTERFACE CHỈ CHO PHÉP CÓ TỐI ĐA 1 HÀM ABSTRACT   
    //                        FUNCTIONAL INTERFACE
    //@Functional
    //public interface DeathRacer
    //lambda Java -> C# =>
    //LINQ ~ STREAM API (KO NHẦM LẪN VỚI I/O STREAM - TẬP TIN)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
