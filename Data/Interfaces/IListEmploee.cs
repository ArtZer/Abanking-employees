using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Models;

namespace Abanking_employees.Data.Interfaces
{
    public interface IListEmployee
    {
        IEnumerable<Employee> Employee { get; }
        void CreateEmployee(Employee employee);
    }
}
