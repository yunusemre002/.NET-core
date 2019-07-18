using System.Linq;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    // localhost:5000/course
    public class MemtextController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // localhost:5000/course/apply
        [HttpGet]
        public IActionResult ApplyMemtext()
        {
            return View();
        }

        // localhost:5000/course/apply method:POST
        // Name=value&Email=value&Phone=value&Confirm=value
        [HttpPost]
        public IActionResult ApplyMemtext(SutunMemtext sutun)
        {
            if (ModelState.IsValid)
            {
                RepositoryMemtext.AddSutunMemtext(sutun);
                return View("Thanks", sutun);
            }
            else
            {
                return View(sutun);
            }

        }

       /*  public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }
*/
        // localhost:5000/course/list => course/list.cshtml

        public IActionResult List()
        {
            var sutunlar = RepositoryMemtext.Sutunlar;
            return View(sutunlar);
        }
     
    }
}