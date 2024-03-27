using System;
using System.Collections.Generic;

namespace WildHogs2.Models;

public partial class Owner
{
    public int LandOwnerId { get; set; }

    public string? FnameL { get; set; }

    public string? LnameL { get; set; }

    public string? StreetL { get; set; }

    public string? CityL { get; set; }

    public string? StateL { get; set; }

    public string? ZipL { get; set; }

    public string? PhoneL { get; set; }

    public string? EmailL { get; set; }

    public string? SubmitterL { get; set; }

    public string? Address2L { get; set; }

    public string? CountyL { get; set; }

    public string? Region { get; set; }

    public string? Business { get; set; }

    public string? Notes { get; set; }

    public bool? RecordDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
