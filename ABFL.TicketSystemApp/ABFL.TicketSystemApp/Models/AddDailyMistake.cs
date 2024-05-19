using System;
using System.Collections.Generic;

namespace ABFL.TicketSystemApp.Models;

public partial class AddDailyMistake
{
    public long Id { get; set; }

    public DateOnly Date { get; set; }

    public int MistakeTypeId { get; set; }

    public int SoleDepotId { get; set; }

    public int AreaId { get; set; }

    public int ResPersonId { get; set; }

    public string ResPersonName { get; set; } = null!;

    public string? ResPhoneNo { get; set; }

    public int ItofficerId { get; set; }

    public string ItofficerName { get; set; } = null!;

    public string ItofficerPhoneNo { get; set; } = null!;

    public string MistakeReason { get; set; } = null!;

    public string SolutionGuideLine { get; set; } = null!;

    public string? AttachmentUrl { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreateAt { get; set; }

    public DateTime UpdateAt { get; set; }

    public virtual SetMistakeType MistakeType { get; set; } = null!;
}
