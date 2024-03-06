namespace PassByAction
{
    //CHALLENGE: VIẾT HÀM THẦU CÁC HÀNH ĐỘNG NÀO ĐÓ BÊN NGOÀI ĐƯA VÀO
    //              HÀM THẦU CÁC DỊCH VỤ IN ẤN: IN BÀI HÁT, IN SỐ, IN DÃY SỐ

    internal class Program
    {
        //sqrt(25); //run
        static void Main(string[] args)
        {
            DoOnDemand(delegate () 
                { 
                    Console.WriteLine("Cầm tay anh, dựa vai anh");
                    Console.WriteLine("Code cùng anh, nơi này có CSharp");
                }
            );
            DoOnDemand(() => 
            { 
                Console.WriteLine("Chúng ta không thuộc về nhau");
                Console.WriteLine("CSharp chắc có là của nhau");
            }
            );
        }
        //  DoSomeThing(int n)
        static void DoOnDemand(Action f) 
        {
            Console.WriteLine("Do-while-for-code as normal");

            //later, callback f
            f();    //f.Invoke();
        }
    }
}
