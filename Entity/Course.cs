using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entity
{
    internal class Course
    {
        public int Id { get; set; }
        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_Id { get; set; }
        public Topic Topic { get; set; }
        public List<Stud_Course> stud_Courses { get; set; }
        public List<Course_Inst> Course_Insts { get; set; }

    }
}
