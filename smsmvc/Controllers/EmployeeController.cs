using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using smsmvc.Models;

namespace smsmvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
       
        public ActionResult Details()
        {
            EmployeeContext context = new EmployeeContext();
            List<EmployeeDetailsModels> employeelist = context.employee.ToList();
            return View(employeelist);
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}