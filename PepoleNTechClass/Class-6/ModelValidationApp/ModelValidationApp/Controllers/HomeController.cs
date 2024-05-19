using Microsoft.AspNetCore.Mvc;
using ModelValidationApp.Models;
using System.Diagnostics;

namespace ModelValidationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeInfo(Employee objEmployee)
        {
            if (ModelState.IsValid)
            {
                return Content("Model Is Valid");
            }
            else
            {
                ViewBag.msg = "Sorry! Model is not valid.";
                return View(objEmployee);
            }
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
