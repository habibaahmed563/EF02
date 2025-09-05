﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entity
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ins_Id { get; set; }
        public Instructor Manager { get; set; }
        public DateOnly HiringDate { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}
