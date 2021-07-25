using Abanking_employees.Data;
using Abanking_employees.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abanking_employees.Controllers
{
    public class ProgrammingLanguageController : Controller
    {
        [HttpGet]
        public ActionResult Add()
        {
            AppDBContext db = new AppDBContext();

            return View();
        }

        [HttpPost]
        public ActionResult Add(ProgrammingLanguage progLang)
        {
            AppDBContext db = new AppDBContext();

            db.Entry(progLang).State = EntityState.Added;
            db.SaveChanges();

            return RedirectPermanent("/Home/index");
        }
    }
}
