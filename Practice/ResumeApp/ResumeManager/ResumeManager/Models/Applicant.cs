using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ResumeManager.Models
{
    public class Applicant
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [Required]
        [StringLength (100)]
        public string Country { get; set; }
        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [Range(25, 55, ErrorMessage ="Currently, We have no position vacant for your age")]
        [DisplayName("Age in Years")]
        public int Age { get; set;}

        [Required]
        [StringLength(100)]
        public string Qualification { get; set; }

        [Required]
        [Range(3, 5, ErrorMessage = "Currently, We have no position vacant for you")]
        [DisplayName("Total Experience In Years")]
        public int TotalExperience { get; set; }

        public virtual List<Experience> Experiences { get; set; } = new List<Experience>();


    }
}
