using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class ExempKillDatum
{
    public int Id { get; set; }

    public int? ExemptionNumber { get; set; }

    public DateTime? IssueDate { get; set; }

    public int? KillCount { get; set; }

    public int? Trapping { get; set; }

    public decimal? Shooting { get; set; }

    public int? Dogs { get; set; }

    public decimal? Other { get; set; }

    public int? NoIndication { get; set; }

    public string? Notes { get; set; }

    public string? Species { get; set; }

    public double? ELandowner { get; set; }

    public string? ExemYear { get; set; }

    public string? NoData { get; set; }

    public int? MethodOfDisposal { get; set; }

    public bool RecordDeleted { get; set; }

    public bool? AttemptedToKillHogs { get; set; }
}
