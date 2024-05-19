using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABFL.TicketSystemApp.Models;

public partial class SetMistakeType
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Mistake Type Is Required")]
    [Display(Name = "Mistake Type")]
    public string TypeName { get; set; } = null!;

    public string? Description { get; set; }
    [Required]
    public bool IsActive { get; set; }
    [Required]
    public DateTime LastUpdate { get; set; }

    public virtual ICollection<AddDailyMistake> AddDailyMistakes { get; set; } = new List<AddDailyMistake>();
}
