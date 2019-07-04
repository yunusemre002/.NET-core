using System.Linq;
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

        [HttpGet]  // yazmasanda burada buyazıyor.
        public IActionResult Apply()
        {
          return View();
        }

        // localhost: 5000/course/apply method:POST
        // Name=value&Email=value&Phone=value&Confirm=value

        [HttpPost] // FORMDAN Servera bir bilgi gönderiyoruz. 

        public IActionResult Apply(Student student )
        {
          //Model binding
          //database kayıt
          if (ModelState.IsValid)
          {
            Repository.AddStudent(student);
            return View("Thanks", student);
          }
          else{
              return View(student); //kullanıcının girdiği hatalı bilgilerde view üzerine taşınsın kullanıcı hatalrının görebilsin.
          }
         
        }

        //action method
        //localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            var students = Repository.Students.Where(i=>i.Confirm==true);
            return View(students);
        }
    }
}