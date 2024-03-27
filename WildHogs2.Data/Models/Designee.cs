using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class Designee
{
    public int LandownerId { get; set; }

    public int? PermitNo { get; set; }

    public string? FnameD { get; set; }

    public string? LnameD { get; set; }

    public string? FullNameD { get; set; }

    public DateTime? CrtDateD { get; set; }

    public string? EnteredBy { get; set; }

    public string? ExpYear { get; set; }

    public DateTime? Expiration { get; set; }

    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool RecordDeleted { get; set; }
}
