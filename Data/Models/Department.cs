using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abanking_employees.Data.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public int floor { get; set; }
        public List<Employee> employees { get; set; }
    }
}
