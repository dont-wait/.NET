using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Enities
{
    internal class Student
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; } //quên cú pháp gõ prop tab tab
        public override string ToString() => $"Student: {Id} | {Name} | {Email} | {Yob} | {Gpa}";


    }
}
