using Services;

namespace Zodiac
{
    //Class Form1 chính là class kế thừa (inherit/
    //inheritance) cái class gốc mà Windows cung cấp để
    //render ra cửa sổ tương tác

    //Form là class Cha, Parent, class Gốc có khả năng
    //render 1 HCN ~ web page để cung cấp mặt sàn tương 
    //tác với user

    //Ta lập trình app Gui, app destop, tức là cái
    //app chạy trên nền Destop, có icon biểu tượng trên
    //thanh Taskbar, chính là tạo ra class kế thừa class Form.
    //                          Con kế thừa Cha
    //                          Con extend Cha
    //                          Dog         Pet
    //                          Rectangle   Shape
    //chữ kế thừa trong Java là extand
    //                  C#      :
    public partial class ZodiacManager : Form
    {
        public ZodiacManager()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            //1. đưa ảnh vào ram
            //Image img = Image.FromFile(@"signs\hauGai.jpg");

            Image img = Image.FromFile(@"signs\Arya-san.jpg");


            //Image img = Image.FromFile("signs\\hauGai.jpg");

            //đường dẫn đến bức ảnh thì phải là dấu \ với window
            //dầu / với Linus, Mac os
            // dấu \ biểu diễn kí tự đặc biệt \n xuống hàng \t tab
            //do đó ta phải \\ để cho win biết rằng
            //ta đang \ theo style bình thường

            //2. Show ảnh <img src="">
            picImage.Image = img;
        }

        private void ZodiacManager_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            //gọi thư viện để trả về cung hoàng đạo
            //trước đó cần lấy được ngày và tháng sinh đang nằm trong 2 ô Text. Toàn
            //bộ gõ từ bàn phím là text. Ta phải convert về số. Java: Integer.ParseInt
            //(string)

            int day = int.Parse(txbBirthDay.Text);   //gọi Text
            int month = int.Parse(txbMonth.Text);   //gọi Text

            string zodiacEN = ZodiacCalculator.GetZodiacEnglish(month, day);
            string zodiacVI = ZodiacCalculator.GetZodiacVietnamese(zodiacEN);

            string zodiacImage = @"signs\" + zodiacEN + ".jpg"; //lấy tên cung(file) + jpg convert ra ảnh

            //load ảnh và cập tập cái status
            Image img = Image.FromFile(zodiacImage);
            picImage.Image = img;

            lblYourZodiac.Text = "Your zodiac sign: " + zodiacEN + " | " + zodiacVI;

            //TODO: NHỚ VALIDATION NGÀY THÁNG CÓ HỢP LỆ, CÓ NHẬP HAY KHÔNG
            //IF ( Ô TEXT LẤY TEXT RA RỒI TÍNH


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //HỎI XÁC NHẬN CÓ MUỐN THẬT SỰ MUỐN THOÁT APP HAY KHÔNG
            DialogResult anwser = MessageBox.Show("Do you really want to exit?", "Exit?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //hàm này trả về giá trị lựa chọn của user khi user bấm nút Yes/No/OK/Cancel... -> giá trị này
            //thuộc data type DialogResult
            //                  DiaLog: Hội thoại
            if(anwser == DialogResult.Yes)
                Application.Exit();
        }

        private void pnlImage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

//private void btnShowImage_Click(object sender, EventArgs e)
//{}