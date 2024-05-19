using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee Name Is Required")]
        [StringLength(150)]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Designation Is Required")]
        [StringLength(150)]
        public string Designation { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Range(1300000000, 1999999999)]
        public long PhoneNumber { get; set; }
        [Url]
        public string? Website { get; set; }
        [Range(10000,999999)]
        public double Salary { get; set; }
        [DisplayName("Is Regular Employee?")]
        public bool IsRegularEmployee { get; set; }

    }
}
