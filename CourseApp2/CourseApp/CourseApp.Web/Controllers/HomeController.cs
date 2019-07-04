using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {      
        public IActionResult Index()
        {
            return View(); //Home/Index yazısı geldi. Çünkü View klasörü içindeki home içideki index.cshtml sayfasını çağırdı.
            //return Content("Hello World.");  //helo word yazdık.
            //return NotFound();  // sayfa Bulunamadı hatası 
            //return new EmptyResult();      //Boş sayfa döner geriye
            //return RedirectToAction("List","Home",new { id=5,sortBy="name"});    //Home altındaki List fonksiyonuna/actionuna yönlendirdi id sortby name parametrelerinide beraberinde gönderdi
        }

        public IActionResult List()
        {
            return View();
        }
    }
}