using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class Permit
{
    public int? Exemption { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Location { get; set; }

    public int? Landowner { get; set; }

    public int OfficerId { get; set; }

    public string? County { get; set; }

    public string? Map { get; set; }

    public string? Parcel { get; set; }

    public string? Acreage { get; set; }

    public int? Year { get; set; }

    public string? Submitter { get; set; }

    public string? Region { get; set; }

    public string? Notes { get; set; }

    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? RecordDeleted { get; set; }

    public string? NotificationType { get; set; }

    public DateTime? NotificationDate { get; set; }

    public string? NotificationSender { get; set; }
}
