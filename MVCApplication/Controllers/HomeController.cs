using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult EmployeList()
        {
            Employee emp = new Employee()
            {
                employeeID = 1,
                employeeName = "Dinesh",
                Address = "Hyderabad",
        };
            return View(emp);
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
    }
}