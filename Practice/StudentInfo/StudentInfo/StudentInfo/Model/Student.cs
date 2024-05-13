using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace StudentInfo.Model
{
    [Table("tbl_student")]
    public class Student
    {
        [Key]
        public long StudentID { get; set; }
        [ForeignKey("tbl_department")]
        public long DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }

    }
}
