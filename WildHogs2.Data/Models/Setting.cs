using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class Setting
{
    public int Id { get; set; }

    public string? ConfigName { get; set; }

    public string? ConfigValue { get; set; }

    public string? LastUpdated { get; set; }

    public string? Notes { get; set; }
}
