using System.Runtime.InteropServices;

namespace ActionDelegate
{
    //CHALLENGE #1 VIẾT HÀM IN RA CÂU THÔNG BÁO NAM EM ĐÃ RA VIỆN RỒI
    //             VIẾT THEO STYLE TRUYỀN THỐNG, NHỚ RUN HÀM

    //C#2: VIẾT HÀM IN RA CÂU THÔNG BÁO: NAM EM VÀ 35 TRIỆU!!!
    //               DÙNG DELEGATE & ANONYMOUS FUNCTION

    //C#3: VIẾT HÀM IN RA CÂU THÔNG BÁO: 8/3/2024: CHÚNG TA CỦA TƯƠNG LAI
    //                   DÙNG DELEGATE & LAMBDA
   
    //C#4: DÙNG LẠI HÀM CỦA C#1 KẾT HỢP VỚI DELEGATE
    
    //C#5: KO DÙNG DELEGATE DO TA TẠO RA, NOINPUTNOOUTPUTDELEGATE() ANY MORE
    //MICROSOFT, .NET SDK CUNG CẤP SẴN CHO TA 1 DELEGATE STYLE VOID F()
    //GỌI LÀ: Action, làm đi, hành động đi, run đi, vậy thôi, ko cần vào, ko cần ra
    //NẾU SAU NÀY BẠN CẦN LÀM VIỆC VỚI HÀM-KO-VÀO-KO-RA THÌ RA KO CẦN TẠO DELEGATE
    //MÀ XÀI LUÔN Action và chỉ việc khai báo biến = trỏ đến hàm nào là xong

    //C#5: VIẾT HÀM IN RA CÂU THÔNG BÁO "8/3/2K4: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs. THIỀU BẢO TRÂM


    delegate void NoInputNoOutputDelegate();
    //       void       F() style
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f1 = delegate () { };
            NoInputNoOutputDelegate f2 = () => { };
            Action f3 = () => { };

            Console.WriteLine("C#5: XÀI ACTION");
            Action f4 = ShowNotificationUsingExB;   //truyền thống hàm có sẵn ngoài kia
            f4();//Nam Em đã ra viện
            
            Action f5 = () =>
            { 
                Console.WriteLine("8/3/2K4: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs. THIỀU BẢO TRÂM"); 
            };

            Action f6 = () => Console.WriteLine("8/3/2K4: CHÚNG TA CỦA TƯƠNG LAI | SƠN TÙNG M-TP vs. THIỀU BẢO TRÂM");

            f6();
           
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("CHALLENGE #1 - CALL METHOD AS NORMAL");
        //    ShowNotificationUsingExB();


        //    Console.WriteLine("CHALLENGE #2 - CALL METHOD USING ANONYMOUS FUNCTION");
        //    NoInputNoOutputDelegate f1 = delegate () {
        //                                            Console.WriteLine("2/3/2024: NAM EM VÀ #35.000.000VND!!!\n");
        //                                            };  //VIP
        //    //RUN HÀM
        //    f1();

        //    Console.WriteLine("CHALLENGE #3 - CALL METHOD USING LAMBDA");

        //    NoInputNoOutputDelegate f2 = delegate ()
        //    {
        //        Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LẠI !!!");
        //    };//VIP

        //    NoInputNoOutputDelegate f3 = () => Console.WriteLine("8/3/2024: CHÚNG TA CỦA TƯƠNG LẠI !!!\n");
        //    f3.Invoke();

        //    Console.WriteLine("CHALLENGE #4 - CALL METHOD USING DELEGATE AND EXPLICIT METHOD");

        //    NoInputNoOutputDelegate f4 = ShowNotificationUsingExB; //gán = hàm có sẵn
        //                                                           //luật sư           thân chủ
        //    f4();
    

        static void ShowNotificationUsingExB() => Console.WriteLine("2/3/2024: NAM EM ĐẪ RA VIỆN!!!\n");
        //HÀM FULL TÊN, XÀI => ĐÍCH THỊ MÀY LÀ EXPRESSION BODY
        static void ShowNotification()
        {
            Console.WriteLine("2/3/2024: NAM EM ĐẪ RA VIỆN!!!");
        }
    }
}
