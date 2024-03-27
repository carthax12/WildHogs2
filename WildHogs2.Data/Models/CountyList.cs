using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class CountyList
{
    public int Id { get; set; }

    public string? County { get; set; }

    public int CountyCode { get; set; }
}
