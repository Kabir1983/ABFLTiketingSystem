using Microsoft.AspNetCore.Mvc;
using StudentInfo.Data;

namespace StudentInfo.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDBContext _context;

        public StudentController(StudentDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getStudents")]
        public IActionResult Index()
        { 
            var studentList = _context.Students.ToList();
            return Ok(studentList);
        }
    }
}
