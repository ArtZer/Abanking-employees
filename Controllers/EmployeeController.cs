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

        //public IActionResult Add()
        //{
        //    var AddEmployeeViewModel = new AddEmployeeViewModel //Возможно не надо
        //    {
        //        Employee = _listEmployee.Employee,
        //        Department = _listDepartment.ALLDepartments
        //    };
        //    return View(AddEmployeeViewModel);
        //}

        public ActionResult Edit() // пользователю представление с формой для заполнение
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add() // пользователю представление с формой для заполнение
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
        public ActionResult Add(Employee employee) //принимает данные с формы заполненной пользователем
        {
            AppDBContext db = new AppDBContext();

            db.Entry(employee).State = EntityState.Added;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
