using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abanking_employees.Data.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Display]
        public string firstName { get; set; }
        [Display]
        public string lastName { get; set; }
        [Display]
        public int age { get; set; }
        [Display]
        public char sex { get; set; }
        [Display]
        public int IdDepartment { get; set; }
        public Department Department { get; set; }
        [Display]
        public int IdProgLang { get; set; }
        public ProgrammingLanguage ProgLang { get; set; }
    }
}
