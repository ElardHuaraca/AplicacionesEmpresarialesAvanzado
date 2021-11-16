using Domain;
using Lab12.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab12.Controllers
{
    public class StudentController : Controller
    {
        private StudentService studentService = new StudentService();
        // GET: Student
        public ActionResult IndexRazor()
        {
            var model = (from c in studentService.Get()
                         select new StudentModel
                         {
                             ID = c.studentId,
                             Address = c.studentAddress,
                             Name = c.studentName
                         });
            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getStudent(string id)
        {
            return Json(studentService.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult createStudent(Student std)
        {
            studentService.Insert(std);
            string msg = "SUCCESS";
            return Json(new { Message = msg, JsonRequestBehavior.AllowGet });
        }
    }
}