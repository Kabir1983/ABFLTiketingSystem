using System.ComponentModel.DataAnnotations;

namespace EMPPro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public decimal Salary { get; set; }

        public EmployeeType EmployeeType { get; set; }
        public Position Position { get; set; }

    }


    public enum EmployeeType
    {
        [Display(Name = "Freelance")]
        Freelance,
        [Display(Name = "Casual")]
        Casual,
        [Display(Name = "Part Time")]
        PartTime,
        [Display(Name = "Full Time")]
        FullTime
    }

    public enum Position
    {
        [Display(Name = "CEO")]
        CEO,
        [Display(Name = "CFO")]
        CFO,
        [Display(Name = "CTO")]
        CTO,
        [Display(Name = "Accountant")]
        Accountant,
        [Display(Name = "HR Manager")]
        HRManager,
        [Display(Name = "Software Developer")]
        SoftwareDeveloper,
        [Display(Name = "Data Analysist")]
        DataAnalysist,
        [Display(Name = "Graphics Designer")]
        GraphicsDesigner
    }
}
