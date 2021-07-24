using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Models;

namespace Abanking_employees.Data.Interfaces
{
    public interface IListDepartment
    {
        IEnumerable<Department> ALLDepartments { get; }
        public Department getDepatment(int depId);
    }
}
