using Repositories.Entities;
using ServicesV2;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithStudentManagement();
        }
        static void PlayWithStudentManagement()
        {
           Cabinet<Student> seList = new Cabinet<Student>();
           Cabinet<Student> bizList = new Cabinet<Student>();


            seList.AddItem(new Student() { Id = "SE1", Name = "AN NGUYEN", Gpa = 8.0 }) ;
            seList.AddItem(new Student() { Id = "SE2", Name = "BINH LE", Gpa = 9.0 });

            bizList.AddItem(new Student() { Id = "SS3", Name = "CUONG PHAM", Gpa = 1.0 });

            seList.PrintAll();
            bizList.PrintAll();
        }
    }
}
