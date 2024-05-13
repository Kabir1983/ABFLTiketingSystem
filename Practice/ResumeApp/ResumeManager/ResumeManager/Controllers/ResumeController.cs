using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResumeManager.Data;
using ResumeManager.Models;

namespace ResumeManager.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;

        public ResumeController(ResumeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Applicant> applicants = new List<Applicant>();

            applicants = _context.Applicants.ToList();

            return View(applicants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Applicant applicant = new Applicant();
            applicant.Experiences.Add(new Experience() { Id = 1 });
            //applicant.Experiences.Add(new Experience() { Id = 2 });
            //applicant.Experiences.Add(new Experience() { Id = 3 });

            ViewBag.Gender = GetGenderList();
            ViewBag.CountryList = CountryList();
            CountryList();

            return View(applicant);
        }
        [HttpPost]
        public IActionResult Create(Applicant applicant)
        {
            foreach (Experience experience in applicant.Experiences)
            {
                if (experience.CompanyName == null || experience.CompanyName.Length == 0)
                {
                    applicant.Experiences.Remove(experience);
                }
            }

            _context.Add(applicant);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Details(int Id)
        {
            Applicant applicant = _context.Applicants.Include(x => x.Experiences).Where(x => x.Id == Id).FirstOrDefault();
            return View(applicant);
        }


        public List<SelectListItem> GetGenderList()
        {
            List<SelectListItem> genderList = new List<SelectListItem>();

            var selItem = new SelectListItem() { Value = null, Text = "Select Gender" };
            genderList.Add(selItem);

            selItem = new SelectListItem() { Value = "Male", Text = "Male" };
            genderList.Add(selItem);
            selItem = new SelectListItem() { Value = "Female", Text = "Female" };
            genderList.Add(selItem);

            return genderList;

        }

        public SelectList CountryList()
        {
            var CountryList = new SelectList(_context.Countries, "Id", "Name");
            return CountryList;
        }

        public JsonResult Country()
        {
            var Ctn = _context.Countries.ToList();
            return Json(Ctn);
        }

        public JsonResult City(int countryID)
        {
            var Ctn = _context.Cities.Where(m => m.CountryID == countryID).ToList();
            return Json(Ctn);
        }


        public List<SelectListItem> CityList()
        {
            List<SelectListItem> CityList = new List<SelectListItem>();
            var selItem = new SelectListItem() { Value = null, Text = "Select City" };
            CityList.Add(selItem);
            selItem = new SelectListItem() { Value = "1", Text = "Dhaka" };
            CityList.Add(selItem);
            selItem = new SelectListItem() { Value = "2", Text = "CTG" };
            CityList.Add(selItem);
            selItem = new SelectListItem() { Value = "3", Text = "Cumilla" };
            CityList.Add(selItem);
            selItem = new SelectListItem() { Value = "3", Text = "Cumilla" };
            CityList.Add(selItem);
            return CityList;
        }
    }
}
