using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WildHogs2.Models;

public partial class WildHogsContext : DbContext
{

    private readonly IConfiguration? _config;

    public WildHogsContext()
    {
    }

    public WildHogsContext(DbContextOptions<WildHogsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppLog> AppLogs { get; set; } = default!;

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; } = default!;

    public virtual DbSet<ControlMethod> ControlMethods { get; set; } = default!;

    public virtual DbSet<ControlNote> ControlNotes { get; set; } = default!;

    public virtual DbSet<CountyCode> CountyCodes { get; set; } = default!;

    public virtual DbSet<CountyList> CountyLists { get; set; } = default!;

    public virtual DbSet<Designee> Designees { get; set; } = default!;

    public virtual DbSet<ExemMember> ExemMembers { get; set; } = default!;

    public virtual DbSet<ExempKillDatum> ExempKillData { get; set; } = default!;

    public virtual DbSet<Exemption> Exemptions { get; set; } = default!;

    public virtual DbSet<IdentityRole> IdentityRoles { get; set; } = default!;

    public virtual DbSet<KillYear> KillYears { get; set; } = default!;

    public virtual DbSet<Log> Logs { get; set; } = default!;

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = default!;

    public virtual DbSet<NewDatum> NewData { get; set; } = default!;

    public virtual DbSet<OfficersByRegion> OfficersByRegions { get; set; } = default!;

    public virtual DbSet<Owner> Owners { get; set; } = default!;

    public virtual DbSet<Permit> Permits { get; set; } = default!;

    public virtual DbSet<Report> Reports { get; set; } = default!;

    public virtual DbSet<Role> Roles { get; set; } = default!;

    public virtual DbSet<Setting> Settings { get; set; } = default!;

    public virtual DbSet<Sheet1> Sheet1s { get; set; } = default!;

    public virtual DbSet<Test> Tests { get; set; } = default!;

    public virtual DbSet<User> Users { get; set; } = default!;

    public virtual DbSet<UsersInRole> UsersInRoles { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("Default"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("WHE");

        modelBuilder.Entity<AppLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppLogs__3214EC277C6BD60B");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Controller)
                .HasMaxLength(25)
                .IsFixedLength();
            entity.Property(e => e.InnerMessage)
                .HasMaxLength(1500)
                .IsFixedLength();
            entity.Property(e => e.Message)
                .HasMaxLength(1500)
                .IsFixedLength();
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.ApplicationUsers");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ControlMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.ControlMethods");
        });

        modelBuilder.Entity<ControlNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.ControlNotes");
        });

        modelBuilder.Entity<CountyCode>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AREA");
            entity.Property(e => e.CNo)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("C_NO");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.County)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTY");
            entity.Property(e => e.Reg)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REG");
        });

        modelBuilder.Entity<CountyList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CountyList");

            entity.Property(e => e.County)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Designee>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CrtDateD).HasColumnType("date");
            entity.Property(e => e.EnteredBy).HasMaxLength(255);
            entity.Property(e => e.ExpYear).HasMaxLength(50);
            entity.Property(e => e.Expiration).HasColumnType("date");
            entity.Property(e => e.FnameD).HasMaxLength(255);
            entity.Property(e => e.FullNameD).HasMaxLength(255);
            entity.Property(e => e.LandownerId).HasColumnName("LandownerID");
            entity.Property(e => e.LnameD).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExemMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PermitMembers");

            entity.ToTable("Exem_Members");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MFname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("M_FNAME");
            entity.Property(e => e.MLname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("M_LNAME");
            entity.Property(e => e.MName)
                .HasMaxLength(62)
                .IsUnicode(false)
                .HasColumnName("M_NAME");
            entity.Property(e => e.MRegion)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("M_REGION");
            entity.Property(e => e.MTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("M_TITLE");
            entity.Property(e => e.MemEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MEM_EMAIL");
            entity.Property(e => e.MemId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("MEM_ID");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<ExempKillDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.ExempKillData");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttemptedToKillHogs)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Dogs).HasColumnName("DOGS");
            entity.Property(e => e.ELandowner).HasColumnName("E_LANDOWNER");
            entity.Property(e => e.ExemYear)
                .HasMaxLength(4)
                .HasColumnName("EXEM_YEAR");
            entity.Property(e => e.NoData)
                .HasMaxLength(40)
                .HasColumnName("NO_DATA");
            entity.Property(e => e.NoIndication).HasColumnName("NO_INDICATION");
            entity.Property(e => e.Notes)
                .HasMaxLength(200)
                .HasColumnName("NOTES");
            entity.Property(e => e.Other)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("OTHER");
            entity.Property(e => e.Shooting)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SHOOTING");
            entity.Property(e => e.Species)
                .HasMaxLength(32)
                .HasColumnName("SPECIES");
            entity.Property(e => e.Trapping).HasColumnName("TRAPPING");
        });

        modelBuilder.Entity<Exemption>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EEnd)
                .HasPrecision(0)
                .HasColumnName("E_END");
            entity.Property(e => e.ELandownerId).HasColumnName("E_LANDOWNER_ID");
            entity.Property(e => e.EStart)
                .HasPrecision(0)
                .HasColumnName("E_START");
            entity.Property(e => e.ExemNo).HasColumnName("EXEM_NO");
            entity.Property(e => e.ExemYear)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EXEM_YEAR");
        });

        modelBuilder.Entity<IdentityRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.IdentityRoles");

            entity.Property(e => e.Id).HasMaxLength(128);
        });

        modelBuilder.Entity<KillYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.KillYears");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Errors");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AppVersion)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.LogDate).HasColumnType("date");
            entity.Property(e => e.Message)
                .HasMaxLength(1500)
                .IsFixedLength();
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_WHE.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<NewDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NEW_DATA");

            entity.Property(e => e.Acerage)
                .HasMaxLength(50)
                .HasColumnName("_ACERAGE_");
            entity.Property(e => e.County)
                .HasMaxLength(50)
                .HasColumnName("_COUNTY_");
            entity.Property(e => e.CountyName)
                .HasMaxLength(50)
                .HasColumnName("_COUNTY_NAME_");
            entity.Property(e => e.DRecord)
                .HasMaxLength(1)
                .HasColumnName("_D_RECORD_");
            entity.Property(e => e.DeleteRecord)
                .HasMaxLength(1)
                .HasColumnName("_DELETE_RECORD_");
            entity.Property(e => e.ExemptionNo)
                .HasMaxLength(50)
                .HasColumnName("_EXEMPTION_NO_");
            entity.Property(e => e.IssueDate)
                .HasMaxLength(50)
                .HasColumnName("_ISSUE_DATE_");
            entity.Property(e => e.LandownerId)
                .HasMaxLength(50)
                .HasColumnName("_LANDOWNER_ID_");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .HasColumnName("_LOCATION_");
            entity.Property(e => e.Map)
                .HasMaxLength(50)
                .HasColumnName("_MAP_");
            entity.Property(e => e.Notes)
                .HasMaxLength(300)
                .HasColumnName("_NOTES_");
            entity.Property(e => e.OfficerId)
                .HasMaxLength(50)
                .HasColumnName("_OFFICER_ID_");
            entity.Property(e => e.OfficerName)
                .HasMaxLength(50)
                .HasColumnName("_OFFICER_NAME_");
            entity.Property(e => e.PEnd).HasColumnName("_P_END_");
            entity.Property(e => e.PLat)
                .HasMaxLength(1)
                .HasColumnName("_P_LAT_");
            entity.Property(e => e.PLong)
                .HasMaxLength(1)
                .HasColumnName("_P_LONG_");
            entity.Property(e => e.PRegion)
                .HasMaxLength(50)
                .HasColumnName("_P_REGION_");
            entity.Property(e => e.PStart).HasColumnName("_P_START_");
            entity.Property(e => e.PSubmitter)
                .HasMaxLength(50)
                .HasColumnName("_P_SUBMITTER_");
            entity.Property(e => e.PType)
                .HasMaxLength(1)
                .HasColumnName("_P_TYPE_");
            entity.Property(e => e.PYear)
                .HasMaxLength(50)
                .HasColumnName("_P_YEAR_");
            entity.Property(e => e.Parcel)
                .HasMaxLength(50)
                .HasColumnName("_PARCEL_");
            entity.Property(e => e.PermitAsNumber)
                .HasMaxLength(50)
                .HasColumnName("_PERMIT_AS_NUMBER_");
            entity.Property(e => e.PropHuntAllowed)
                .HasMaxLength(50)
                .HasColumnName("_PROP_HUNT_ALLOWED_");
            entity.Property(e => e.Species)
                .HasMaxLength(50)
                .HasColumnName("_SPECIES_");
        });

        modelBuilder.Entity<OfficersByRegion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Officers__3214EC272F10007B");

            entity.ToTable("OfficersByRegion");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.OfficerId)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.LandOwnerId).HasName("PK__Owners__F2DC8C6332E0915F");

            entity.Property(e => e.LandOwnerId).HasColumnName("LandOwnerID");
            entity.Property(e => e.Address2L).HasMaxLength(255);
            entity.Property(e => e.Business).HasMaxLength(255);
            entity.Property(e => e.CityL).HasMaxLength(255);
            entity.Property(e => e.CountyL).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailL).HasMaxLength(255);
            entity.Property(e => e.FnameL)
                .HasMaxLength(255)
                .HasColumnName("FNameL");
            entity.Property(e => e.LnameL)
                .HasMaxLength(255)
                .HasColumnName("LNameL");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneL).HasMaxLength(255);
            entity.Property(e => e.Region).HasMaxLength(255);
            entity.Property(e => e.StateL).HasMaxLength(255);
            entity.Property(e => e.StreetL).HasMaxLength(255);
            entity.Property(e => e.SubmitterL).HasMaxLength(255);
            entity.Property(e => e.ZipL).HasMaxLength(255);
        });

        modelBuilder.Entity<Permit>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acreage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.County)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Location)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.Map)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NotificationDate).HasColumnType("datetime");
            entity.Property(e => e.Parcel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecordDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.Submitter)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.Reports");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WHE.Settings");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Sheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Sheet 1$'", "dbo");

            entity.Property(e => e.Acerage)
                .HasMaxLength(255)
                .HasColumnName("ACERAGE");
            entity.Property(e => e.County)
                .HasMaxLength(255)
                .HasColumnName("COUNTY");
            entity.Property(e => e.CountyName)
                .HasMaxLength(255)
                .HasColumnName("COUNTY_NAME");
            entity.Property(e => e.DRecord)
                .HasMaxLength(255)
                .HasColumnName("D_RECORD");
            entity.Property(e => e.DeleteRecord)
                .HasMaxLength(255)
                .HasColumnName("DELETE_RECORD");
            entity.Property(e => e.Dtcreated)
                .HasColumnType("datetime")
                .HasColumnName("DTCREATED");
            entity.Property(e => e.ExemptionNo)
                .HasMaxLength(255)
                .HasColumnName("EXEMPTION_NO");
            entity.Property(e => e.ExpirationDate)
                .HasMaxLength(255)
                .HasColumnName("EXPIRATION_DATE");
            entity.Property(e => e.HCounty)
                .HasMaxLength(255)
                .HasColumnName("H_COUNTY");
            entity.Property(e => e.HReg)
                .HasMaxLength(255)
                .HasColumnName("H_REG");
            entity.Property(e => e.IssueDate)
                .HasColumnType("datetime")
                .HasColumnName("ISSUE_DATE");
            entity.Property(e => e.LandownerId).HasColumnName("LANDOWNER_ID");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Map)
                .HasMaxLength(255)
                .HasColumnName("MAP");
            entity.Property(e => e.Notes)
                .HasMaxLength(255)
                .HasColumnName("NOTES");
            entity.Property(e => e.OfficerId)
                .HasMaxLength(255)
                .HasColumnName("OFFICER_ID");
            entity.Property(e => e.OfficerName)
                .HasMaxLength(255)
                .HasColumnName("OFFICER_NAME");
            entity.Property(e => e.PEnd)
                .HasColumnType("datetime")
                .HasColumnName("P_END");
            entity.Property(e => e.PLat)
                .HasMaxLength(255)
                .HasColumnName("P_LAT");
            entity.Property(e => e.PLong)
                .HasMaxLength(255)
                .HasColumnName("P_LONG");
            entity.Property(e => e.PRegion)
                .HasMaxLength(255)
                .HasColumnName("P_REGION");
            entity.Property(e => e.PStart)
                .HasColumnType("datetime")
                .HasColumnName("P_START");
            entity.Property(e => e.PSubmitter)
                .HasMaxLength(255)
                .HasColumnName("P_SUBMITTER");
            entity.Property(e => e.PType)
                .HasMaxLength(255)
                .HasColumnName("P_TYPE");
            entity.Property(e => e.PYear)
                .HasMaxLength(255)
                .HasColumnName("P_YEAR");
            entity.Property(e => e.Parcel)
                .HasMaxLength(255)
                .HasColumnName("PARCEL");
            entity.Property(e => e.PermitAsNumber).HasColumnName("PERMIT_AS_NUMBER");
            entity.Property(e => e.PropHuntAllowed)
                .HasMaxLength(255)
                .HasColumnName("PROP_HUNT_ALLOWED");
            entity.Property(e => e.RacfId)
                .HasMaxLength(255)
                .HasColumnName("RACF_ID");
            entity.Property(e => e.Species)
                .HasMaxLength(255)
                .HasColumnName("SPECIES");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Test");

            entity.Property(e => e.Acerage)
                .HasMaxLength(50)
                .HasColumnName("_ACERAGE_");
            entity.Property(e => e.County)
                .HasMaxLength(50)
                .HasColumnName("_COUNTY_");
            entity.Property(e => e.CountyName)
                .HasMaxLength(50)
                .HasColumnName("_COUNTY_NAME_");
            entity.Property(e => e.DRecord)
                .HasMaxLength(1)
                .HasColumnName("_D_RECORD_");
            entity.Property(e => e.DeleteRecord)
                .HasMaxLength(1)
                .HasColumnName("_DELETE_RECORD_");
            entity.Property(e => e.ExemptionNo)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("_EXEMPTION_NO_");
            entity.Property(e => e.IssueDate)
                .HasMaxLength(50)
                .HasColumnName("_ISSUE_DATE_");
            entity.Property(e => e.LandownerId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("_LANDOWNER_ID_");
            entity.Property(e => e.Location)
                .HasMaxLength(300)
                .HasColumnName("_LOCATION_");
            entity.Property(e => e.Map)
                .HasMaxLength(50)
                .HasColumnName("_MAP_");
            entity.Property(e => e.Notes)
                .HasMaxLength(300)
                .HasColumnName("_NOTES_");
            entity.Property(e => e.OfficerId)
                .HasMaxLength(50)
                .HasColumnName("_OFFICER_ID_");
            entity.Property(e => e.OfficerName)
                .HasMaxLength(50)
                .HasColumnName("_OFFICER_NAME_");
            entity.Property(e => e.PEnd).HasColumnName("_P_END_");
            entity.Property(e => e.PLat)
                .HasMaxLength(1)
                .HasColumnName("_P_LAT_");
            entity.Property(e => e.PLong)
                .HasMaxLength(1)
                .HasColumnName("_P_LONG_");
            entity.Property(e => e.PRegion)
                .HasMaxLength(50)
                .HasColumnName("_P_REGION_");
            entity.Property(e => e.PStart).HasColumnName("_P_START_");
            entity.Property(e => e.PSubmitter)
                .HasMaxLength(50)
                .HasColumnName("_P_SUBMITTER_");
            entity.Property(e => e.PType)
                .HasMaxLength(1)
                .HasColumnName("_P_TYPE_");
            entity.Property(e => e.PYear)
                .HasMaxLength(50)
                .HasColumnName("_P_YEAR_");
            entity.Property(e => e.Parcel)
                .HasMaxLength(50)
                .HasColumnName("_PARCEL_");
            entity.Property(e => e.PermitAsNumber)
                .HasMaxLength(50)
                .HasColumnName("_PERMIT_AS_NUMBER_");
            entity.Property(e => e.PropHuntAllowed)
                .HasMaxLength(50)
                .HasColumnName("_PROP_HUNT_ALLOWED_");
            entity.Property(e => e.Species)
                .HasMaxLength(50)
                .HasColumnName("_SPECIES_");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC270F9D1C23");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bhnumber).HasColumnName("BHNumber");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<UsersInRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UsersInRole");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
