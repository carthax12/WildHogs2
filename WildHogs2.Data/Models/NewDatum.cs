using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class NewDatum
{
    public string? ExemptionNo { get; set; }

    public string? PType { get; set; }

    public string? PLat { get; set; }

    public string? PLong { get; set; }

    public DateTime? PStart { get; set; }

    public DateTime? PEnd { get; set; }

    public string? PropHuntAllowed { get; set; }

    public string? Species { get; set; }

    public string? Notes { get; set; }

    public string? Location { get; set; }

    public string? LandownerId { get; set; }

    public string? OfficerId { get; set; }

    public string? County { get; set; }

    public string? IssueDate { get; set; }

    public string? CountyName { get; set; }

    public string? Map { get; set; }

    public string? Parcel { get; set; }

    public string? OfficerName { get; set; }

    public string? Acerage { get; set; }

    public string? PRegion { get; set; }

    public string PYear { get; set; } = null!;

    public string? PSubmitter { get; set; }

    public string? DeleteRecord { get; set; }

    public string? PermitAsNumber { get; set; }

    public string? DRecord { get; set; }
}
