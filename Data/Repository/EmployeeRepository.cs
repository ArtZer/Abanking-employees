using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Interfaces;
using Abanking_employees.Data.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Abanking_employees.Data.Repository
{
    public class EmployeeRepository : IListEmployee
    {
        private AppDBContext appDBContext;

        public EmployeeRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Employee> Employee => appDBContext.employees.Include(d => d.Department);
        public void CreateEmployee(Employee employee)
        {
            appDBContext.employees.Add(employee);

            var item = appDBContext.employees;
            foreach(var el in item)
            {
                var i = new Employee
                {
                    firstName = el.firstName,
                    lastName = el.lastName,
                    age = el.age,
                    sex = el.sex
                };
            }

            appDBContext.SaveChanges();
        }

        public void EditeEmployee(Employee employee, int id)
        {
            appDBContext.employees.Add(employee);

            var item = appDBContext.employees;
            foreach (var el in item)
            {
                if (el.id == id)
                {
                    var i = new Employee
                    {
                        firstName = el.firstName,
                        lastName = el.lastName,
                        age = el.age,
                        sex = el.sex
                    };
                }                
            }

            appDBContext.SaveChanges();
        }
    }
}
