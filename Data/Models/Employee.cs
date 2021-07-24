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
        public int IdDepartment { get; set; }
        public Department Department { get; set; }
        public int IdProgLang { get; set; }
        public ProgrammingLanguage ProgLang { get; set; }
    }
}
