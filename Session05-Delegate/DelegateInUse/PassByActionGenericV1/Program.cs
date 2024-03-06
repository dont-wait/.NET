using System.Threading.Channels;

namespace PassByActionGenericV1
{
    //CHALLENGE #1: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐSO NẾU ĐÓ LÀ SỐ CHẴN
    //              VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐSO NẾU ĐÓ LÀ SỐ LẺ
    //CHALLENGE #1: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐSO NẾU ĐÓ >=50
    //CHALLENGE #1: VIẾT HÀM NHẬN VÀO 1 CON SỐ, IN RA CON SỐ ĐSO NẾU NÓ LÀ SỐ NGUYÊN TỐ

                 
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //gọi lẻ 4 hàm là style truyền thống, ko thèm nói
        //    PrintEvenNumber(5); //ko in
        //    PrintOddNumber(5);  //in 5
        //    PrintPrimeNumber(5);    //in 5
        //    PrintNumberGtEq50(5);   //ko in
        //    Console.WriteLine("Round 2");
        //    PrintEvenNumber(10); //10
        //    PrintOddNumber(11);  //11
        //    PrintPrimeNumber(13);    //13
        //    PrintNumberGtEq50(50);  //50
        //}

        //làm hầm style thầu dịch vụ
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Print even numbers from 5 10 15 20");
        //    PrintOnDemand(PrintEvenNumber); //in chẵn tù dãy 5 10 15 20

        //    Console.WriteLine("Print odd numbers from 5 10 15 20");
        //    PrintOnDemand(PrintOddNumber);

        //    Console.WriteLine("Print prime numbers from 5 10 15 20");
        //    PrintOnDemand(PrintPrimeNumber);

        //    Console.WriteLine("Print >=50 numbers from 5 10 15 20");
        //    PrintOnDemand(PrintNumberGtEq50);
        //    //NOTHING

        //    //C#2: THÁCH THỨC DANH HÀI: IN RA CÁC SỐ CHIA HẾT CHO 5
        //    //c#3: CÓ SỐ NÀO IN SỐ NÁY, IN HẾT
        //    Console.WriteLine("Print divisable by 5 number");

        //    PrintOnDemand(xxx => 
        //        {
        //            //có (int xxx) làm gì tiếp - làm như hàm bth ở dưới
        //            if(xxx % 5 == 0)
        //                Console.WriteLine(xxx);
        //        }
        //    );

        //    Console.WriteLine("Print ALL 5 10 15 20 26 29");
        //    PrintOnDemand(xxx => 
        //                    Console.WriteLine(xxx)
        //                    );
        //    //tao sẽ cung cấpp 1 con x bên trong của tao cho mày, mày làm gì vói x kệ mày
        //    //có thàng sẽ check xxx là nguyên tố thì mói in, có thàng thì có chãn mới in, có
        //    //thằng ko check gì cả in luôn!!!


        //    //TAO LÀ 1 HÀM NHẬN VÀO 1 HÀM KHÁC CÓ THAM SỐ INT X
        //    //TAO CHỊU TRÁCH NHIỆM HÀM BÊN NGOÀI ĐƯA VÀO, TAO THẢY CHO NÓ 1 con số
        //    //tao phó mặc hco hàm đó làm gì thì làm với con số tao thẩy cho
        //    //TAO TRỎ NÊN LINH HOẠT VỚI NHU CẦU XỬ LÍ DATA CỦA MỌI NGUÒI
        //    //KHI TAO CHỈ THẢY DATA CỦA TAO CHO MN
        //}
        static void Main(string[] args)
        {
            PrintOndeMandV2(PrintEvenNumber);
            Console.WriteLine("Divisable by 3");
            PrintOndeMandV2(ahihi => 
                {
                    if (ahihi % 3 == 0)
                        Console.WriteLine(ahihi);
                });
        }
        static void PrintOndeMandV2(Action<int> f)
        {
            //NẾU TA CÓ NHIỀU DATA CẦN SÀNG LỌC THEO NHU CẦU BÊN NGOÀI, ĐƯA DATA VÀO MẢNG

            //LEVEL HÔM QUA: TAO GỌI MÀY, MÀY LÀM ĐI Action f, LÀM TRỌN GÓI ĐÓNG KÍN
            //LEVEL HÔM NAY:TAO GỌI MÀY, MÀY LÀM ĐI Action<int> f. TAO TỬ TẾ GỬI THÊM INFO
            //                  INFO CHO MÀY, MẦY LÀM GÌ INFO KỆ MÀY
            //NẾU TAO CÓ NHIỀU DATA, TAO ĐƯA HẾT CHO MÀY QUA VÒNG FOR() MỚI ĐC GỌI  MÀY
            //NHIỀU LẦN; MÀY LÀM GÌ VỚI ĐÁM DATA TAO GỬI KỂ MÀY: CÓ DATA  KÊU GỌI XỬ LÍ
            //Ở BÊN NGOÀI
            //BÊN NGOÀI MUỐN IN CHẴN IN LẺ, IN NGUYÊN TỐ, IN SÓ ÂM DƯƠNG... HỖ TRỢ HẾT
            List<int> arr = new List<int> { 5, 10, 15, 20, 1, 3, 5, 7, 100, 101 };
            foreach (var x in arr)
            {
                f(x);
            }
        }
        static void PrintOnDemand(Action<int> f) //= PrintEvenNumber = lambda
        {
            //đầu vào lấy ở đâu mà đưa
            //giả sử mình có sẵn
            f(5); //f đại diện
            //data bên trong class mình viết chứa hàm TraiBao() sẽ gủi cho hàm đâu đó bên ngoài
            //outsource xử lí data ra ngoài
            f(10);
            f(15);
            f(20);
            f(25);
            f(26);
            f(29);
            //NHỜ BÊN NGOÀI FILTER DATA THEO CÁCH CỦA HỌ
            //TẬP DATA 5 10 15 20 ... TRONG NỘI TẠI SẼ ĐC CUNG ỨNG RA BÊN NGOÀI
            //BÊN NGOÀI XEM XÉT DATA PHÙ HỢP HAY KO VÀ SẼ DÙNG
            //CUNG ỨNG DỊCH VỤ XỬ LÍ DATA THEO NHU CẦU
            //BÁC NÀO MÚN XỬ LÍ, EM ĐƯA DATA BÁC LO XỬ LÍ

        }
        static void PrintOnDemand()
        {
                PrintEvenNumber(10); 
                PrintOddNumber(11);  
                PrintPrimeNumber(13);    
                PrintNumberGtEq50(50);  //tight coupling, luôn luôn chạy 4 hàm sửa code
        }
        static void PrintEvenNumber(int n)
        {
            if( n % 2 == 0)
                Console.WriteLine("{0}", n);    //place holder
        }
        static void PrintOddNumber(int n)
        {
            if (n % 2 != 0)
                Console.WriteLine($"{n}"); //interpolation    //place holder
        }
        static void PrintNumberGtEq50(int n)
        {
            if (n >= 50)
                Console.WriteLine(n);    //traditional
        }
        static void PrintPrimeNumber(int n)
        {
            //chỉ có 2 ước số
            if (n < 2) return;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) //lỡ chia hết đứa nào, thoát lun ko in
                    return;
            }
            Console.WriteLine(n);   //sống sót đế đây là nguyên tố chắc lun
        }
    }
}
