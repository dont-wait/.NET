namespace PassByFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TÍNH TỔNG CHÃN
            SumOnDemand(CheckEven);
            //TÍNH TỔNG LẺ
            SumOnDemand(x => x % 2 != 0);

            SumOnDemand(x => true); //hàm trả về true cho mọi x
                                    //đưa 1 con số, nếu đúng thì cộng vào tổng cho tui
        }
        static bool CheckEven(int n)
        {
            return n % 2 == 0;
            //if(n % 2 == 0)
            //    return true;
            //return false;
        }
        //CHALLENGE: VIẾT HÀM TÍNH TỔNG CỦA 1 DÃY SỐ CHO TRƯỚC
        //           VẪN DÃY SỐ ĐÓ, TÍNH TỔNG CỦA SỐ CHÃN
        //           VẪN DÃY SỐ ĐSO, ĐẾM CÁC SỐ LẺ
        //           5 10 15 20 2 4 6 8 1 3 5 7 9

        static void DoOnDemand (Predicate<int> f)
        {
            List<int> arr = new List<int>() { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        }
        static void SumOnDemand(Func<int, bool> f)
        {
            List<int> arr = new List<int>() { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int result = 0;
            foreach (var x in arr)
            {
                if(f(x) == true)    //checkEven(x)
                    result += x;
            }
            Console.WriteLine("Sum odd numbers: " + result);
        }

    }
}
