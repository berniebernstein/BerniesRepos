using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

using DataLibrary;
using DataLibrary.BusnissLogic;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Signup()
        {
            ViewBag.Message = "Employee Sign Up";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = EmployeeProcessor.CreateEmployee(model.EmployeeId, 
                    model.FirstName, 
                    model.LastName, 
                    model.EmailAddress);

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}