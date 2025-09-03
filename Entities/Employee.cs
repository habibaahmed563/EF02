using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    // Model - Entity
    internal class Employee
    {
        [Key]
        public int Id { get; set; }  //PK  --> EmployeeId Identity(1,1)
        public string Name { get; set; } // nverchar (max)
        public double? Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
