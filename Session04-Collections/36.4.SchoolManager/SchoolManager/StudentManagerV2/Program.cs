using StudentManagerV2.Services;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet seBox = new Cabinet();  //có sẵn trong ram 300 chỗ chứa HSSV, count = 0
            Cabinet bizBox = new Cabinet(); //có sẵn trong ram 300 chỗ chứa HSSV khác, count = 0 khác!!!

            seBox.AddNewStudent("SE86", "An", "an@...", 2003, 8.6);
            seBox.AddNewStudent(id: "SE88", name: "Bình", email: "binh@...", yob: 2004, gpa: 8.8); //named-arg

            bizBox.AddNewStudent("SS66", "Cường", "dung@...", 2003, 6.6);
            bizBox.AddNewStudent(id: "SS77", name: "Dũng", email: "dung@...", yob: 2004, gpa: 7.7); //named-arg
            Console.WriteLine("The Biz students");
            bizBox.PrintStudentList();

            Console.WriteLine("The SE students");
            seBox.PrintStudentList();

        }
    }
}
