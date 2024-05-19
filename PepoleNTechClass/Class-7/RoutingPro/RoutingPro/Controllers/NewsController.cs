using Microsoft.AspNetCore.Mvc;

namespace RoutingPro.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Article(int year, int month, int day, int pageno, int contentId)
        {
            try
            {
                DateTime dt = new DateTime(year, month, day);

                ViewBag.date = "Date of Publication: " + dt.ToString("MMMM dd, yyyy");
                ViewBag.page = "Page No." + pageno.ToString();
                ViewBag.cid = "Content ID : " + contentId.ToString();
                ViewBag.err = false;
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.err = true;
                ViewBag.msg = ex.Message;
                return View();
            }
        }

        public IActionResult Page(int year, int month, int day, int pageno)
        {
            try
            {
                DateTime dt = new DateTime(year, month, day);

                ViewBag.date = "Date of Publication: " + dt.ToString("MMMM dd, yyyy");
                ViewBag.page = "Page No." + pageno.ToString();
                ViewBag.err = false;
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.err = true;
                ViewBag.msg = ex.Message;
                return View();
            }
        }
    }
}
