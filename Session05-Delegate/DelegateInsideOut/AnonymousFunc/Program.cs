namespace AnonymousFunc
{
    //khai báo class delegate map vào/đại dịne cho đám hàm void F(int), có vào ko ra
    //đại diện cho 2 hàm ở dưới luôn dò phù hợp format style

    delegate void PlayNumberDelegate(int x);    //map đại diện, luật sư, sứ giả
    internal class Program
    {

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Play with methods with an input and return nothing-void");
        //    PlayNumberDelegate playNumber = CloneNumber;  //nhân bản 3 lần
        //    //mún gọi CloneNumber(5) phải đưa vào data
        //    //playNumber biến đại diện = tên hàm gốc, thì biến đại diện cx đưa data vào như 
        //    //bản gốc
        //    playNumber(5);
        //    playNumber.Invoke(3);
        //    //gọi hàm 2 lần, với 2 tham số 5, 3

        //    //mún gọi hàm bình phương, gọi mình nó, hay nối tiếp với hàm đã ủy quyền trước
        //    //đó tùy; dùng =; hoặc +=
        //    Console.WriteLine("In ra bình phương");
        //    playNumber = PowerBy2Number;        //tớ playNumber là tên khác của cậu, nick
        //                                        //cam kết kết nối, hưa run(); CẤM KO () HIỂU LÀ
        //                                        //RUN, MỚI ỦY QUYỀN CHƯA THỰC THI, THỰC THI CẦN() PHẢI SAI KHI ỦY QUYỀN
        //                                        //MỜI LUẬT SƯ, ĐỒNG Ý RỒI MÓI ACTION
        //    playNumber.Invoke(10);  //100
        //    playNumber(5); //25

        //    //CHƠI HỆ MULTICAST
        //    playNumber += CloneNumber;  //power() trc rồi Clone() sau
        //    playNumber(6);  //màn hình có kết quả gì
        //}
        //Hàm mà sẽ đem đi cho thằng khác gọi, đặt nick name, thì hàm để ở đâu cx đc,
        //miễn là phải thuộc về class,
        //nếu là static thì chấm trực tiếp
        //nếu là non-static thì new rồi mới chấm
        //OOP CĂN BẢN, ÔN LẠI CHO CHẮC

        //SÁNG SỚM NAY, VÀ HỒI NÃY MÌNH CHỈ HỌC HÀM VOID F()
        //BI GIỜ HỌC THÊM HÀM CÓ THAM SỐ

        //hàm nhận vào 1 con số, in ra con số đó 3 lần sát nhau
        static void CloneNumber(int n) => Console.WriteLine($"{n}{n}{n}");

        //hàm nhận vào 1 con số, in ra bình phương ủa nó
        static void PowerBy2Number(int x)
        {
            Console.WriteLine($"The {x} * 2 = {x * x}");
            //Console.WriteLine
        }

        //TUI MÚN CÓ HÀM NHẬN VÀO 1 CON SỐ NGUYÊN NHƯNG: IN RA, LẬP LẠI THÀNH 4 SỐ 
        //NHẬN VÀO 9 -> IN RA 9999
        //C1: TẠO HÀM 4 SỐ CHÍN NHU 3 SỐ Ở TREN - TẠO HÀM TƯỜNG MINH
        static void CloneNumbersLikeGoldFormat(int n)
        {
            Console.WriteLine($"{n}{n}{n}{n}");
            //C2: DÙNG ANONYMOUS FUNCTION: THIẾT KẾ 1 HÀM KO THÈM CÓ TÊN, CHỈ CẦN ĐẦU VÀO TUÂN THEO 
            //ĐỊNH DẠNG CỦA DELEGATE ĐÃ KHAI BÁO; VIẾT CODE NGAY TRÊN CÂU LỆNH GÁN HỢP ĐỒNG ỦY QUYỀN
            //    PlayNumberDelegate playNumber = delegate (int n)
            //    {
            //        Console.WriteLine($"{n}{n}{n}{n}");
            //    };
        }
        //    static void Main(string[] args)
        //    {
        //        //PlayNumberDelegate numberDelegate = CloneNumbersLikeGoldFormat;
        //        //numberDelegate(9);
        //        PlayNumberDelegate playNumber = delegate (int n)  {Console.WriteLine($"{n}{n}{n}{n}");


        //                                                        };
        //}
        static void Main(string[] args)
        {
            //TUI MÚN CÓ HÀM MŨ 5
            //C1: LÀM HÀM BTH, MUA CHỖ NGỒI TRONG QUÁN, CỐ ĐỊNH
            //C2: ANONYMOUS, VIÊT CODE GÁN LUN CHO NICK NAME
            //PlayNumberDelegate playNumber = delegate (int n)
            //                                        {
            //                                            Console.WriteLine($"{n} * 5 = {n * n * n * n * n}");
            //                                        };
            PlayNumberDelegate playNumber = delegate (int n)
                                            {
                                             Console.WriteLine($"{n} * 5 = {Math.Pow(n, 5)}");
                                            };
            playNumber.Invoke(10);

        }
    }
}

