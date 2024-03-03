namespace ActionGenericDelegate
{

    //C#6: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    //      VIẾT HÀM LẺ CÓ SẴN NGOÀI KIA
    //      ANONYMOUS FUNCTION, LAMBDA EXPRESSION => DELEGATE ÒI

    //C#7: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    //      DÙNG ANONYMOUS 

    //C#8: VIẾT HÀM NHẬN VÀO 1 SỐ NGUYÊN DƯƠNG, IN RA BÌNH PHƯƠNG CỦA NÓ
    //      DÙNG LAMBDA
    //                                   void F(int x);
    //MICROSOFT BẢO RẰNG: HÀM MÀ KO TRẢ RA GÌ CẢ, GỌI LÀ HÀNH ĐỘNG, ACTION
    //TUY NHIÊN CÓ LOẠI HÀNH ĐỘNG, HÀM CÓ CẦN ĐẦU VÀO, 1 ĐẦU VÀO, 2 ĐẦU,
    //N ĐẦU VÀO -> CX LÀ HÀNH ĐỘNG, CŨNG LÀ ACTION
    //TUY THẾ 1 ĐẦU VÀO CÓ THỂ INT, LONG, STUDENT, FLOAT
    //        2 ĐẦU VÀO CÓ THỂ LÀ INT, INT  | INT/LONG | STRING/STRING
    //HÀM NHIỀU THAM SỐ | THAM SỐ KHÁC NHAU VỀ DATA TYPE, THỨ TỰ DATA TYPE
    //VÔ CHỪNG LOẠI HÀM NHƯ THẾ NÀY???
    //GENERIC XUẤT HIỆN, DÙ BẠN INT, LONG, CHAR, PERSON, STUDENT, BẠN LÀ DATA TYPE <T>
    //  MÀ THÔI, LÚC NÀO CẦN DÙNG, THAY <T> BẰNG DATA TYPE CỤ THỂ

    public delegate void OneInputNooutputDelegate(int n);
    //KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, KO ĐẦU VÀO, THÌ XÀI
    //          Action f = ...
    //KỂ TỪ NAY VỀ SAU, MỖI KHI NÓI VỀ HÀM VOID, CÓ ĐẦU VÀO, 1, 2, 3,4...16 ĐẦU VÀO
    //THÌ XÀI, KHAI BÁO, DÙNG DELEGATE CÓ SẴN, STYLE GENERIC NHƯ SAU
    //          Action<int> f = hàm có 1 đầu vào int
    //          Action<char> f = hàm có 1 đầu vào char
    //          Action<Student> f = hàm có 1 đầu vào Student
    //          Action<int, int> f = hàm có 2 đầu vào int, int
    //          Action<Student, int> f = hàm có 2 đầu vào String, int
    //          Action<16 đầu vào> f = hàm có 16 đầu vào, tùy data type, bạn cần

              

      

    internal class Program
    {
        static void Main(string[] args)
        {
            OneInputNooutputDelegate f = ComputeExponentV2; //truyền thống
            //delegate tự build
            Action<int> f2 = ComputeExponentV2;
            Console.WriteLine("C#9: USING ACTION <> GENERIC ON THE METHOD WITH UP TO 16 PARAMS");
            f2(1000);   //1 triệu

            //C#10: DÙNG ACTION<> TÍNH MŨ 3 CỦA 1 CON SỐ VÀ IN RA. DÙNG LUÔN
            //ANONYMOUS & LAMBDA EX
            Console.WriteLine("C#10: USING ACTION <int> GENERIC ON THE METHOD WITH UP TO 16 PARAMS - ^3");
            Action<int> f3 = delegate (int x) { };
            Action<int> f4 = delegate (int xxx) 
            { 
                Console.WriteLine($"{xxx}^2 = {Math.Pow(1000, 2)}"); 
            };


            //Action<int> f5 = (xxx) => { Console.WriteLine($"{xxx}^3 = {Math.Pow(1000, 3)}"); };
            Action<int> f5 = xxx => { Console.WriteLine($"{xxx}^3 = {Math.Pow(1000, 3)}"); };
            Action<int> f6 = xxx =>  Console.WriteLine($"{xxx}^3 = {Math.Pow(3, 3)}"); 
                    
            f6(3);  //27

            //C#11: VIẾT HÀM IN RA DIỆN TÍCH HÌNH CHỮ NHẬT - Width, Length
            Console.WriteLine("C#10: USING ACTION <int> GENERIC ON THE METHOD WITH UP TO 16 PARAMS - AREA RECTANGLE");

            Action<double, double> f7 = (double x, double y) => { }; 
            Action<double, double> f8 = ( x, y) => { };
            Action<double, double> f9 = ( haiTu, baoTram) =>
            {
                Console.WriteLine($"Area ({haiTu} x {baoTram}) = {haiTu * baoTram}");
            };
            Action<double, double> f10 = (haiTu, baoTram) => Console.WriteLine($"Area ({haiTu} x {baoTram}) = {haiTu * baoTram}");
            f10(10, 20);    //200

            //C#12: IN RA CÁC SỐ CHẴN TỪ 1 TỚI N
            //gán hàm là gán code => vậy tao đem code của hàm zô lun
            //Action<int> printEvenss = delegate (int n) { }; 
            Console.WriteLine("C#10: USING ACTION <int> GENERIC ON THE METHOD WITH UP TO 16 PARAMS - EVEN NUMBERS");
            Action<int> printEvens = n =>
            {
                Console.WriteLine($"The list of even numbers for 1..{n}");
                if (n < 1)
                    return;
                for (int i = 1; i <= n; i++)
                    if(i % 2 == 0)
                        Console.Write($"{i} ");
                Console.WriteLine();
            };  //VIP;
            printEvens(10);

        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\nC#6: CALL METHOD AS NORMAL");
        //    ComputeExponentV2(5);   //5^2 = 25

        //    Console.WriteLine("\nC#7: CALL METHOD USING ANONYMOUS FUNC");
        //    OneInputNooutputDelegate f1 = delegate  (int xxx) 
        //                {
        //                    Console.WriteLine($"{xxx}^2 = {xxx * xxx}");
        //                    Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");

        //                };
        //    f1(10);

        //    Console.WriteLine("\nC#8: CALL METHOD USING LAMBDA EXPRESSION");

        //    OneInputNooutputDelegate f2 = (int xxx) => Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}") ;
        //    OneInputNooutputDelegate f3 = (xxx) => Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}") ;
        //    OneInputNooutputDelegate f4 = xxx => Console.WriteLine($"{xxx}^2 = {Math.Pow(xxx, 2)}");
        //    OneInputNooutputDelegate f5 = ngocTrinh => Console.WriteLine($"{ngocTrinh}^2 = {Math.Pow(ngocTrinh, 2)}") ;
        //    //Lambda expression, chứ không phải Expression Body do tên hàm biến mất, ko có tên hàm
        //    f5(100);    //10.000
        //}
        static void ComputeRectangleArea(double width, double length)
        {
            Console.WriteLine($"Area ({width} x {length}) = {width * length}");
        }
        static void ComputeExponentV2(int x) => Console.WriteLine($"{x}^2 = {x * x}");
        static void ComputeExponent(int x) 
        {
            //int result = x * x;
            double result = Math.Pow(x, 2);
            Console.WriteLine($"{x}^2 = {result}");
           
            Console.WriteLine($"{x}^2 = {Math.Pow(x, 2)}");

        }

    }
}
