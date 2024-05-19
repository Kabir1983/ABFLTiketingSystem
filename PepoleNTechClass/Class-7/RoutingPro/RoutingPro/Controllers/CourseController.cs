using Microsoft.AspNetCore.Mvc;

namespace RoutingPro.Controllers
{
    [Route("[controller]")]
    public class CourseController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("StdList")]
        public IActionResult Students(string org, string course, int batchno)
        {
            if (string.IsNullOrEmpty(org))
            {
                ViewBag.msg = "Please enter Organization Name";
                return View();
            }
            
            if (string.IsNullOrEmpty(course))
            {
                ViewBag.msg = "Please enter Course Name";
                return View();
            }
            
            org = org.ToUpper();
            if (org == "BITM")
            {
                org = "BASIS BITM";
            }
            else if (org == "PNT")
            {
                org = "People N Tech";
            }
            else
            {
                org = "Others";
            }

            ViewBag.org= "Organization Name : " +org;
            ViewBag.course= "Course Title: "  + course;
            ViewBag.batchno= "Batch No:" + batchno;

            return View();
        }
    }
}
