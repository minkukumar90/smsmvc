using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using smsmvc.Models;

namespace smsmvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        public ActionResult Index()
        {
            //return View();

            //var studentList = new List<StudentModels>{
            //    new StudentModels() {StudentId = 1, StudentName = "Minku Kumar", StudentAddress = "New Delhi", StudentMobileNo = "9911858753"},
            //    new StudentModels() {StudentId = 2, StudentName = "Sachin Sir", StudentAddress = "Dwarka", StudentMobileNo = "7172737475"},
            //     new StudentModels() {StudentId = 3, StudentName = "Anshu Sir", StudentAddress = "Palam", StudentMobileNo = "8888899999"}
            //};
            return View(studentList); 
        }

            List<StudentModels> studentList = new List<StudentModels>{
                new StudentModels() {Id = 1, StudentName = "Minku Kumar", StudentAddress = "New Delhi", StudentMobileNo = "9911858753"},
                new StudentModels() {Id = 2, StudentName = "Sachin Sir", StudentAddress = "Dwarka", StudentMobileNo = "7172737475"},
                 new StudentModels() {Id = 3, StudentName = "Anshu Sir", StudentAddress = "Palam", StudentMobileNo = "8888899999"}
            };
            
        public ActionResult Edit(int id)
            {
                var std = studentList.Where(s => s.Id == id).FirstOrDefault();
                return View(std);
            }

       













       

       
        //public string  Index()
        //{
        //    // return View();
        //    return "This is Index action method of StudentController class";
        //}
    }
}