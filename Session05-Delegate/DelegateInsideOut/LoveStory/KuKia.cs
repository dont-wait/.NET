using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveStory
{
    //3 THẰNG NGANG CƠ NHAU, ĐỨNG NGANG NHAU: INTERFACE, CLASS, DELEGATE (CLASS ĐẠC BIỆT)
    //TAO CHỈ CHỨA TÊN HÀM

    //public class x [void X()] delegate {
    //        _nickHamNaoDo=
    //    }
    public delegate void SendLoveMessageDelegate(); //delegate void x(); 
    //        Bạn:  void NhanEm();   f
    //        Tui:  void TellHer();  f
    internal class KuKia
    {
        public static void MeetSweetHeart()
        {
            Console.WriteLine("Hey baby, oh my sweet heart");
            //hắn kukia phải nhận lòi gởi gắm của Tui và Bạn -> chính là trỏ đến hàm nhắn tin mà lẽ ra Tui Bạn phải trực tiếp run()
            //trực tiếp nói. Nay KuKia sẽ run() dùm
            //DELEGATE CHO KUKIA, CHO NICK NAME, TAO CHUYỂN LỜI CỦA TAO HO MÀY RUN
            //SendLoveMessageDelegate message = new SendLoveMessageDelegate(Ban.NhanEm);
            SendLoveMessageDelegate message = Tui.TellHer;
            message += Ban.NhanEm;

            Console.WriteLine("By the way, you have messages from...");
            //gọi hàm nhắn tin, nhưng hok gọi trực tiếp mà gọi qua delegate
            //do 2 tin này đã đc capture duói dạng biến delegate, bỏ vào vùng new Delegate
            //gọi gián tiếp, nói giùm, ủy quyền
            message();  //em nghe 2 message nè

            //trực tiếp sẽ là Tui.TellHer() Bạn.NhanEm()

        }
    }
}
