using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smsmvc.Controllers
{
    public class UserController : Controller
    {
       //  GET: User
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(StudentRegistration U)
        {
            if(ModelState.IsValid)
            {
                using(userEntities dc = new userEntities())
                {
                    dc.StudentRegistrations.Add(U);
                    dc.SaveChanges();
                    U = null;
                    ViewBag.Message = "Registration Successfully..";
                }
                
               
            }
            return View(U);
        }

        public ActionResult Login()
        {
            return View();
        }
    
    }
}