using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entity
{
    internal class Course_Inst
    {
        public int inst_Id { get; set; }
        public int Course_Id { get; set; }
        public double evaluate { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
