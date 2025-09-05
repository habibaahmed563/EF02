using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entity
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Adress { get; set; }
        public double HourRate { get; set; }
        public int Dept_Id { get; set; }
        public Department Department { get; set; }
        public List<Course_Inst> Course_Insts { get; set; }

    }
}
