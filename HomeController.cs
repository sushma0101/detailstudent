using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)//COnstructor
        {
            _logger = logger;
        }

        public IActionResult Index()//return type
        {
            return RedirectToAction("privacy");
        }

        public ViewResult Privacy()
        {
            return View();
        }
        public ContentResult Sushma()
        {
            //return View();
          
            return Content("the user is Sushma Sapkota.");
        }
      
        public JsonResult Aboutme() {
            // return RedirectToAction("Index");
            return Json(new { name = "sushma" }) ;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public FileResult Download()
        {
            return File("Myfiles/hello.docx", "text/plain", "hello.docx");

        }
    }
}