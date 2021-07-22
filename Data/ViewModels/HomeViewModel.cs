using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Models;

namespace Abanking_employees.Data.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Employee> AllEmployee { get; set; }
    }
}
