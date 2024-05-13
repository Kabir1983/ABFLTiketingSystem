using App4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App4.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Management()
        {
            return View();
        }

        public IActionResult Sales()
        {
            return View();
        }

        public IActionResult HR()
        {
            return View();
        }

        public IActionResult Agency()
        {
            return View();
        }

        public IActionResult JobPortal()
        {
            return View();
        }

        public IActionResult RedirectAction()
        {
            return RedirectToAction("Privacy");
        }

        public ContentResult ContentData(string uText)
        {
            return Content($"This action method {uText} is content result method.");
        }

        public JsonResult JsonData()
        {
            return Json(new { id = 1, name = "JSON Data", msg = "JSON Data Showing." });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
