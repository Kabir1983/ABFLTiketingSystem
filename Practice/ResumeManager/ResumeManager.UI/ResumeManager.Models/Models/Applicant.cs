using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ResumeManager.Models.Models
{
    public partial class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Qualification { get; set; } = null!;
        public int TotalExperience { get; set; }
        public string? PhotoUrl { get; set; }

        [Required(ErrorMessage = "Please Choose the Profile Photo")]
        [Display(Name = "Profile Photo")]
        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }
    }
}
