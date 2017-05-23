using StudentApplicationForm.DAL;
using StudentApplicationForm.Migrations;
using StudentApplicationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApplicationForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (! System.IO.File.Exists($"{path}\\creds.txt"))
            {
                return RedirectToAction("InitialSetup");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(Student model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            using (var context = new StudentAppDbContext())
            {
                context.Students.Add(new Student
                {
                    StdName = model.StdName,
                    StdSex = model.StdSex,
                    StdAddr = model.StdAddr,
                    StdDOB = model.StdDOB,
                    StdNat = model.StdNat
                });
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public ActionResult InitialSetup()
        {
            return View(new InitialSetup());
        }

        [HttpPost]
        public ActionResult InitialSetup(InitialSetup setup)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
           
            var conString = $"Data Source={setup.ServerName};Initial Catalog={setup.DatabaseName};Persist Security Info=True;";

            if (setup.IntegratedSecurity)
            {
                conString += "Integrated Security = true;";
            }
            else
            {
                conString += $"User ID={setup.Username};Password={setup.Password};";
            }
           
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.File.AppendAllText(path+ "\\creds.txt", conString);

            using (var context = new StudentAppDbContext())
            {
                context.Logs.Add(new Log
                {
                    Message="Initial setup completed"
                });
                context.SaveChanges();
            }
                return RedirectToAction("Index");
        }
    }
}