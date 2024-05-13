using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeManager.Models
{
    public partial class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }

        //public virtual Applicant Applicant { get; set; }
        [Required]
        public string CompanyName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        [Required]
        public int YearsWorked { get; set; }
    }
}
