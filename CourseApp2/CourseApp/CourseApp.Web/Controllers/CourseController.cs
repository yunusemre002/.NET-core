using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;       
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

namespace CourseApp.Web.Controllers
{
    //course
    public class CourseController : Controller
    {
        public ActionResult ByReleased(int year, int mounth)
        {
            return Content("year : " +year + "  mounth : "+ mounth);
        }

        public ActionResult Details(int id, string sortby)
        {
            return Content("id= "+id + "sort by : "+sortby);
        }

        public ActionResult CourseList(int? pageindex, string sorted)
        {
            if (!pageindex.HasValue)
            {
                pageindex=1;
            }
            if(string.IsNullOrWhiteSpace(sorted))
            {
                sorted="name";
            }
            return Content("pageindex= "+ pageindex + "  sort type : " +sorted);
        }

        //course/index
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon" : "Good morning";

            return View("MyView");
        }

        //course/list
        public ViewResult List()
        {
            var liste=  Repository.Students.Where(i => i.WillAttend == true);
            return View(liste);
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }

          
        }
    }
}