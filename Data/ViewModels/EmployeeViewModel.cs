using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Models;

namespace Abanking_employees.Data.ViewModels
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }
        public string ProgLang { get; set; }
    }
}
