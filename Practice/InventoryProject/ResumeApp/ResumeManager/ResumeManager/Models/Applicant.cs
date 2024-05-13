using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeManager.Models
{
    public partial class Applicant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = null!;
        [Required]
        [Range(25,55,ErrorMessage ="Currently, We have no position vacant for your age.")]
        [DisplayName("Age in Years")]
        public int Age { get; set; }

        [Required]
        [StringLength(150)]
        public string Qualification { get; set; } = null!;

        [Required]
        [Range(1,25, ErrorMessage = "Currently, We have no position vacant for your experience.")]
        [DisplayName("Total Experience in Years")]
        public int TotalExperience { get; set; }

        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();

        public string PhotoUrl { get; set; }

        [Required(ErrorMessage ="Please Choose the Profile Photo")]
        [Display(Name ="Profile Photo")]
        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }
    }
}
