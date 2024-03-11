using Repositories.Entities;
using Services;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CHƠI NGON: LƯU TRỮ DANH SÁCH SV NGÀNH SE RIÊNG BIỆT, NGÀNH BIZ RIÊNG BIỆT
            //           LƯU TRỮ DAN DANH SÁCH GV
            //           NẾU CÓ SẴN CLASS DOG, CAT -> THẢO CẦM VIÊN
            //TẤT CẢ CHỈ XÀI CABINET<???SV, GV, PHONE, CAT>
            Cabinet<Student> seList = new Cabinet<Student>();
            //Java: ArrayList<Student> seList = new ArrayList<Student>();

            Cabinet<Student> bizList = new Cabinet<Student>();

            Cabinet<Lecturer> seLecList = new Cabinet<Lecturer>();

            //2 SE
            seList.AddItem(new Student() { Id = "SE1", Name = "An", Gpa = 8.6});
            //                             object initalization
            seList.AddItem(new Student() { Id = "SE2", Name = "Bình", Gpa = 8.5});

            //1 BIZ
            bizList.AddItem(new Student() { Id = "SS3", Name = "Cường", Gpa = 8.7});

            //2 GV
            seLecList.AddItem(new Lecturer() { Id = "00000001", Name = "Dũng" });
            seLecList.AddItem(new Lecturer() { Id = "00000002", Name = "Em"});

            //in all info
            Console.WriteLine("The SE student list");   //2
            seList.PrintAll();

            Console.WriteLine("The Biz student list");  //1
            bizList.PrintAll();

            Console.WriteLine("The SE lecturer list");  //2
            seLecList.PrintAll();
        }
    }
}
