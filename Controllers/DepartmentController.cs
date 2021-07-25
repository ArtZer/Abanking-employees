using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abanking_employees.Data;
using Abanking_employees.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Abanking_employees.Controllers
{
    public class DepartmentController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            AppDBContext db = new AppDBContext();

            return View();
        }

        [HttpPost]
        public ActionResult Add(Department department)
        {
            AppDBContext db = new AppDBContext();

            db.Entry(department).State = EntityState.Added;
            db.SaveChanges();

            return RedirectPermanent("/Home/index");
        }
    }
}
