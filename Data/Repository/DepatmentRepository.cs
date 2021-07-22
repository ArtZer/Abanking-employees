using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Models;
using Microsoft.EntityFrameworkCore;
using Abanking_employees.Data.Interfaces;
using Abanking_employees.Data.Models;

namespace Abanking_employees.Data.Repository
{
    public class DepatmentRepository : IListDepartment
    {
        private readonly AppDBContext appDBContext;

        public DepatmentRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Department> ALLDepartments => appDBContext.departments;
    }
}
