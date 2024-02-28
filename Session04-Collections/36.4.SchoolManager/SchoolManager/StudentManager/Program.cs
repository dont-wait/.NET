using StudentManager.Entities;
//Java: import studentmanager.entities.*;
namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayWithValueTypeArrayV2();
            PlayWithReferenceTypeArray();
        }

        //tui mún lưu trữ danh sách các SV - mỗi SV nào đó chính là 1 object đc tạo ra từ Khuôn Student!!!!!!!!
        //mỗi sv chính là new Student(gọi constructor có tham số đổ vào đây - param-constructor)
        //                new Student() {truyền value cho các prop Id = "SE1", Name = "An"}
        //                          object initializer
        //đừng quên mỗi SV tạo ra cho 1 tên gọi nhanh, gọi tắt, giống messi, r7, sếp, chiPu...
        //biến object = new ???() { };
        //muốn lưu nhiều SV, cần nhiều biến SV và nhiều new SV()
        static void PlayWithReferenceTypeArray()
        {
            //int yob = 2003;  //1 vùng ram vì single value, value-type
            //Student s1 = new Student();  //2 vùng ram nhen, vì value phức tạp
            //Student s2 = new Student() {...};  //object nhen
            //tên gọi/biến   và value

            //nhiều sv thì nhiều biến và nhiều new
            //chơi mảng, thì new mảng là 1 chuyện khác so với new Student()
            //new nào và new nào, tỉnh táo
            //new mảng SV hay new từng SV

            //30 biến cái đã - mảng - new [] chú ý ngoặc [] hay tròn ()
            
            Student[] arr = new Student[30];
            //có biến Student kiểu s1,    s2,     s3,     s4, s5, s6...
            //nay tương ứng      arr[0]  arr[1]  arr[2]  arr[3]
            //gán giá trị/lưu hồ sơ từng SV thì sao, thì gán = 
            //arr[0] = 5; 
            arr[0] = new Student();  //value phức tạp cần 2 vùng ram, nhưng vẫn ần biến for sure
            arr[1] = new Student() {Id = "SE10", Name = "An", Email = "an@...", Yob = 2000, Gpa = 10.0 };
            //Student s = new Student() {Id = ...}

            arr[2] = new Student() { Id = "SE50", Name = "Dung", Email = "dung@...", Yob = 2005, Gpa = 5.0 };

            arr[3] = new Student() { Id = "SE44", Name = "Binh", Email = "binh@...", Yob = 2004, Gpa = 4.4 };

            arr[4] = new Student() { Id = "SE88", Name = "Cuong", Email = "cuong@...", Yob = 1998, Gpa = 8.8 };

            Console.WriteLine("The student list");
            //for i hoặc for each okie luôn, chỉ cần nhớ mỗi phần tử mảng là biến thuộc loại nào!!!!!!!!!!!! int x for each hay Student x nếu for each trong mảng Student
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]); //gọi thầm tên em ToString()
            }

            foreach (Student x in arr)   //foreach (var x in arr)
            { 
                Console.WriteLine(x);  //Student x = arr[0], x = arr[1]... 
            }                          //cw(arr[i])  ~~~ cw(x) gọi thầm ToString() của sv x


            //FOR EACH CHƠI HẾT MẢNG, KHÔ MÁU VỚI MẢNG
            //FOR I ĐC QUYỀN FOR ĐẾN CHỖ NÀO MÌNH THÍCH
            //MẢNG THƯỜNG FOR ĐẾN CHỖ ĐANG CÓ, KO FOR HẾT TRỪ FI MẢNG FULL
            //MẢNG THƯỜNG NGƯỜI TA CÓ BIẾN COUNT ĐỂ BIẾT MẢNG ĐANG CÓ BAO NHIÊU PHẦN TỬ ĐC GÁN GIÁ TRỊ, BAO NHIÊU BIẾN ĐÃ ĐC GÁN VALUE!!!!!!!!!!!!

        }



        static void PlayWithValueTypeArrayV2()
        { //kĩ thuật khai báo mảng style thứ 2, vẫn cùng kết quả, vẫn xử lí như nhau, chỉ là khác cách gán giá trị
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50};  //new ngầm số phần tử mảng, số biến trong mảng == số value đc gán, bài này mảng [10]

            //int[] arr = { 5,     10,       15,     20,     25,     30, 35, 40, 45, 50 };
            //          arr[0]  arr[1]     arr[2] 
            //       int a = 5,  b = 10,   c = 15
            //gán giá trị ngay khi khai báo mảng
            //các biến lẻ trong mảng sẽ đc gán ngay value, biến-thứ-i[i] = value gì???

            //CÓ ƯU VÀ NHƯỢC CHO MỖI CÁCH KHAI BÁO!!!
            //IN MẢNG ĐI CÁI ĐÃ
            Console.WriteLine("The array is printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine(@"

The array is printed by using for each");
            foreach (int x in arr) //với mọi x thuộc tập N arr
            {
                Console.Write("{0} ", x); //x = arr[0] x = arr[1] với mọi mà
            }                             //cw(arr[i]) chính là cw(x)

            //Console.WriteLine("\n\n\n");
            Console.WriteLine(@"


"); //verbatim - raw string

            foreach (var x in arr) //với mọi x thuộc tập N arr, type inference
            {
                Console.Write("{0} ", x); //x = arr[0] x = arr[1] với mọi mà
            }

        }


            //Java cung cấp 2 loại kiểu dữ liệu/hình thái-hình dáng thể hiện của dữ liệu và cách nó đc lưu trong ram
            //1. PRIMITIVE DATA TYPE: TỐN 1 VÙNG RAM
            // int, long, float, double, char, boolean

            //2. OBJECT DATA TYPE, REFERENCE DATA TYPE, "POINTER"
            //                           TỐN 2 VÙNG RAM, 1 VÙNG TÊN GỌI/BIẾN]
            //                                 VÀ 1 VÙNG NEW, VÙNG OBJECT BỰ NHIỀU RAM
            //String, File, Exception, Random, Math, Dog, Cat, Person, Student...

            //C# GẦN GIỐNG 100%
            //1. VALUE TYPE (tốn 1 vùng ram ~ PRIMITIVE BÊN JAVA): 
            //int, long, float, double, char, bool

            //2. REFERENCE DATA TYPE, "POINTER"
            //                           TỐN 2 VÙNG RAM, 1 VÙNG TÊN GỌI/BIẾN]
            //                                 VÀ 1 VÙNG NEW, VÙNG OBJECT BỰ NHIỀU RAM
            //string, String, File, EXception, Random, Math, Dog, Cat, Person, Student
            static void PlayWithValueTypeArrayV1()
        {//bàn về biến/value mà tốn 1 vùng ram: int, long, float,..
            //hãy lưu giúp tôi 10 con số nguyên (1000 cx) của trò chơi 5 10
            //sau đó tính tổng của chúng
            //ANSWER 1: DÙNG KHAI BÁO BIẾN LẺ NHƯ TRUYỀN THỐNG
            int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, b = 30, c = 35, d = 40, e = 45, f = 50;

            //tính tổng
            int sum = a1 + a2 + a3 + a4 + a5 + b + c + d + e + f;
            //NẾU NHIỀU SỐ VỠ MẶT


            //ANSWER 2: DÙNG ARRAY
            //int[] arr = new int[10];
            //MẢNG LÀ KĨ THUẬT KHAI BÁO NHIỀU BIẾN CÙNG 1 LÚC NHƯNG
            //CÁC BIẾN PHẢI CÙNG KIỂU, CÙNG TÊN, Ở SÁT NHAU TRONG RAM, KHAI CÙNG 1 LÚC!!!

            //ĐỂ PHÂN BIỆT MỖI BIẾN TA DÙNG [INDEX SỐ THỨ TỰ CỦA MỖI BIẾN ĐẾM TỪ 0]
            int[] arr = new int[5000];
            //1O BIẾN LÀ:   arr[0]   arr[1]   arr[2]     arr[3]    arr[4]  arr[5]..
            //                a1         a2       a3         a4      a5      b
            arr[0] = 5; //~~~~ a1 = 5; ở trên khi khai báo lè. Mảng là khai báo sỉ
            arr[1] = 10;
            arr[2] = 15;
            arr[3] = 20;
            arr[4] = 25;
            arr[5] = 30;
            //[6], [7], [8], [9]  mình làm biếng gán
            //IN KẾT QUẢ XEM SAO
            Console.WriteLine("The array has values of");
            Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3] + " " + arr[4] + " " + arr[5] + " " + arr[6] + " " + arr[7] + " " + arr[8] + " " + arr[9]);
            //KO HIỆU QUẢ, CHẲNG KHÁC GÌ CHƠI LẺ STYLE TRUYỀN THỐNG

            //XÀI FOR, CÓ NHIỀU LOẠI FOR
            Console.WriteLine("The array is printed by using traditional for");
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(arr[i]);
                //Console.Write(arr[i] + " "); //ghép chuỗi truyền thống
                //Console.Write("{0} ", arr[i]);  //place holder
                Console.Write($"{arr[i]} ");
            }



            //ANSWER 3: DÙNG COLLECTION: ARRAYLIST, LIST, MAP, SET...




        }
    }
}
