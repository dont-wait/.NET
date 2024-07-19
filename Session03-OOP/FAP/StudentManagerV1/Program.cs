using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //đúc object, clone cái form, khuôn, class, template, fill info vào - nhiều việc cùng lúc: gọi new gọi phễu cóntructor kèm value vật liệu mực bút đổ vào
            //giống đưa hệ số cho phương trình bậc 2 để có 1 pt cụ thể
            Student        s1 =        new Student("SE1", "AN", 2004, 8.6);
            //data type    biến obj        obj tốn ram bự chà bá
            //                          public và private gì đó ở object
            //                  chấm để giao tiếp
            Console.WriteLine("SE1 shows profile");
            s1.ShowProfile();
            Student s2 = new Student("SE2", "BÌNH", 2004, 8.7);
            Console.WriteLine("s2 shows profile");
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s2); //gọi thầm tên em ToString() 

            //và nếu ko có ToString(), Java sẽ băm (hash/hasing) vùng new thành dãy hexa
            //C# nó sẽ làm biếng nó báo, vùng new này là vùng Student
            //muốn ko bị khó hiểu về kết quả, hay mún in toàn bộ info bên trong object đã đổ vào, in toàn bộ info của vùng new bạn nên chủ động tạo hàm ToString() và khi gọi hàm này ko cần .ToString(), C# và Java tự gọi giùm
            //khi dùng biến object ở các lệnh kiểu chuỗi cw(biến-object)
            
            Student s3 = new ("SE3", "CƯỜNG", 2004, 8.8);
            //KO CẦN new Student - cú pháp mới do đã có Student ở vế trái rồi
            Console.WriteLine("s3 shows profile");
            s3.ShowProfile();

            var s4 = new Student("SE4", "DŨNG", 2004, 8.9);
            //TYPE INFERENT - SUY LUẬN KIỂU - CÓ MANH MỐI CHO MÌNH SUY RA VÙNG NEW
            Console.WriteLine("s4 shows profile");
            s4.ShowProfile();

            //var s5 = new Student("EM", 2004, 9.0, "SE5");
            //Console.WriteLine(s5); //ERROR SAI KIỂU DATA TRUYỀN VÀO HÀM, HÀM YÊU CẦU TUÂN THỦ THỨ TỰ KHAI BÁO VÀ TRUYỀN

            //NHƯNG...
            Console.WriteLine("s5 shows profile");
            var s5 = new Student(name:"EM", yob: 2004, gpa: 9.0, id: "SE5");
            //name argument: dùng tên tham số để đảo thứ tự đầu vào theo ý thích
            Console.WriteLine(s5);

            Student s6 = s5;
            Console.WriteLine("s6 shows profile");
            Console.WriteLine(s6);
            //hàm chàng trỏ 1 nàng
            //void F(Student x)
            //{
            //      x thay đổi x. cái gì đó thì nơi gọi ngoài hàm bị thay đổi theo
            //}

            //F(s5) x thay đổi vùng ram vì đang trỏ cùng s5,
            //thì s5 bị thay đổi
            //BIẾN OBJECT LÀ TRUYỀN THAM CHIẾU, TRONG HÀM THAY ĐỔI VÙNG NEW NGOÀI HÀM THAY ĐỔI THEO MÀ KO CẦN REF VÀ OUT

        }
    }
}
