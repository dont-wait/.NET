using StudentManagerV2.Services;

namespace StudentManagerV2
{
    internal class Program
    {
        private static readonly int tuSE;

        static void Main(string[] args)
        {
            Cabinet = new Cabinet();  //có sẵn trong ram 300 chỗ chứa hồ sơ sinh viên
            //count = 0
            Cabinet bizBox = new Cabinet(); //có sẵn trong ram 300 chỗ chứa HSSV khác, count = 0 khác!!!
                                            //

            seBox.AddNewStudent("SE86", "AN", "an@...", 2003, 8.6);
            seBox.AddNewStudent(id: "SE88", name: "AN", email: "an@...", yob: 2003, gpa: 8.8);

            bizBox.AddNewStudent("SS66", "CƯỜNG", "dung@...", 2003, 6.6);
            bizBox.AddNewStudent(id: "SS88", name: "Dũng", email: "an@...", yob: 2003, gpa: 8.8);

            Console.WriteLine("The SE students");
            seBox.PrintStudentList();
            
            Console.WriteLine("The SS students");
            bizBox.PrintStudentList();
        
        }
    }
}
