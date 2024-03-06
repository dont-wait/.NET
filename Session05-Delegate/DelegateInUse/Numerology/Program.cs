using System.Threading.Channels;

namespace Numerology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. IN HẾT DÃY SỐ CÓ TRONG NUMBER SERVICE
            NumberService.PrintNumbers(xxx => Console.WriteLine(xxx));

            //2. IN CÁC SỐ ÂM TRONG KHO
            Console.WriteLine("< 0");
            NumberService.PrintNumbers(xxx =>
            {
                if(xxx < 0)
                    Console.Write($"{xxx} ");
            });
            //đếm số dương
            NumberService.Count1(n => n > 0);
            //đếm số âm
            NumberService.Count2(n => n < 0);
        }

        //hàm lẻ nhận vào x làm gì vói x kệ void F(int x) {...in lun}
    }
}
