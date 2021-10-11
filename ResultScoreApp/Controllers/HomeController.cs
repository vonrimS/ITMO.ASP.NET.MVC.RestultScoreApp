using ResultScoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ResultScoreApp.Controllers
{
    public class HomeController : Controller
    {
        ResultScoreAppContext db = new ResultScoreAppContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetStudents()
        {
           

            var studentViewModel = from st in db.Students.OrderBy(m=>m.LastName).ToList()                             
                                   join sc in db.Scores
                                   on st.ScoreId equals sc.Id
                                   into st2
                                   from sc in st2.DefaultIfEmpty()
                                   select new StudentVeiwModel { studentVm = st, scoreVm = sc };
           
            return View(studentViewModel);
        }


        [HttpGet]
        public ActionResult CreateStudent()
        {      
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(Student student)
        {
            db.Students.Add(student);
            db.Students.OrderBy(p => p.LastName);
            db.SaveChanges();

            return RedirectToAction("GetStudents");
        }

        public ActionResult Edit()
        {
            return View();
        }

         

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}