using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace StudentInfo.Model
{
    [Table("tbl_department")]
    public class Department
    {
        [Key]
        public long DepartmentID { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set;}

    }
}
