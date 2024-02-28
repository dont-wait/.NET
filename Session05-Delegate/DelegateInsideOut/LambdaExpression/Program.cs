namespace LambdaExpression
{
    delegate void PlayNumberDelegate(int x); //nhóm hàm nhận vào 1 con x
                                             //ún gì với x thì làm
                                             //3 cách chơi hàm:
                                             //C1: làm 1 hàm tường minh - explicit, nhận x, làm gì đó, in ra kq - CÓ GHẾ TRONG QUÁN
                                             //C2: Làm 1 hàm ẩn danh - anonymoust methos/functiuon - implicit, éo thèm đặt tên hàm
                                             //                              éo thềm viết code riêng, tất cả gom cho thằng delegate, nick name, mày lấy code code của tao, khỏi cần tên tao
                                             //C3: TỪ CÁCH 2 CẮT BỚT CODE DƯ THỪA!!! => LAMBDA EXPRESSION (CODFE KHÁ GIỐNG EXPRESSION BODY KHI CÙNG XÀI => NHƯNG COI CHỪNG, KHÁC ĐẤY

    //CÓ CÂU: HÀM VÔ DANH RÚT GỌN CHỈ CÒN CÁI DÂY NỊT => BIẾN THÀNH BIỂU THỨC LAMDA
    //          BIỂU THỨC LAMBDA LÀ HÀM VÔ DANH TRONG DELEGATE
    //          HÀM VÔ DANH KO HẲN LÀ LAMDA NẾU VẪN VIẾT FULL {}
    //          LAMBDA GIỐNG EXPRESSION BODY VỀ KĨ HIỆU -=> VÀ SỰ LƯỢC BỚT
    //                       NHƯNG EXPRESSION BODY PHẢI FULL TÊN HÀM TỬ TẾ

    internal class Program
    {
        static void Main(string[] args)
        {
            //C1:
            PlayNumberDelegate playNumber = MakeTriple; //hợp đòng luật sư - thân chủ
            playNumber(3);  //action gián tiếp

            //C2: LÀM BIẾG ĐẶT CHỖ 1 HÀM TƯỜNG MINH, VÀO QUÁN KO NGỒI LẤY CAFE HOY
<<<<<<< HEAD
            //      ON THE GOTAKE AWAY, HỢP ĐỒNG LUẬT SƯ - THÂN CHỦ KO ĐỂ LẠI TÊN
=======
            //      TAKE AWAY, HỢP ĐỒNG LUẬT SƯ - THÂN CHỦ KO ĐỂ LẠI TÊN
>>>>>>> 5987436a64b6111de97aa3e18f1f07344c7ba6c3
            //      HÀM VÔ DANH ANONYMOUS FUCTION/METHOD
            playNumber = delegate (int n)
                                        {
                                            Console.WriteLine($"{n}{n}{n}");
                                        };
            playNumber(9);

            //C3: CHỈ CÒN DÂY NỊT   khác ex body ở chỗ ko có tên hàm
            playNumber = (int xxx) => Console.WriteLine($"{xxx}{xxx}{xxx}{xxx}{xxx}");
            playNumber.Invoke(10);  //5 CON MƯỜI 

            //C3: DÂY NỊT MỎNG
            playNumber =  (a) => Console.WriteLine($"{a}{a}{a}{a}{a}");       //vòng lên định nghĩa delegate
                                                                            //đầu vào con int, nên khỏi ghi
            playNumber.Invoke(68);  //5 CON 68 

            //C3: DÂY NỊT MỎNG HƠN NX
            playNumber = a => Console.WriteLine($"{a}-{a}-{a}-{a}-{a}-{a}");       //vòng lên định nghĩa delegate
                                                                             //đầu vào con int, nên khỏi ghi
            playNumber.Invoke(6789);  //5 CON 68 

            //VIẾT 1 HÀM IN RA MŨ RA CỦA 1 CON SỐ ĐƯA VÀO, KO CHƠI HÀM LẺ, RỜI, KO CHOI ANONYMOUS FULL
            //MÀ CHOI ANONYMOUS GIẢN LƯỢC ĐẾN TẬN CÙNG - LAMBDA EX
            playNumber = ngocTrinh => Console.WriteLine($"{ngocTrinh}^3 = {Math.Pow(ngocTrinh, 3)}");
            playNumber(56); //56^3 = 175.616

            //C1: HÀM TƯỜNG MINH
            static void MakeTriple(int n) => Console.WriteLine($"{n}{n}{n}");
            //                                          expresssion body: hàm có 1 lệnh duy nhất, ko cần ngoặc
            //hay return

        }
    }
}
