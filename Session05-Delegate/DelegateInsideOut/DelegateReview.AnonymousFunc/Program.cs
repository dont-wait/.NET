namespace DelegateReview.AnonymousFunc
{
    //khai báo data type, class chứa các hàm thuộc style void f()
    public delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call method direcly - not using delegate");
            PrintNumbers(); //ko xài thân chủ - luật sư, call direcly
                            //chơi trực tiếp với tên gốc của hàm
                            //truyền thống
                            //luật sư = thân chủ = ủy quyền = phát ngôn dùm tui!
                            //kí hợp đồng, cho em 1 cái tên, đặt nick name/2nd name cho hàm gốc
            NoInputNoOutputDelegate f = PrintNumbers;   //ko dùng ngoặc tròn vì nó là run() hàm
            
            Console.WriteLine("Call method indirecly - using delegate");
            f();

            //f = PrintEvenNumbers;
            f = delegate    //khỏi tên hàm, dùng f cho rồi - bán tên, bán linh hồn 
            {
                Console.WriteLine("The list of even numbers from 1..100");
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 == 0)
                        Console.Write($"{i} ");
                }
                Console.WriteLine();

            };//VIP GÁN HỢP ĐỒNG
              //đoạn code ở trên, mày thuộc hàm nào
              //dạ đoạn code ở trên ngày xưa em ở PrintEvenNumber
              //nay bán cái tên đi rồi, còn lại xử lí thôi, gọi hàm cũ qua tên mới
              //f, delegate ủy quyền hàm cũ, xử lí hàm cũ, cho chữ f nó đại diện

            //HÀM GỐC CẦN TÊN, MÀ SẼ GỌI QUA HỢP ĐỒNG VỚI LUẬT SƯ!!!
            //HÀM ẨN DANH - ANONYMOUST FUNCTION
            //ĐOẠN CODE CỦA HÀM GỐC, NAY DÙNG NICK-NAME TÊN LUẬT SƯ!!!
            //CHỈ CÒN 1 TÊN MÀ KO LÀ TÊN GỐC
            //GỌI QUA TÊN MỚI
            //LUẬT SƯ PHÁT NGÔN, RUN HÀM
            Console.WriteLine("Call method indirecly - using anonymous function");
            f();

            //THÁCH THỨC: IN RA CÁC SỐ LẺ TỪ 1..100
            //BẮT BUỘC PHẢI XÀI ANONYMOUS Function
            //cú pháp viết anonymous function
            //Tên-DELEGATE-DATA-TYPE TÊN-BIẾN-NICK-LUẬT-SƯ = delegate {thân hàm};
            Console.WriteLine("CHẴN LẺ SONG HÀNH");
            f += delegate () 
            {
                Console.WriteLine("The list of odd numbers from 1..100");
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 != 0)
                        Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            Console.WriteLine("Call method indirecly - using anonymous function again");
            f();    //số lẻ

            //hack não: in vừa chẵn vừa lẻ
            //in thêm dãy chia hết cho 5 rồi thôi
            f += delegate () {
                Console.WriteLine("NAM EM VS. NHA PHUONG | DAO VS. MAI");
            };
            Console.WriteLine("ĐOÁN XEM...");
            f();
        }
        //CHALLENGE: VIẾT HÀM IN RA CÁC SỐ CHẴN TỰ NHIÊN 1..100
        static void PrintEvenNumbers()
        {
            Console.WriteLine("The list of even numbers from 1..100");
            for (int i = 0; i < 100; i++)
            {
                if(i % 2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        //CHALLENGE: VIẾT HÀM IN RA CÁC SỐ TỰ NHIÊN 1..100
        static void PrintNumbers()
        {
            Console.WriteLine("The list of numbers from 1..100");
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
                //Console.Write("{0} ", i);
                //Console.Write($"{i} ");
                //Console.Write($@"{i} ");
            }

            Console.WriteLine();
        }
    }
}
