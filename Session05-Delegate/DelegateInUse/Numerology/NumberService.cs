using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerology
{
    internal class NumberService
    {
        static private List<int> _arr = new List<int> { -5, -10, -1, 5, 10, 15, 20, 1, 3, 5, 9, 100, 101};
        
        public static void PrintNumbers(Action<int> f)
        {
            foreach (var x in _arr)
            {
                f(x);   //tao lần lượt gửi data cho mày, cho hàm f() hàm f() mày làm gì với data kệ
                        //nếu f() check x > 0 mới in, PrintNumbers() chính là hàm in ra các số lớn hơn
            }
        }
        //style cũ: thiết kế đủ các loại hàm cung cấp data! đủ cỡ nào cx  ko là đủ, do nhu cầu
        //tính tóa khác nhau trên bộ data: tính chẵn, lẻ, chia hết cho 10, cho 5, tính tổng,...
        
        //VIẾT HÀM ĐẾM CÁI GÌ ĐÓ TRONG DÃY SỐ TRÊN: ĐẾM CHẴN, ĐẾM LẺ, ĐẾM NGUYÊN TỐ
        //NHÓM: GIÀNH KIỂM SOÁT, OUTSOURCE 1 PHẦN
        public static void Count2(Predicate<int> f) //= hàm chcekNt(int x)
        {
            int count = 0;
            foreach (var x in _arr)
            {
                //điều gì đúng thì ta count. đưa điều đó vào đây, hàm thích úng mọi kiểu đếm
                if (f(x))
                    count++;
            }
            Console.WriteLine("Count: " + count);
        }
        public static void Count1(Func<int, bool> f) //= hàm checkNt(int x)
        {
            int count = 0;
            foreach (var x in _arr)
            {
                //điều gì đúng thì ta count. đưa điều đó vào đây, hàm thích úng
                //mọi kiểu đếm
                if (f(x))
                    count++;
            }
            Console.WriteLine("Count: " + count);
        }
    }   
        

}
