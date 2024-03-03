namespace PredicateDelegate
{
    //MICROSOFT BẢO RẰNG: NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO,
    //CHỈ CÓ 1 ĐẦU VÀO
    //HÀM TRẢ VỀ ĐÚNG SAI
    //MỞ RỘNG THÊM: TOÁN LOGIC, TOÁN MỆNH ĐỀ - CÂU PHÁT BIỂU ĐÚNG SAI
    //CÓ HÀM MỆNH ĐỀ - HÀM NHẬN 1 ĐẦU VÀO SAU ĐÓ TRẢ VỀ 1 CÂU PHÁT BIỂU ĐÚNG SAI
    //HÀM NÀY ĐC GỌI LÀ HÀM TIÊN ĐOÁN, HÀM DỰ ĐOÁN, HÀM MỆNH ĐỀ,
    //HÀM LƯỢNG GIÁ, PREDICATE - LOGIC VỊ TỪ

    //ông X là 1 nhà toán học -> câu này ko biết đúng sai, vì X là biến
    //Hàm   IsNhaToanHoc(ông/bà x nào đó)
    //Hàm nhận vào con người, trả ra đúng sai nếu đó là nhà toán học hay ko
    //       IsNhaToanHoc(Ngô Bảo Châu)
    //              => Ông Ngô Bảo Châu là 1 nhà tóa học => mệnh đề đúng
    //IsNhaToanHoc(giáo.làng) => SAI MỌE NÓ RỒI, GÃ LÀM THUÊ CHO TƯ BẢN
    //ĐAM MÊ CODE, KO ĐAM MÊ TIỀN 7H SÁNG ĐẾN 7H5P CÒN VÀI PHÚT NX!!!

    //      Predicate(???) => true/false 
    //HÃY ĐOÁN XEM ??? LÀ ĐÚNG HAY SAI


    //MICROSOFT BẢO RẰNG: NẾU HÀM NHẬN VÀO ĐÚNG 1 ĐẦU VÀO,
    //CHỈ CÓ 1 ĐẦU VÀO, HÀM TRẢ VỀ ĐÚNG SAI
    //THAY VÌ KHAI BÁO Func<double, bool> THÌ KHAI BÁO LÀ Predicate<double>
    //THAY VÌ KHAI BÁO Func<int, bool> THÌ KHAI BÁO LÀ Predicate<int>
  
    //THAY VÌ KHAI BÁO Func<Student, bool> THÌ KHAI BÁO LÀ Predicate<Student> là đủ
    //kiểm tra xem Student x có đúng là???




    internal class Program
    {
        static void Main(string[] args)
        {
            //hàm cuối cùng #18 viết hàm nhận vào 1 con số gpa, trả về nó lớn hơn
            //hay bằng 8 hay ko
            Func<double, bool> check8V1 = (gpa) => gpa >= 8;
            Predicate<double> check8Final = gpa => gpa >= 8;
            //                  hàm         nhận vào
            //                              con gpa     trả ra có đúng là
            //                              //                  nó lớn hơn 8 hay ko
            //đúng hay sai
            Console.WriteLine("Final fantasy: 10 >= 8? " + check8Final(8));

            //LINQ TRONG COLLECTION, LIST TOÀN XÀI LAMBDA!!!FILTER DATA

            //LỆNH CUỐI CÙNG
            //CÂU VIEW
            var x = 2004.715;   //7h15pm

            var fx = (double a, double b, double c) => a + b + c;
            Func<double, double, double, double> fxx = (a, b, c) => a + b + c;
            //hàm tính chu vi tam giác, tổng 3 số
            var fLoiToang = ( a, b, c) => a + b + c;
            //7h20 tối 


        }
    }
}
