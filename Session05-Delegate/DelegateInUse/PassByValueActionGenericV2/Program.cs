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
            //Tính Tổng all
            SumOnDemand(x => true); //hàm trả về true cho mọi x
                                    //đưa 1 con số, nếu đúng thì cộng vào tổng cho tui
        }
        static bool CheckEvenV2(int n) => n % 2 == 0;
        static bool CheckEven(int n)
        {
            return n % 2 == 0;  //NÓ MANG ĐÚNG SAI, TRUE FALSE
            //if(n % 2 == 0)
            //    return true;
            //return false;
        }
        //CHALLENGE: VIẾT HÀM TÍNH TỔNG CỦA 1 DÃY SỐ CHO TRƯỚC
        //           VẪN DÃY SỐ ĐÓ, TÍNH TỔNG CỦA SỐ CHÃN
        //           VẪN DÃY SỐ ĐSO, ĐẾM CÁC SỐ LẺ
        //           5 10 15 20 2 4 6 8 1 3 5 7 9

        static void DoOnDemand (Predicate<int> f)   // = hàm bool F(int x)
        {
            List<int> arr = new List<int>() { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
        }

        //TÍNH TOÁN THEO ĐK ĐƯA VÀO:
        //SUM: SUM CÁI GÌ (ĐK ĐƯA VÀO): SUM CHẴN, SUM LẺ, SUM NGUYÊN TỐ
        //COUNT: COUNT CÁI GÌ
        static void SumOnDemand(Func<int, bool> f) // = hàm bool F(int x)
        {                                          //checkEven(x) -> true false     
            List<int> arr = new List<int>() { 5, 10, 15, 20, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            int result = 0;
            foreach (var x in arr)
            {                       //if đúng con x (tiêu chíe nào đso)
                                    //mình hàm TraiBao giành lại con x để làm gì tiếp
                if(f(x)) //== true) //checkEvent(x)   
                    result += x;
            }
            
            Console.WriteLine("Sum odd numbers: " + result);
        }

    }
}
