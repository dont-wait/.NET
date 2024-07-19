using System;
using System.Collections.Generic;
using System.Linq;  //StreamAPI bên Java (Lambda Expression)
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    public class Student
    {
        private string _id; //đặc điểm, field, state, biến db nằm ngoài hàm, nhưng trong clas, của 1 object theo quy tắc: con Lạc Đà, và _ từ đầu tiên
        private string _name; //___________
        private int _yob;     //___________
        private double _gpa;  //___________

        //lấy cây bút điền info vào form khi mình new, clone, xin 1 cái form để lưu info, khi mình cần lưu info của 1 sv mới bắt kì
        //nói theo cái khuôn đúc, thì nó chính là cái phễu hứng bật liệu đổ vào trong Khuôn
        //HÀM CONSTRUCT[OR]
        public Student(string id, string name, int yob, double gpa) 
        {
            this._id = id; //thừa this. ko sai
            _name = name;
            _yob = yob;
            _gpa = gpa;
        
        }
        //LẬP TRÌNH CLASS/OOP CHÍNH LÀ LẬP TRÌNH CÁC XỬ LÍ TRÊN CÁC BIẾN 1 CÁCH CHUNG CHUNG NHẤT, LATS HỎI ĐỔ INFO VÀO SẼ CÓ GIÁ TRỊ CỤ THỂ
        //Y CHANG NHƯ GIẢI PHƯƠNG TRÌNH BẬC 2 AX^2 + BX + C = 0
        //                              DELTA = B^2 -4AC
        //                              DELETA > 0, X1 = ..., X2=...
        //MAI MỐT ĐƯA INFO CỤ THỂ VÀO, THÌ CÓ INFO CỤ THỂ TRẢ VỀ SAU XỬ LÍ
        //ĐƯA A B C VÀO THÌ CÓ X1 X2
        //ĐƯA ID, YOB, NAME, GPA, CÓ CÁI GÌ ĐÓ TRẢ VỀ CỤ THỂ: TUỔI = 2024 - YOB
        //               CURRENT YEAR - YOB
        //CÁC HÀM XỬ LÍ INFO RA VÔ OBJECT, Y CHANG MÌNH GIAO TIẾP BÊN NGOÀI ĐỜI
        //HÀM HỎI - HỎI NHAU CÂU CHUYỆN - GET() GETTER()
        public string GetName()
        {
            return _name;
        }

        public int GetYob() 
        {
            return _yob;
        }

        public double GetGpa() => _gpa; //expression body/bodied

        //HÀM THAY ĐỔI - THẤY THẰNG BẠN CÓ GÌ, MÌNH VỀ BẮT CHƯỚC CHỈNH SỬA MÌNH - SET() SETTING
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetYob(int yob)
        {
            _yob = yob;
        }

        public void SetGpa(double gpa) => _gpa = gpa;
        
        //HÀM FLEX NHIỀU INFO HƠN, THAY VÌ LẺ TỪNG MIẾNG INFO GET LẺ()
        //Y CHANG MỖI CÁ NHÂN CÓ 1 CÁI PROFILE TRÊN MXH: FB, TIKTOK, LINKED IN

        public void ShowProfile()
        {
            //show theo style FB
            Console.WriteLine("My profile");
            Console.WriteLine("ID: " + _id); //concatenation
            Console.WriteLine("Name: {0}", _name); //format
            Console.WriteLine($"Yob: {_yob}");//interpolation
            Console.WriteLine(@$"Gpa: {_gpa}");   //verbatim
                                                  //dư @ vì mình ko in gì đặc biệt
        }

        //hành động chuẩn hoá của mọi object, như hành động đem theo CMND, CCCD khi đc hỏi show ra cho việc kiểm tra hành chính
        //với lập trình object show hết info thân nhân gọi là ToString() toString()
        //HÀM JAVA: verb + Object theo con Lạc Đà()
        //HÀM C#  : verb + Object theo Pascal

        //@OVerride
        //public override string ToString()
        //{
        //    string msg = $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
        //    return msg;
        //}
        public override string ToString() =>  $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
        
    }
    //Class là 1 tên gọi chung, 1 danh từ chung, là tên gọi cho sự phân nhóm
    //, phân loại/classify 1 đám object có điểm tương đồng: về đặc điểm
    //        và hành vi
    //An Bình Cường Dũng... -> share chung nhiều đặc điểm hành vi
    // - Đặc điểm: id, name, yob, place of birth, address, major, gpa...
    // - Hành vi: DoQuiz() DoFinalExa,() DoPresntation() ChatInClass()
    //PlayGameInClasas()
    // Các bạn A B C D thuộc nhóm Student

    //Class ~ Khuôn đúc - Mold, Template, Blue-print(bản thiết kế), Form
    // - biểu mãu nhập
    // chỉ cần chờ đổ info vào nữa là ra 1 cái gì đó cụ thể - OBJECT
    //LÀM CÁI FORM/CLASS STUDENT - NHÓM SV ĐC LỢI ÍCH GÌ???
    //KHI CÓ 1 SV MỚI ĐĂNG KÍ NHẬP HỌC, TA CHỈ CẦN CLONE (NEW) TẠO FORM
    //TRỐNG CHO NGƯỜI ĐÓ, ĐỔ INFO VÀO VÀ TA ĐÃ LƯU TRỮ ĐC INFO CỦA 1 OBJECT
    //NGƯỜI KHÁC ĐẾN -> NEW, CLONE FORM, FILL INFO -> OBJECT KHÁC ĐÃ ĐC LƯU

    //RÕ RÀNG CLASS LÀ KHUÔN GIÚP ĐÚC/CLONE/NEW ĐC NHIỀU OBJECT 1 CÁCH HIỆU QUẢ
    //LẬP TRÌNH OOP - OBJECT ORIENTED PROGRAMMING/PARADIGM
    //LỐI TƯ DUY VỀ CÁCH LƯU TRỮ, QUẢN LÍ NHIỀU THÔNG TIN QUANH TA QUA NHẬN DIỆN OBJECT
    //OBJECT, OBJECT, OBEJECT ...-> CLASS X
    // -> TÌM RA CLASS -> CLONE OBJECT MỚI TRỞ LẠI

    //OBJECT, OBJECT, OBEJECT ...-> CLASS X
    //OBJECT, OBJECT, OBEJECT ...-> CLASS Y

    //CLASS -> NEW OBJECT

    //TỪ X, Y CLONE TRỞ LẠI CÁC OBJECT KHÁC TƯƠNG ĐƯƠNG NEW, LƯU TRỮ INFO
    //CỦA CÁC OBJECT KHÁC PHÁT SINH TRONG TƯƠNG LAI
    //VỚI 1 TRƯỜNG HỌC, NEW HOÀI STUDENT()
    //VỚI 1 CÔNG TY BÁN HÀNG, NEW HOÀI ORDER() PAYMENT()
    //VỚI 1 CTY QUẢN LÍ TOUR DU LỊCH, NEW HOÀI TOUR() NEW HOÀI ORDER() NEW 
    //HOÀI SERVICE()
    //VỚI 1 BỆNH NHÂN, NEW HOÀI BỆNH NHÂN() NEW HOÀI ĐƠN THUỐC, LÂU LÂU NEW
    //DRUG() THUỐC MỚI ĐI ĐIỀU TRỊ BỆNH

    //1 OBJECT Ở TRÊN SẼ NHÌN THEO 2 KHÍA CẠNH
    //1. ĐẶC ĐIỂM (TĨNH - STATE)
    //      id, name, yob, gpa...
    //2. HÀNH VI (ĐỘNG - BEHAVIOUR)
    //      DoPresentation()
    //      ComputeBill() {voucher, * / + - sản phẩm số lượng đơn giá}

    //2 THÔNG TIN TRÊN ĐC GỌI CHUNG LÀ MEMBERS OF AN OBJECT, MEMBERS OF CLASS

    //*************************
    //THIẾT KẾ OOP:
    //1. NHẬN DIỆN RA CÁC OBJECT, VÍ DỤ 30 BẠN QUANH TUI, VÀ 1 MÌNH TUI
    //2. CHIA NHÓM OBJECT, TÌM NHÓM OBJECT - TÌM CLASS, THEO ĐẶC ĐIỂM CHUNG, THEO HÀNH ĐỘNG CHUNG
    //                NHÓM STUDENT, NHÓM LECTURER
    //3. TẠO DỤNG DÀN KHUNG CHO CLASS, CÁI FORM VỚI NHỮNG CHỖ TRỐNG ĐỂ ĐIỀN VÀO SAU NÀY
    //                               ID:_______
    //                               Name:_______
    //                               Yob:_______
    //                               Major:_______
    //                               Gpa:_______
    //                       PlayGame() -> rank
    //4. CHUẨN BỊ VIỆC NHẬN INFO VÀO, ĐIỀN INFO VÀO FORM ĐỂ CÓ ĐC OBJECT 
    //  NGOÀI ĐỜI CHÍNH LÀ XIN FORM, LẤY BÚT ĐIỀN VÔ
    //  TRONG CODE, ĐIỀN FORM CHÍNH LÀ FILL VÀO CAC FIELD TRONG CLASS 
    //  HÀNH ĐỘNG TRONG CODE CHÍNH LÀ HÀM - HÀM TẠO RA CÁI FORM ĐIỀN INFO ĐỂ RA OBJECT
    //  HÀM NÀY GIÚP TẠO RA OBJECT - GIỐNG LẤY BÚT ĐIỀN
    //               CONSTRUCT(VERB)
    //  HÀM NÀY SẼ GỌI LÀ CONSTRUCTOR() GIỐNG NHƯ CÂY BÚT BẮT ĐẦU ĐIỀN FORM
    //5. OBJECT XONG, ĐIỀN BÚT VÀO Ô TRỐNG XONG,
    //NGÓ LẠI, XEM ỔN KO:               -> NHÌN THẤY ĐÃ ĐIỀN GÌ, GET()
    //                                  -> SỬA, ĐƯA LẠI INFO VÀO SET() THAY ĐỔI
    //CÓ SAI 1 TÍ THÌ LẤY GÔM CHỈNH
    //6.  FLEX CÁI FORM CHO AI ĐÓ CẦN, FLEX HẾT MÌNH CÓ, XEM HẾT (GẦN HẾT INFO)
    // SHOWPROFILE()
    // TOSTRING()
    //>>>>>>>>>>>> 6 BƯỚC TRÊN GIÚP BẠN TẠO DỰNG RA ĐC CÁCH ĐỂ LƯU TRỮ INFO CỦA CÁC OBJECT QUANH TA
    //THÔNG QUA MÁY TÍNH, GIỐNG NGOÀI ĐỜI, LƯU TRỮ 1 ĐỐNG FORM ĐÃ ĐIỀN
    
    //7. ĐÚC OBJECT TRỞ LẠI TỪ CÁI KHUÔN, CÁI FORM
    //   - CLONE CÁI FORM TRƯỚC ĐÃ, ĐI PHOTO CÁI FORM, NEW CÁI FORM, MƯỢN CÁI KHUÔN
    //   - ĐỔ VẬT LIỆU VÀO CÁI FORM ĐÃ NEW, ĐỔ VÀO CÁI PHỄU, ĐỔ MỰC VÀO FORM
    //      GỌI HÀM CONSTRUCTO, ĐƯA VALUE, ĐƯA VẬT LIỆU, MỰC VÀO KHUÔN, PHỄU, FORM
    //    CÓ ĐC OBJECT
    //  ĐẶT TÊN CHO OBJECT CHO DỄ GỌI
    // MÌNH LÀ PERSON DO BA MÁ ĐÚC RA, NEW RA, BẤM GỌI MÌNH LÀ TÈO TÍ

    //PERSON TÈO = NEW PERSON(...)
    //STUDENT TÍ = NEW STUDENT(...)
    
    //CÓ TÈO CÓ TÍ, CÓ OBJECT GIAO TIẾP HOY QUA GET() SET() HAY FLEX PROFILE()
    //TOÀN BỘ CÁC OBJECT TUÂN THEO THIẾT KẾ CỦA CLASS CÁI NHÓM MÀ OBJECT THUỘC VỀ
    //TÈO. TÍ. XỔ RA CÁC HÀNH ĐỘNG THEO ĐÚNG NHÓM ĐÃ THUỘC VỀ
    
    //TÍ. GETGPA() SV CÓ ĐIỂM, FLEX ĐIỂM...
    //TOÈ. SHOWPROFILE() MỖI CÁ NHÂN FLEX GÌ ĐÓ TRÊN

    //LẬP TRÌNH OOP: CLONE OBJECT HÀNG LOẠT, LẬP TRÌNH TRÊN TEMPLATE CHO 1 NHÓM OBJECT

}
