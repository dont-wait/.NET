using System.Collections.Specialized;
using System.Threading.Channels;

namespace Numbers
{
    //CHALLENGE #1: LƯU TRỮ 1 DANH SÁCH SỐ NGUYÊN CHO TRƯỚC
    //              SAU ĐÓ IN RA: CÁC SỐ DƯƠNG
    //                            CÁC SỐ ÂM
    //                            IN RA TOÀN BỘ
    //                            IN RA CÁC SỐ CHIA HẾT CHO 5
    //                            ...
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Print all");
            //PrintListOnDemand(x => true);   //đua ai tao cx true hết

            //Console.WriteLine("Print +");
            //PrintListOnDemand(x => x > 0);

            //Console.WriteLine("Print -");
            //PrintListOnDemand(x => x < 0);
            //PlayWithBuiltOnDemandMethods();
            PlayWithBuiltInOnDemandMethodV2();
            
        }
        static void PlayWithBuiltInOnDemandMethodV2()
        {
            List<int> _arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };

            var result = from x in _arr //VỚI mọi x thuộc tập arr
                         where x > 0    //xem x nào > 0
                         select x;      //thì lấy x đso mà trả về để dùng típ

                                    //CÂU QUẺY GIỐNG NHƯ SQL DÙNG ĐỂ TRUY VẤN DATA TRONG
                                    //RAM - LINQ THEO STYLE QUẺY SYNTAX
                        //RUNTIME CHẠY THÌ CONVERT VỀ LAMBDA NHƯ ĐÃ VIẾT, .WHERE(X => X > 0)
                        //METHOD SYNTAX

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        static void PlayWithBuiltOnDemandMethods()
        {
            List<int> _arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13, -2 };
            //tui mún in tất
            //arr có sẵn 1 loạt các hàm để xủ lí data mà nó cất trũ, thay vì ta tự làm
            //hàm sty;e on demand cx xài cần Action, Action<>, Predicate tùy loại hàm

            //1. In toàn bộ tham số
            Console.WriteLine("Get all");

            _arr.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("<-");
            //2, In số âm
            _arr.ForEach(x => { if (x < 0) Console.WriteLine(x); });

            //3, trả về tui các số dương
            //HÀM DEMAND TRẢ VỀ LIST CHO MÌNH DÙNG TÍP
            Console.WriteLine("< 0LIST ==================");

            List<int> result = _arr.Where(x => x >= 0).ToList();
            result.ForEach(x => Console.WriteLine(x));
        }

        static void PrintListOnDemand(Predicate<int> f)
        {
            List<int> _arr = new List<int> { -10, -100, 50, 2, 1, 5, 10, 13 , -2};
            foreach (var x in _arr)
            {
                //2 cách giao khán hết ra ngoài in Action<int>
                //chủ động in, nhưng nhò ên ngoài check giá trị Predicaate<int>
                if(f(x))
                    Console.WriteLine(x);
            }
        }
    }
}
