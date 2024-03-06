using System.Threading.Channels;

namespace PassByDelegateV3
{
    //C#5: IN RA LỜI CỦA 2 BÀI HÁT THÔNG QUA TRUYỀN HÀM IN BÀI HÁT VÀO 1 HÀM 
    //IN TẬP TRUNG;
    //HÀM CHỊU TRÁCH NHIỆM THẦU/MỘT HUB TRUNG TÂM CÁC LỆNH IN KHÁC NHAU!!!
    //NHẬN CÁC LỆNH IN KHÁC NHAU ĐC ĐƯA VÀO!!!


    internal class Program
    {
        static void Main(string[] args)
        {


            PrintSongLyricsThe1();  //() gọi hàm run đi
            PrintSongLyricsLover(); //tên hàm 1 mình ên -> luật sư = thân chủ
                                    //em ủy quyền anh, anh gọi là em gọi đó

            Console.WriteLine("C#5: CALL 2 EXPLICIT METHODS VIA DELEGATE VAR");
            Action f = PrintSongLyricsLover;    //luật sự = than chủ
            f += PrintSongLyricsThe1;           //luật su = 2 thân chủ
            //  BIẾN  = VALUE   là tên hàm!!!
            //int x   = value
            f.Invoke(); //2 thân chủ cùng đc nói qua miệng của f, run()

            Console.WriteLine("\n\nC#5: CALL 2 EXPLICIT METHODS AS TRADITIONAL\n");
            PrintOnDemand();    //RUN HÀM CHÍNH ONDEMAND() THÌ 2 HÀM CON BÊN TRONG ĐC
                                //RUN();


            Console.WriteLine("\n\nC#5: PRINT ON DEMAND - DEPENDENCY INJECTION STYLE\n");
            //PrintOnDemand(Action f = tên hàm nào đó, nhiều hàm có sẵn)
            //PrintOnDemand(Action f = một biến f đc trỏ sãn tên hàm);
            //PrintOnDemand(Action f = anonymous function)
            //PrintOnDemand(Action f = lambda expression)
            //PrintOnDemand(Action f = () => {});
            //PrintOnDemand(Action f = delegate () {});
            //HÀM NGOÀI ĐC TRUYỀN VÀO HÀM CHÍNH POD()
            //1 LOGIC XỬ LÍ BÊN NGOÀI ĐC PASS VÀO BÊN TRONG HÀM CHÍNH POD(???)
            //DEPENDENCY INJECTION
            //HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGÃ THAM SỐ => LẬP TRÌNH HÀM - FUNCTIONAL
            //PROGRAMMING
            //HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGÃ THAM SỐ => HÀM CHÍNH LÀM GÌ THÌ LÀM ĐI
            //                              NHỚ GỌI HÀM QUA NGÃ THAM SỐ SAU KHI CHÁN CHÊ
            //CALL BACK FUNCTION

            //JAVA: CÓ LAMBDA EX
            //      TRUYỀN HÀM VÀO HÀM PHẢI BAO CÁI HÀM LẠI TRONG 1 INTERFACE CHỈ CÓ 
            //DUY NHẤT 1 HÀM - INTERFACE CHỈ CÓ DUY NHẤT 1 HẦM GỌI LÀ @Functional Interface
            //             DÙNG KÈM KĨ THUẬT ANONYMOUS CLASS

            //ĐỪNG NHẦM LẪN PASS HÀM VÀO HÀM VỚI PASS 1 OBJECT STUDENT S VÀO 1 HÀM
            //PrintOnDemand(Student s) pass by refference, truyền tham chiếu, truyền nhiều hàm của OBJECT
            //KO TRUYỀN HÀM ĐƠN NHƯ MÌNH ĐANG HỌC!!! KO LAMBDA VÀ DELEGATE GÌ CẢ
            //KO CALLBACK GÌ CẢ

            Action fxxx = PrintSongLyricsThe1;
            fxxx += PrintSongLyricsLover;
            fxxx += PrintSongLyricsAugust;

            //GỌI HÀM CHÍNH, DEPENDENCY INJECTION - TAO CHÍCH VÀO HÀM CHÍNH 3 CÁI HÀM KHÁC 

            PrintOnDemand(fxxx);    //3 HÀM CHẠY NHƯ LÚC HARD-CODE

            //C#6: TUI MÚN IN BÀI HÁT TIẾP THEO CỦA TAYLOR: CAROLINA
            //CHƠI QUA IN DỊCH VỤ:
            //PrintOnDemand(delegate () { });
            //PrintOnDemand(() => { });

            //nguyên lí dấu =
            Console.WriteLine("\n\nC#5: PRINT ON DEMAND - DI USING DELEGATE & LAMBDA EX STYLE\n");
            PrintOnDemand(delegate ()
                {
                    Console.WriteLine("The song Carolina - by Tailor Swift");

                }
            );
            PrintOnDemand(() => Console.WriteLine("8.3 CHÚNG TA CỦA TƯƠNG LAI"));
            //HÀM NÀO NHẬN VÀO DELEGATE, THÌ HÀM NÀY KHI RUN, RUN LUN HÀM DELEGATE BÊN TRONG CALLBACK
            //GỌI 1 NHƯNG CẢ 2 HÀM CÙNG RUN, HÀM CHÍNH TRAI BAO CHẠY TRC RỒI MS TỚI LƯỢT

            //C#6 HÃY IN RA CÁC SỐ TỪ 1..100

            //ĐỀU LÀ HÀM ACTION F
            Console.WriteLine("C#7: HÀM KLQ");  //NHƯNG ỔN, VÌ CHỈ LÀ VOID F() THÔI MÀ
            //ĐƯA HÀM ĐÂY, TAO GỌI THEO NHU CẦU ACTION CỦA MÀY

            //CLASS CÓ HÀM NHẬN DELEGATE BÊN NGOÀI ĐƯA VÀO, XÀI DI, CLASS LINH HOẠT VỚI CÁC XỬ LÍ
            //MÀ ĂN THEO NHU CẦU BÊN NGOÀI. TÁC GIẢ CỦA HÀM KHỎI MẤT CÔNG SUY NGHĨ
            //NHIỀU VỀ NÊN CUNG CẤP MÓN GÌ, AI MÚN GÌ ĐAUW VÀO TUI HÀM CHÍNH PHỤC VỤ

            //DELEGATE VÀ EVENT LÀ TRI KỈ!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //LOOSE COUPLING, DI
            PrintOnDemand(() =>
            {
                Console.WriteLine("The list of numbers from 1...1000");
                for (int i = 1; i <= 1000; i++)
                {
                    //Console.Write(i + " ");
                    Console.Write($"{i} ");
                    //Console.Write("{0} ", i);
                }
                Console.WriteLine();    //sống có trách nhiệm, in dàn ngang dãy số xong thì phải xuống tránh ảnh hưởng
                //in sau đó con nháy ngang bài cũ hàm cũ
            }
            );  //truyền thái y ĐƯA VÀO BÊN TRONG HÀM TRAI BAO POD() VÀ RUN POD()
                // KHI RUN HÀM POD() PHẢI TRUYỀN GIÁ TRỊ - HÀM CALLBACK KHÁC
                //GIỐNG NHƯ KHI RUN HÀM MATH.SQRT(ĐƯA 25)
                //ĐƯA STYLE TRUYỀN HÀM VÀO HƠI MẤT SỨC GÕ CODE 1 TÍ
                //KO MÚN MẤT SỨC TẠO SẴN HÀM LẺ, TRUYỀN TÊN VÀO
                //MÌNH THÍCH ANONYMOUS VÀ LAMBDA VÌ NÓ LINH HOẠT, CẦN THÌ MỚI TẠO HÀM NGAY TẠI CHỖ CẦN
                //-> MỘT PHẦN CỦA LOGIC XỬ LÍ EVENT TRONG LẬP TRÌNH GUI!!!

            //C#7 HÃY IN RA CÁC SỐ NGUYÊN TỐ TÙ 1...1000
            PrintOnDemand(() =>
            {
                int count = 0;
                Console.WriteLine("The list of Prime numbers from 1...1000");
                for (int i = 0; count < 1000; i++)
                    if (isPrime(i))
                    {
                        Console.Write($"{i} ");
                        count++;

                    }
            }
            );
        }
        static Boolean isPrime(int n)
        {
            if (n < 2)
         
                return false;
            
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //em phục vụ in ấn theo nhu cầu của các bác
        //các bác muốn in thế nào, nói em, đưa cho em em in cho 
        static void PrintOnDemand() //HÀM CHÍNH RUN
        {
            Console.WriteLine("The main-method code...code...");
            Console.WriteLine("The main-method code...code...");

            Console.WriteLine("Call 2 sub-methods to print");
            PrintSongLyricsThe1();  //2 HÀM CON ĐC RUN
            PrintSongLyricsLover();
            PrintSongLyricsAugust();    //sửa hàm ở phút cuối
            //TIGHT COUPLING - HÀM CHÍNH PrintOnDemand() phụ thuộc vào 3 hàm
            //hard-code luôn. SAU NÀY MUỐN IN BÀI KHÁC, 1 BÀI KHÁC THÌ PHẢI SỬA
            //CODE TRỰC TIẾP
            //CÓ CÁCH HAY HƠN: IN GÌ THÌ ĐƯA VÀO, TRONG HÀM CHÍNH PrintOnDemand
            //CHỈ CÓ LỆNH IN ĐÚNG CÁI ĐƯA VÀO, ĐƯA VÀO GÌ IN CÁI ĐSO, KO HARD-CODE
            //GÌ CẢ -> LOOSE COUPLING - RÀNG BUỘC LỎNG LẺO, FLEXIBLE, ADAPTIVE VỚI
            //BÊN NGOÀI ĐƯA VÔ THAY VÌ MÌNH GÁN CỨNG VỚI THỨ ĐÃ LÀM SẴN
            //TUI - PRINTONDEMAND() KO GẮN HARD-CODE TÊN HÀM NÀO CẢ, MUỐN LÀM GÌ
            //THÌ ĐƯA TÊN HÀM BÊN NGOÀI VÀO ĐÂY, TAO IN CHO, TAO GỌI CHO
            //TƯ DUY NÀY LÀ TƯ DUY STYLE: KIẾN TRÚC SƯ PHẦN MỀM - SOLUTION ARCHITECT - SA
            //                              LƯƠNG ĐỘ PHÂN GIẢI 4K TRỞ LÊN Ở VN
        }
        //static void PrintOnDemand(int X) //XÀI: POD(100) POD(68)
        static void PrintOnDemand(Action f)//HIỆN TƯỢNG OVERLOAD
            //                   Action f = 1 hàm nào đó;
        {
            Console.WriteLine("The main-method code...code...");
            Console.WriteLine("The main-method code...code...");

            Console.WriteLine("Call any outside method passed into...");
            Console.WriteLine("For now i'm flexible to rêcive your request");
            Console.WriteLine("Tell me, what do you want, I call it/do it fo you...");
            f();    //RUN BẤT KÌ HÀM NÀO ĐƯA VÀO QUA NGÃ THAM SỐ!!!
            //GIỐNG RUN() 3 HÀM CŨ HARD-CODE Ở DƯỚI
            //NAY ĐƯA TÊN HÀM MÚN RUN QUA NGÃ THAM SỐ
            //ĐƯA TỪNG THÀNG Ở DUÓI QUA NGÃ THAM SỐ, 3 HÀM VẪN ĐC RUN NHƯ CŨ!!!
            //NHƯNG NAY CÒN RUN ĐC HÀM BẤT KÌ MIỄN LÀ GỦI QUA THAM SỐ ACTION ĐÚNG STYLE HÀM
            //LOUSE COUPLING
            //DEPENDENCY INJECTION: CHÍCH VÀO CHO EM 1 HÀM KHÁC BÊN NGOÀI QUA NGÃ THAM SỐ
            //CHÍCH/PASS HÀM NÀO, RUN HÀM ĐÓ


            //PrintSongLyricsThe1();  //3 HÀM HARD-CODE, TIGHT-COUPLING
            //PrintSongLyricsLover();
            //PrintSongLyricsAugust();  //GỌI CHUNG NÓ LÀ CHỮ F TỪ BÊN TRÊN ĐƯA VÀO
        }
        public static void PrintSongLyricsAugust()
        {
            Console.WriteLine("The song August - by Tailor Swift");
            Console.WriteLine();

        }
        public static void PrintSongLyricsThe1()
        {
            Console.WriteLine("The song The 1 - by Tailor Swift");
            Console.WriteLine();
           
        }

        public static void PrintSongLyricsLover()
        {
            Console.WriteLine("The song Lover - by Tailor Swift");
            Console.WriteLine();
          
        }
    }
}
