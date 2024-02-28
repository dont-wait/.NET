using System.Collections.Specialized;

namespace DelegateReview.LambdaEx
{
    //CHALLENGE: IN CHO TUI TỔNG CÁC SỐ TỪ 1..100 -> 5050
    //hàm void F()
    delegate void NoInputNoOutputDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            NoInputNoOutputDelegate f = delegate ()
            {
                int sum = 0;
                for (int i = 1; i < 101; i++)
                    sum += i;
                Console.WriteLine($"The sum 1..100: {sum}");
            };  //hợp đồng bán tên - vô danh
            //phát ngôn - run()
            f.Invoke();

            //tui mún tính các số chẵn 1..10
            //2 4 6 8 10 
            //KĨ THUẬT RÚT GỌN PHÂN SỐ/BIỂU THỨC
            //RÚT GỌN ANONYMOUS METHOD ĐỂ CHỈ CÒN CÁI DÂY NỊT => LAMBDA EXPRESSION
            f = () =>
            {
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                    if(i % 2 == 0)
                        sum += i;
                Console.WriteLine($"The sum of evens: 1..10: {sum}");
            };  //hợp đồng bán tên - vô danh
                //phát ngôn - run()

            //BIỂU THỨC LAMBDA: BẢN CHẤT LÀ HÀM ANONYMOUS NHƯNG VIẾT RÚT GỌN
            //ĐẾN MỨC TỐI GIẢN - CHỈ CÒN CÁI DÂY NỊT
            //CÓ CÂU: LAMBDA LÀ ANONYMOUS
            //                  ANONYMOUS KO HẢN LÀ LAMBDA NẾU CHƯA RÚT GỌN TỐI GIẢN 

            //        EXPRESSION BODY VÀ LAMBDA EX XÀI CHUNG KÍ HIỆU =>
            //NHƯNG KHÁC NHAU
            //EXPRESSION BODY: HÀM VẪN CÒN FULL TÊN; HÀM CHỈ CÓ 1 LỆNH; RÚT 
            //GỌN LUÔN CẢ CẶP DÂU {}
            //LAMBDA EX: BỐI CẢNH HÀM VÔ DANH, CHƠI VỚI DELEGATE
            //           HÀM KO CÓ TÊN;
            //           CÓ THỂ RÚT GỌN {} HOẶC KO TÙY HÀM NHIỀU LỆNH HAY ÍT LỆNH
            //           HÀM 1 LỆNH ĐC QUYỀN LOẠI BỎ {}

            //CÚ PHÁP GÕ LAMBDA
            //tên-data-type-delegate biến-trỏ-hàm = delegate () {...};  //anonymous
            
            //LAMBDA
            //tên-data-type-delegate biến-trỏ-hàm =  () => {...};  //anonymous
            


            f.Invoke();
        }
    }
}
