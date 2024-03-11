using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    internal class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }  //quên cú pháp gõ prop tab tab

        public override string ToString() => $"Lecturer: {Id} | {Name} | {Email} | {Yob} | {Salary}";


    }
}
