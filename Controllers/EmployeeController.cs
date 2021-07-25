using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abanking_employees.Data.Interfaces;
using Abanking_employees.Data.Models;
using Abanking_employees.Data;
using Abanking_employees.Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using Abanking_employees.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Abanking_employees.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IListEmployee _listEmployee;
        private readonly IListDepartment _listDepartment;

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
        public ActionResult Add(Employee employee, string name, char sex, string Dep, string ProgLang)
        {
            AppDBContext db = new AppDBContext();

            employee.firstName = name;
            employee.sex = sex;
            var dep = db.departments.Single(d => d.name == Dep);
            employee.IdDepartment = dep.id;
            var pLang = db.progLang.Single(p => p.name == ProgLang);
            employee.IdProgLang = pLang.id;
            db.Entry(employee).State = EntityState.Added;
            db.SaveChanges();

            return RedirectPermanent("/Home/index");
        }

        [HttpGet]
        public ActionResult Edit(int idEmp)
        {
            AppDBContext db = new AppDBContext();

            var employee = db.employees.Single(e => e.id == idEmp);
            ViewBag.employee = employee;

            List<Department> department = new List<Department>();
            department = db.departments.ToList();
            ViewBag.department = department;

            List<ProgrammingLanguage> progLang = new List<ProgrammingLanguage>();
            progLang = db.progLang.ToList();
            ViewBag.progLang = progLang;

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Employee employee, string Dep, string ProgLang, int id)
        {
            AppDBContext db = new AppDBContext();
            employee.id = id;
            var dep = db.departments.Single(d => d.name == Dep);
            employee.IdDepartment = dep.id;
            var pLang = db.progLang.Single(p => p.name == ProgLang);
            employee.IdProgLang = pLang.id;        
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectPermanent("/Home/index");
        }

        public ActionResult Delete(int idEmp)
        {
            AppDBContext db = new AppDBContext();

            var employee = db.employees.Single(e => e.id == idEmp);
            ViewBag.employee = employee;

            db.Entry(employee).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectPermanent("/Home/index");
        }
    }
}
