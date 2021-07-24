using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abanking_employees.Data.Interfaces;
using Abanking_employees.Data.Models;
using Abanking_employees.Data;
using Abanking_employees.Data.ViewModels;
using Abanking_employees.Data.Repository;

namespace Abanking_employees.Controllers
{
    public class HomeController: Controller
    {
        private readonly IListEmployee _listEmployee;

        public HomeController(IListEmployee ile)
        {
            _listEmployee = ile;
        }

        public ViewResult Index()
        {
            AppDBContext db = new AppDBContext();

            List<Department> departments = new List<Department>();            
            departments = db.departments.ToList();            
            ViewBag.departments = departments;

            List<ProgrammingLanguage> progLang = new List<ProgrammingLanguage>();
            progLang = db.progLang.ToList();
            ViewBag.progLang = progLang;

            var homeEmployees = new HomeViewModel
            {
                AllEmployee = _listEmployee.Employee
            };

            return View(homeEmployees);
        }
    }
}
