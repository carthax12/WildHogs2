using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class Exemption
{
    public int? ExemNo { get; set; }

    public double? ELandownerId { get; set; }

    public string? ExemYear { get; set; }

    public DateTime? EStart { get; set; }

    public DateTime? EEnd { get; set; }

    public int Id { get; set; }
}
