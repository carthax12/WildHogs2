using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class Log
{
    public long Id { get; set; }

    public DateTime LogDate { get; set; }

    public TimeSpan LogTime { get; set; }

    public string Message { get; set; } = null!;

    public bool IsError { get; set; }

    public string? AppVersion { get; set; }
}
