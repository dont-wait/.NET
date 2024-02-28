namespace DelegateReview.LambdaExV3
{
    //VIẾT DÙM TUI HÀM TÍNH DT HCN (W * L)
    //VIẾT DÙM TUI HÀM MŨ A^B, X^Y

    //HÀM PHẢI TRẢ VỀ GIÁ TRỊ KO ĐC IN RA KẾT QUẢ, TRẢ VỀ NƠI GỌI SẼ TỰ IN
    //VOID TRONG HÀM SẼ TỰ IN
    //style hàm DOUBLE f(DOUBLE A, DOUBLE B)
    delegate double TwoInputsOneOutputDelegate(double a, double b);

    internal class Program
    {
        static void Main(string[] args)
        {
            TwoInputsOneOutputDelegate f = ComputeRectangleAreaV2;  //TỰ ĐỊNH NGHĨA cứ là f thì phải có vào là 2 con double, ra là 1 con double
                                                                    //ko quan trọng tên là dì, auto convert thành double

            double area = f(5, 10);
            Console.WriteLine("Compute area (5x10) using delegate:" + area);

            f = delegate (double width, double length)
            {
                return width * length;
            };  //anonymous
            Console.WriteLine("Compute area (5x10) using delegate:" + f(10, 15));

            //LAMBDA EX

            f = (double width, double length) =>
            {
                return width * length;
            };  //anonymous
            Console.WriteLine("Compute area (5x10) using Lambda ExV1:" + f(10, 15)); //V1

            f = (width, length) =>
            {
                return width * length;
            };  //anonymous
            Console.WriteLine("Compute area (10x15) using Lambda ExV2:" + f(10, 15)); //V2

            f = (width, length) => width * length;
            Console.WriteLine("Compute area (10x15) using Lambda ExV3:" + f(10, 15)); //V3  //ĐẸP TROAI

            f = (ngocTrinh, namEm) => ngocTrinh * namEm;
            Console.WriteLine("Compute area (15x20) using Lambda ExV4:" + f(15, 20));   //v4

            //VIẾT HÀM TÍNH A^B, 2^10 = 2 2 2 2 2 2 for
            //MATH.POW(A, B)  A^B JAVA Y CHANG

            f = (a, b) => Math.Pow(a, b);

            f = (namEm, nhaPhuong) => Math.Pow(namEm, nhaPhuong);


            Console.WriteLine("2^10 (using LAMBDA)= " + f(2, 10));

            //CÂU VIEW CHO BUỔI HỌC SAU
            var fx = (int a, int b, int c) => a + b + c;
            Console.WriteLine("fx(3, 4, 5): " + fx(3, 4, 5));
        }
        static double ComputeRectangleAreaV2(double width, double length) => width * length;

        static double ComputeRectangleArea(double width, double length)
        {
            return width * length;
        }
    }
}
