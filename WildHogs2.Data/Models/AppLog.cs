using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class AppLog
{
    public int Id { get; set; }

    public DateTime TimeStamp { get; set; }

    public string Controller { get; set; } = null!;

    public string Action { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? InnerMessage { get; set; }
}
