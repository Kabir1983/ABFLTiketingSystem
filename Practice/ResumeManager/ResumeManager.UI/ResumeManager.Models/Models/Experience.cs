using System;
using System.Collections.Generic;

namespace ResumeManager.Models.Models
{
    public partial class Experience
    {
        public int ExperienceId { get; set; }
        public int ApplicantId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Designation { get; set; }
        public int YearsWorked { get; set; }
    }
}
