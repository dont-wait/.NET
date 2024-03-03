namespace FuncDelegate
{
    //C#13: VIẾT HÀM NHẬN VÀO 1 CON SỐ, SAU ĐÓ TRẢ VỀ BÌNH PHƯƠNG CỦA 1 CON SỐ
    //CÓ RETURN, KO IN RA TRONG HÀM
    delegate double OneInputOneOutputDelegate(double value);
    //                              double F(double x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#13 - METHOD RETURNS VALUE");
            OneInputOneOutputDelegate f1 = ComputeExponent;
            //25 ko có 25 mặc dù vẫn tính
            var result = f1(5); ;
            Console.WriteLine($"5^2 = {result}");
            //double result = f1(5);
            //MS LẠI BẢO RĂNG, NẾU HÀM CÓ TRẢ VỀ GIÁ TRỊ int, long, char, Student, Car, Pet
            //và hàm có thể có đầu vào hay ko, kệ, THÌ HÃY XÀI 1 DELEGATE STYLE GENERIC
            //TÊN LÀ FUNC
            //Func<int> -> hàm ko đầu vào, trả về int
            //Func<long> -> hàm ko đầu vào, trả về long
            //Func<string> -> hàm ko đầu vào, trả về string
            //Func<Dog> -> hàm ko đầu vào, trả về Dog
            //Func<int, int> -> hàm có đầu vào int, trả về int
            //Func<double, double, double> -> hàm có 2 đầu vào double, trả về double
            //BÊN PHẢI NHÁT LÀ ĐẦU RA, CÒN LẠI LÀ ĐẦU VÀO, CHƠI GENERIC CẢ ĐÁM
            //HÀM 5 ĐẦU VÀO, + 1 ĐẦU RA -> 6 GENERIC
            //HÀM CÓ TỐI ĐA 16 ĐẦU VÀO T1, T2, T6 ... T16 CỘNG VỚI THẰNG ĐẦU RA
            //HÀM CÓ KO ĐẦU VÀO => 17 LOẠI HÀM
            //
            //Func<int, int, long, char, Student, float, Pet, Lecturer,... int>
            //      --------------------------------------------------
            //                  đầu vào                                    đầu ra
            //                  

            //C#14: TÍNH BÌNH PHƯƠNG CỦA 1 CON SỐ RỒI TRẢ VỀ KQ
            Func<int, double> f = x => x * x;

            Console.WriteLine("C#14 - METHOD RETURNS VALUE USING FUNCT");
            Console.WriteLine("10^2 = " + f(1000));

            //C#15: TÍNH CHU VI TAM GIÁC
            Func<double, double, double, double> f3 = (double a, double b, double c) => a + b + c;
            Func<double, double, double, double> f4 = (a, b, c) => a + b + c;
            Console.WriteLine("C#15 - METHOD RETURNS VALUE USING FUNCT - TRIANGLE FUNC");

            Console.WriteLine("3 + 4 + 5" + f4(3, 4, 5));

            //C#16: THÁCH THỨC DANH HÀI: VIẾT HÀM TRẢ VỀ 1 CON SỐ BẤT KÌ BAO NHIÊU/BẠN THÍCH 6789 SBTC 2204 MMKC
            Func<int> getMyOwnNumber = () => 6789;  //Java Math.Random
            //Func<int> getMyOwnNumber = () => 6789;

            Console.WriteLine("C#16 - RANDOM NUMBER<>");
            Console.WriteLine("My own number" + getMyOwnNumber());  //12

            //C#17: VIẾT HÀM NHẬN VÀO 1 CON SỐ DOUBLE GPA - ĐIỂM TRUNG BÌNH
            //TRẢ VỀ TRUE NẾU GPA >= 8, TRẢ VỀ FALSE NẾU GPA < 8
            Console.WriteLine("C#17 - CHECK HÀNG");
            Console.WriteLine("10 >= 8? " + CheckGradeGtEq8SUPERVIP(8));

            Func<double, bool> checkHang8_1 = (double gpa) => gpa >= 8;
            Func<double, bool> checkHang8_2 = (gpa) => gpa >= 8;

            Func<double, bool> checkHang8_3 = gpa => gpa >= 8;
            Console.WriteLine("5 >= 8? " + CheckGradeGtEq8SUPERVIP(5)); //false

        }
        //<html>    5 > 3       > < dùng đánh dấu tag
        //          5 &gt; 3
        //          greater than
        static bool CheckGradeGtEq8SUPERVIP(double gpa) => gpa >= 8;
        static bool CheckGradeGtEq8VIP(double gpa)
        {
            return gpa >= 8;    //true/false
        }

        static bool CheckGradeGtEq8(double gpa)
        {
            if (gpa >= 8)   //biểu thức so sánh lun trả true fale 
                                //return biểu thức lun cho rồi
                return true;    //đằng nào cx cần ném ra true/false
                                //ném luôn biểu thức so sánh cho rồi
            return false;
        }

        static double ComputeExponent(double n) => n * n;

        //static double ComputeExponent(double n)
        //{
        //    return n * n;
        //}
    }
}
