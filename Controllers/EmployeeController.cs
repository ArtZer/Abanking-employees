using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abanking_employees.Data.Interfaces;
using Abanking_employees.Data.Models;
using Abanking_employees.Data;
using Abanking_employees.Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using Abanking_employees.Data.ViewModels;

namespace Abanking_employees.Controllers
{
    public class EmployeeController: Controller
    {
        private readonly IListEmployee _listEmployee;
        private readonly IListDepartment _listDepartment;

        public EmployeeController(IListEmployee ile, IListDepartment listDepartment )
        {
            _listEmployee = ile;
            _listDepartment = listDepartment;
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            AppDBContext db = new AppDBContext();

            List<Department> department = new List<Department>();
            department = db.departments.ToList();
            ViewBag.department = department;

            List<ProgrammingLanguage> progLang = new List<ProgrammingLanguage>();
            progLang = db.progLang.ToList();
            ViewBag.progLang = progLang;

            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee employee, char sex, string Dep, string ProgLang)
        {
            AppDBContext db = new AppDBContext();

            employee.sex = sex;
            var dep = db.departments.Single(d => d.name == Dep);
            employee.IdDepartment = dep.id;
            var pLang = db.progLang.Single(p => p.name == ProgLang);
            employee.IdProgLang = pLang.id;
            db.Entry(employee).State = EntityState.Added;
            db.SaveChanges();

            return RedirectPermanent("/Home/index");
        }
    }
}
