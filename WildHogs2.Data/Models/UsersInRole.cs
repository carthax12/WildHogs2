using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class UsersInRole
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int UserId { get; set; }
}
