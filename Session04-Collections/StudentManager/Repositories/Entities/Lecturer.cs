using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Lecturer
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public int Yob { get; set; }

        public double Salary { get; set; }

        public override string ToString() => $"Lecturer: | {Id} | {Name} | {Salary}";
    }
}
