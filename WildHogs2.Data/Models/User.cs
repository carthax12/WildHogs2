using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class User
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Bhnumber { get; set; }

    public bool RecordDeleted { get; set; }

    public int? RoleId { get; set; }

    public int Id { get; set; }
}
