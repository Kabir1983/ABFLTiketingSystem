using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeManager.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }

        public virtual Applicant Applicant { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set;}

        [Required]
        public int YearsWorked { get; set; }

    }
}
