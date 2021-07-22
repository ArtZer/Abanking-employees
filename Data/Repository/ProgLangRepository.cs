using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Models;
using Microsoft.EntityFrameworkCore;
using Abanking_employees.Data.Interfaces;

namespace Abanking_employees.Data.Repository
{
    public class ProgLangRepository
    {
        private readonly AppDBContext appDBContext;

        public ProgLangRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<ProgrammingLanguage> progLang => appDBContext.progLang.Include(c => c);
    }
}
