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
            //System.Web.Mvc.SelectList departments = new System.Web.Mvc.SelectList(db.departments);
            //ViewBag.departments = departments;

            List<Department> department = new List<Department>();
            department = db.departments.ToList();
            ViewBag.department = department;

            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee employee, char sex, Department idDep)
        {
            AppDBContext db = new AppDBContext();

            employee.sex = sex;
            employee.IdDepartment = idDep.id;
            db.Entry(employee).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Home/Index");
        }
    }
}
