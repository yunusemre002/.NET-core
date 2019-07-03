using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    //localhost:5000/course
    public class CourseController:Controller
    {
        //action method
        //localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            //return View("Myview"); // boyle yaparsam details sayfa icerigini View/Course altında degil Myview/Course altında arar. Yani parametre gonderdik
 
            var course = new Course();
            course.Name = "Course Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }


        public IActionResult Apply()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        //action method
        //localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            return View();
        }
    }
}