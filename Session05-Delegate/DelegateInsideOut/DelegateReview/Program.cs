namespace DelegateReview
{

    //MỘT NAMESPACE, KO GIAN, THƯ MỤC TREN GIẤY TỜ ĐỂ NÓI VỀ HỘ KHẨU CỦA CÁ
    //CLASS, NƠI Ở, ĐỊNH CƯ CỦA CÁI CLASS. THƯỜNG MẶC ĐỊNH SẼ LẤY TÊN THƯ MỤC TREN                                                                                                                                                                                                                        
    //HDD/SSD ĐỂ NÓI VỀ HỘ KHẨU CỦA 1 CLASS - TÊN NAMESPACE - TÊN PACKAGE
    //MỘT NAMESPACE SẼ CHỨA NHIỀU CLASS ~ CÁI KHUÔN SẼ NẰM Ở ĐÂU TRONG XƯỞNG SẢN XUẤT
    //MỘT XƯỞNG CÓ NHIỀU KHUÔN - NAMESPACE CÓ NHIỀU CLASS
    //TA CÓ THỂ KHAI BÁO CÁC CLASS RIÊNG RẼ, MIỄN LÀ PHẦN ĐẦU TIÊN RẰNG NÓ THUỘC VỀ KO GIAN NÀO
    //HỘ KHẨU NÀO, NAMESPACE NÀO
    //ĐẦU TẬP TIN SOURCE CODE SẼ CHỨA CÁI KHAI BÁO NAMESPACE ĐỂ QUẢN LÍ CÁC CLASS 
    //THUỘC VỀ NÓ

    //TRONG 1 TẬP TIN SOURCE, TA CÓ THỂ KHAI BÁO CÁC CLAS KHÁC NGOÀI CLASS DEAFAULT CÓ SẴN KHI TẠO 1 TẬP TIN

    public class Lecturer
    {

    }

    public class Student
    {
        //là 1 cái Khuôn có nhiều khaongr trống bên trong để đổ vào các info của 1
        //object cần đúc, cần lưu trữ

    }
    //Student       s                   = new Student(...) {...};
    //data-type     biến/nick-name                      object, value
    //              tên gọi cho 1                       phức tạp

    //delegate là kĩ thuật thiết kế 1 cái class đặc biệt
    //class này ko lưu info của các object theo style truyền thống; mà nó đi lưu
    //thông tin là: TÊN CỦA CÁC HÀM TỒN TẠI ĐÂU ĐÓ NGOÀI KIA
    // public class X [void x()] : Delegate
    //{
    //biến lưu 1 tên hàm, hay nhiều tên hàm
    //_list-tên-của-các-hàm-cần-lưu-trỏ-đến

    //    public X(đưa-vào-tên-hàm-cần-lưu) {.... }
    //public void Invoke() dùng để duyệt qua danh sách các hàm đang có và run()
    //                                hàm lun
    //{

    //}
    ////xài class đặc biệt này:
    ////x             f = new X(đưa-hàm-nào-đó-vào-đây);
    ////Student       biến        value - là tên hàm nào đó


    ////CHO PHÉP VIẾT NGẮN GỌN CÚ PHÁP KHAI BÁO CLASS LƯU TRỮ TÊN HÀM

    //}
    //delegate void X();  //tui X đại diện cho 1 loạt các hàm có cùng style void F()

    //MỘT NAMSPACE SẼ CHỨA 3 THẰNG NGANG CƠ NHAU - CÙNG LEVEL
    //1. CLASS TRUYỀN THỐNG STUDENT, PERSON, DOG, CAT,...
    //2. INTERFACE - DẠNG CLASS ĐẶC BIỆT (CHỨA HÀM ABSTRACT KO CÓ COT)
    //3. DELEGATE - DẠNG CLASS ĐẶC BIỆT (CHỨA BÊN TRONG TÊN HÀM)

    //CHALLENGE: LÀM VIỆC VỚI HÀM CÓ STYLE VOID F() - DÙNG CLASS DELEGATE

    public delegate void NoInputNoOutputDelegate(); //đại diện cho style void F()
                                                    //public class NoInputNoOutputDelegate 
                                                    //{
                                                    //...
                                                    //}
    //XÀI CLASS TRONG CLASS KHÁC VÌ CLASS LÀ DATA TYPE
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f1 = new NoInputNoOutputDelegate(TellHerMessage1);
            //                      f là tên gọi khác, nick-name, 2nd name
            //                      của hàm gốc có tên là TellHerMessage1
            //có thể hình dung: muốn chơi với hàm TellHerMessage1; ta có dùng cái tên thay
            //thế là f
            //      LUẬT SƯ =       THÂN CHỦ
            //HÃY NÓI CHUYỆN VỚI F CŨNG CHÍNH LÀ NÓI CHUYỆN VỚI TELLHERMESSAGE1
            //1 HÀM CÓ 2 TÊN 
            //CUỐI GIỜ: BÁN 1 TÊN CHO QUỶ DỮ!!! CHỈ CÒN LẠI 1 TÊN, NHƯNG KO LÀ TÊN GỐC

            NoInputNoOutputDelegate f2 = TellHerMessage2;   //new ngầm
            //gọi 2 hàm thử coi
            //thay vì gọi trực tiếp, làm việc trực tiếp với tên góc của hàm
            //ta làm việc qua nick name, 2nd name,luật sư
            //f2 = TellHerMessage2          thì f2() = TellHerMessage2();
            //bằng nhau về tên gọi
            Console.WriteLine("See messages 1st time...");

            f1();
            f2.Invoke();    //tương đương nhau, vào trong vùng new để lôi các tên hàm gốc
                            //ra và run();
                            //luật sư nói là thân chủ nói, nickname run() hàm gốc run

            //Program app = new Program();
            //app.TellHerMessage3();
            Console.WriteLine("See message 2nd");
            f1();
            f2 = new Program().TellHerMessage3;
            f2.Invoke();    //f2()

            Console.WriteLine("See message 3rd");
            f1 += new Program().TellHerMessage3;    //cộng dồn a = 5; a+= 5 => a = 10
            f1();   // 1 3
            f2();   // 3
            //1 LUẬT SƯ ĐẠI DIỆN CHO NHIỀU THÂN CHỦ
            //1 TÊN ĐẠI DIỆN CHO NHIỀU TÊN HÀM GỐC
            //MULTICAST DELEGATE

        }

        static void TellHerMessage1()
        {
            Console.WriteLine("1. Cuộc sống em ổn không?");
                                
        }
            
        static void TellHerMessage2() => Console.WriteLine("2. Xa anh em phải hạnh phúc");
        //EXPRESSION BODY: HÀM CHỈ CÓ 1 LỆNH; DẸP LUN RETURN NẾU CÓ
        //                 DÙNG => ĐỂ TÁCH TÊN HÀM VÀ THÂN HÀM (BODY OF FUNCTION)
        //                 NHƯNG HÀM PHẢI VẪN CÒN ĐẦY ĐỦ TÊN HỌ
        //VÌ NÓ RẤT GIỐNG BIỂU THỨC LAMBDA EXPRESSION, NHƯNG LÀ CÂU CHUYỆN HOÀN TOÀN KHÁC

        public void TellHerMessage3() => Console.WriteLine("3. Giữa Mai và Đào anh chỉ được chọn eM");



    }
}
