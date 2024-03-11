using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Student
    {
        public String Id { get; set; }
        public String Name {  get; set; }

        public String Email {  get; set; }
        public int Yob {  get; set; }
        public double Gpa {  get; set; }

        public override string ToString() => $"Student: {Id} | {Name} | {Gpa}";
    }
}
