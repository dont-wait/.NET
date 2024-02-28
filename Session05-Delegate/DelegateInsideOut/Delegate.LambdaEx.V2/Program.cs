namespace Delegate.LambdaEx.V2
{
    //TA CHƠI HÀM CÓ 1 ĐẦU VÀO, KO TRẢ VỀ GÌ CẢ, STYLE VOID F(INT)
    //CHALLENGE:IN CÁC SỐ TỪ 1..n
    //CHOI ANONYMOUS, CHƠI LAMDA
    delegate void OneInputNoOutputDelegate(int n); 
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneInputNoOutputDelegate f = PrintIntegerList;
            OneInputNoOutputDelegate f = delegate (int n)
            {
                
                    if (n < 1)
                    {
                        Console.WriteLine("n must be greater than 0");
                        return; //kết thúc hàm lun, khỏi dùng else
                    }

                    Console.WriteLine("The list of numbers from 1 to " + n);
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                
            };  //vip
            f.Invoke(1000);

            OneInputNoOutputDelegate f1000 = (int n) =>
            {

                if (n < 1)
                {
                    Console.WriteLine("n must be greater than 0");
                    return; //kết thúc hàm lun, khỏi dùng else
                }

                Console.WriteLine("The list of numbers from 1 to " + n);
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();

            };  //vip   LAMBDA EX V1
            f1000(1000);

            OneInputNoOutputDelegate fn = (n) =>
            {

                if (n < 1)
                {
                    Console.WriteLine("n must be greater than 0");
                    return; //kết thúc hàm lun, khỏi dùng else
                }

                Console.WriteLine("The list of numbers from 1 to " + n);
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();

            };  //vip   LAMBDA EX V2  - LOẠI BỎ DATA TYPE
            //JAVA 100%
            fn(50);

            OneInputNoOutputDelegate fv3 = n =>
            {

                if (n < 1)
                {
                    Console.WriteLine("n must be greater than 0");
                    return; //kết thúc hàm lun, khỏi dùng else
                }

                Console.WriteLine("The list of numbers from 1 to " + n);
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();

            };  //vip   LAMBDA EX V3 - LOẠI BỎ DÂTA TYPE TRONG THAM SỐ VÀ DẤU NGOẶC ĐẦU VÀO NẾU CHỈ CÓ 1 THAM SỐ
            fn = ngocTrinh =>
            {

                if (ngocTrinh < 1)
                {
                    Console.WriteLine("n must be greater than 0");
                    return; //kết thúc hàm lun, khỏi dùng else
                }

                Console.WriteLine("The list of numbers from 1 to " + ngocTrinh);
                for (int i = 1; i <= ngocTrinh; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();

            };  //vip   LAMBDA EX V4 - LOẠI BỎ DÂTA TYPE TRONG THAM SỐ VÀ DẤU NGOẶC ĐẦU VÀO NẾU CHỈ CÓ 1 THAM SỐ
            fn.Invoke(56);              //  TÊN BIẾN ĐẦU VÀO ĐẶT LÀ GÌ CŨNG ĐƯỢC
        }
        static void PrintIntegerList(int n) {
            if(n < 1)
            {
                Console.WriteLine("n must be greater than 0");
                return; //kết thúc hàm lun, khỏi dùng else
            }

            Console.WriteLine("The list of numbers from 1 to " + n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}");
            }
              Console.WriteLine();
        }
       
    }
}
