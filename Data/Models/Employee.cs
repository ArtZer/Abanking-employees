using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abanking_employees.Data.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public char sex { get; set; }
        public virtual Department Department { get; set; }
        public string  progLang { get; set; }
    }
}
