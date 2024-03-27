using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class OfficersByRegion
{
    public int Id { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public byte Region { get; set; }

    public string Email { get; set; } = null!;

    public string? OfficerId { get; set; }

    public string? FullName { get; set; }
}
