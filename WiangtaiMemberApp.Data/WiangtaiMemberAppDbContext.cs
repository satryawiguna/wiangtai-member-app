using Microsoft.EntityFrameworkCore;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Data;

public class WiangtaiMemberAppDbContext : DbContext
{
    public WiangtaiMemberAppDbContext(DbContextOptions<WiangtaiMemberAppDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }

    public DbSet<CardMaster> CardMaster { get; set; }

    public DbSet<Member> Member { get; set; }

    public DbSet<Membership> Membership { get; set; }

    public DbSet<MemberType> MemberType { get; set; }

    public DbSet<SecurityRole> SecurityRole { get; set; }

    public DbSet<SecuritySessionLogin> SecuritySessionLogin { get; set; }

    public DbSet<SecurityUser> SecurityUser { get; set; }

    public DbSet<SecurityUserRole> SecurityUserRole { get; set; }

    public DbSet<UserProfile> UserProfile { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CardMaster>(entity =>
        {
            entity.ToTable("CardMaster");

            entity.HasKey(e => e.CardMasterID);

            entity.Property(e => e.CardMasterID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CardMasterID");

            entity.Property(e => e.CardNumber)
                .HasColumnType("bigint(20)")
                .HasColumnName("CardNumber");

            entity.Property(e => e.SalesDate)
                .HasColumnName("SalesDate")
                .IsRequired();

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate")
                .IsRequired();

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            entity.Property(e => e.CardNumberEncrypted)
                .HasColumnName("CardNumberEncrypted")
                .IsRequired();

            entity.Property(e => e.CardNumberShow)
                .HasColumnName("CardNumberShow")
                .IsRequired();
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.ToTable("Currency");

            entity.HasKey(e => e.CurrencyID);

            entity.Property(e => e.CurrencyID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CurrencyID");

            entity.Property(e => e.CurrencyCode)
                .HasColumnType("char(3)")
                .HasColumnName("CurrencyCode")
                .IsRequired();

            entity.Property(e => e.CurrencyName)
                .HasColumnType("varchar(100)")
                .HasColumnName("CurrencyName")
                .IsRequired();

            entity.Property(e => e.ExchangeUnit)
                .HasColumnType("int(11)")
                .HasColumnName("ExchangeUnit");

            entity.Property(e => e.ExchangeRate)
                .HasColumnType("decimal(18,4)")
                .HasColumnName("ExchangeRate");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate")
                .IsRequired();

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();



            entity.HasMany(r => r.Memberships)
                .WithOne(r => r.Currency)
                .HasForeignKey(r => r.CurrencyID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("Member");

            entity.HasKey(e => e.MemberID);

            entity.Property(e => e.MemberID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("MemberID");

            entity.Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .IsRequired();

            entity.Property(e => e.LastName)
                .HasColumnName("LastName")
                .IsRequired();

            entity.Property(e => e.DisplayName)
                .HasColumnName("DisplayName")
                .IsRequired();

            entity.Property(e => e.intNoType)
               .HasColumnType("tinyint")
               .HasColumnName("intNoType");

            entity.Property(e => e.PassportNo)
                .HasColumnName("PassportNo")
                .IsRequired();

            entity.Property(e => e.Email)
               .HasColumnName("Email")
               .IsRequired();

            entity.Property(e => e.MobilePhone)
               .HasColumnType("varchar")
               .HasColumnName("MobilePhone")
               .IsRequired();

            entity.Property(e => e.Notification)
               .HasColumnType("tinyint")
               .HasColumnName("Notification");

            entity.Property(e => e.MemberTypeID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("MemberTypeID");

            entity.Property(e => e.MemberSince)
               .HasColumnType("datetime")
               .HasColumnName("MemberSince");

            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("BirthDate");

            entity.Property(e => e.Gender)
                .HasColumnType("tinyint")
                .HasColumnName("Gender");

            entity.Property(e => e.RaceTypeID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("RaceTypeID");

            entity.Property(e => e.MaritalStatus)
                .HasColumnType("tinyint")
                .HasColumnName("MaritalStatus");

            entity.Property(e => e.ReligionID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("ReligionID");

            entity.Property(e => e.SalaryRangeID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("SalaryRangeID");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate")
                .IsRequired();

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();



            entity.HasOne(r => r.MemberType)
                .WithMany(r => r.Members)
                .HasForeignKey(r => r.MemberTypeID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(r => r.RaceType)
                .WithMany(r => r.Members)
                .HasForeignKey(r => r.RaceTypeID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(r => r.Religion)
                .WithMany(r => r.Members)
                .HasForeignKey(r => r.ReligionID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(r => r.Memberships)
                .WithOne(r => r.Member)
                .HasForeignKey(r => r.MemberID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Membership>(entity =>
        {
            entity.ToTable("Membership");

            entity.HasKey(e => e.MembershipID);

            entity.Property(e => e.MembershipID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("MembershipID");

            entity.Property(e => e.MemberID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("MemberID")
                .IsRequired();

            entity.Property(e => e.MemberTypeID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("MemberTypeID")
                .IsRequired();

            entity.Property(e => e.CardNumber)
                .HasColumnType("bigint(20)")
                .HasColumnName("CardNumber");

            entity.Property(e => e.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();

            entity.Property(e => e.EndDate)
                .HasColumnName("EndDate");

            entity.Property(e => e.CurrencyID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CurrencyID");

            entity.Property(e => e.AnnualFee)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("AnnualFee");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate")
                .IsRequired();

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            entity.Property(e => e.NotifyExpired15Days)
                .HasColumnType("bool")
                .HasColumnName("NotifyExpired15Days")
                .IsRequired();

            entity.Property(e => e.NotifyExpired15Days)
                .HasColumnType("bool")
                .HasColumnName("NotifyExpired15Days")
                .IsRequired();

            entity.Property(e => e.NotifyExpired30Days)
                .HasColumnType("bool")
                .HasColumnName("NotifyExpired30Days")
                .IsRequired();

            entity.Property(e => e.PassAutoRenewal)
                .HasColumnType("bool")
                .HasColumnName("PassAutoRenewal")
                .IsRequired();

            entity.Property(e => e.SMSNotifyExpiring15Days)
                .HasColumnType("bool")
                .HasColumnName("SMSNotifyExpiring15Days")
                .IsRequired();

            entity.Property(e => e.CardNumberEncrypted)
                .HasColumnName("CardNumberEncrypted")
                .IsRequired();

            entity.Property(e => e.CardNumberShow)
                .HasColumnName("CardNumberShow")
                .IsRequired();

            entity.Property(e => e.strIndicatorCode)
                .HasColumnName("strIndicatorCode")
                .IsRequired();

            entity.Property(e => e.strReasonCode)
                .HasColumnName("strReasonCode")
                .IsRequired();

            entity.Property(e => e.strReasonDesc)
                .HasColumnName("strReasonDesc")
                .IsRequired();



            entity.HasOne(r => r.Member)
                .WithMany(r => r.Memberships)
                .HasForeignKey(r => r.MemberID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(r => r.MemberType)
                .WithMany(r => r.Memberships)
                .HasForeignKey(r => r.MemberTypeID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(r => r.Currency)
                .WithMany(r => r.Memberships)
                .HasForeignKey(r => r.CurrencyID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<SecurityRole>(entity =>
        {
            entity.ToTable("SecurityRole");

            entity.HasKey(e => e.RoleID);

            entity.Property(e => e.RoleID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("RoleID");

            entity.Property(e => e.RoleName)
                .HasColumnType("varchar(100)")
                .HasColumnName("RoleName")
                .IsRequired();

            entity.Property(e => e.RoleDesc)
                .HasColumnType("text")
                .HasColumnName("RoleDesc")
                .IsRequired();

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            

            entity.HasMany(r => r.SecurityUserRoles)
                .WithOne(r => r.SecurityRole)
                .HasForeignKey(r => r.RoleID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<SecuritySessionLogin>(entity =>
        {
            entity.ToTable("tblSecuritySessionLogin");

            entity.HasKey(e => e.idSecuritySessionLogin);

            entity.Property(e => e.idSecuritySessionLogin)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("idSecuritySessionLogin");

            entity.Property(e => e.UserID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("UserID")
                .IsRequired();

            entity.Property(e => e.dtCreate)
                .HasColumnName("dtCreate")
                .IsRequired();

            entity.Property(e => e.dtExpiry)
                .HasColumnName("dtExpiry")
                .IsRequired();

            entity.Property(e => e.strCode)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("strCode")
                .IsRequired();



            entity.HasOne(r => r.SecurityUser)
                .WithMany(r => r.SecuritySessionLogins)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<SecurityUser>(entity =>
        {
            entity.ToTable("SecurityUser");

            entity.HasKey(e => e.UserID);

            entity.Property(e => e.UserID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("UserID");

            entity.Property(e => e.UserName)
                .HasColumnType("varchar(100)")
                .HasColumnName("UserName")
                .IsRequired();

            entity.Property(e => e.UserLogin)
                .HasColumnType("varchar(20)")
                .HasColumnName("UserLogin")
                .IsRequired();

            entity.Property(e => e.UserPassword)
                .HasColumnType("varchar(100)")
                .HasColumnName("UserPassword")
                .IsRequired();

            entity.Property(e => e.UserStatus)
                .HasColumnType("tinyint")
                .HasColumnName("UserStatus")
                .IsRequired();

            entity.Property(e => e.bMustChangePassword)
                .HasColumnType("bit")
                .HasColumnName("bMustChangePassword")
                .IsRequired();

            entity.Property(e => e.bSuspend)
                .HasColumnType("bit")
                .HasColumnName("bSuspend")
                .IsRequired();

            entity.Property(e => e.intAttempts)
                .HasColumnType("tinyint")
                .HasColumnName("intAttempts")
                .IsRequired();

            entity.Property(e => e.dteChangepass)
                .HasColumnName("dteChangepass")
                .IsRequired();

            entity.Property(e => e.dteSuspend)
                .HasColumnName("dteSuspend")
                .IsRequired();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();



            entity.HasOne(r => r.UserProfile)
                .WithOne(r => r.SecurityUser)
                .HasForeignKey<UserProfile>(r => r.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(r => r.SecurityUserRoles)
                .WithOne(r => r.SecurityUser)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(r => r.SecuritySessionLogins)
                .WithOne(r => r.SecurityUser)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<SecurityUserRole>(entity =>
        {
            entity.ToTable("SecurityUserRole");

            entity.HasKey(e => new { e.UserID, e.RoleID });

            entity.Property(e => e.UserID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("UserID");

            entity.Property(e => e.RoleID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("RoleID");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");



            entity.HasOne(r => r.SecurityRole)
                .WithMany(r => r.SecurityUserRoles)
                .HasForeignKey(r => r.RoleID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasOne(r => r.SecurityUser)
                .WithMany(r => r.SecurityUserRoles)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.ToTable("UserProfile");

            entity.HasKey(e => e.UserID);

            entity.Property(e => e.UserID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("UserID");

            entity.Property(e => e.EmployeeCode)
                .HasColumnType("varchar(10)")
                .HasColumnName("EmployeeCode");

            entity.Property(e => e.FirstName)
                .HasColumnType("varchar(50)")
                .HasColumnName("FirstName");

            entity.Property(e => e.LastName)
                .HasColumnType("varchar(50)")
                .HasColumnName("LastName");

            entity.Property(e => e.DisplayName)
                .HasColumnType("varchar(100)")
                .HasColumnName("DisplayName");

            entity.Property(e => e.DepartmentID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("DepartmentID");

            entity.Property(e => e.JobTitle)
                .HasColumnType("varchar(100)")
                .HasColumnName("JobTitle");

            entity.Property(e => e.ReportTo)
                .HasColumnType("varchar(100)")
                .HasColumnName("ReportTo");

            entity.Property(e => e.BusinessPhone)
                .HasColumnType("varchar(20)")
                .HasColumnName("BusinessPhone");

            entity.Property(e => e.MobilePhone)
                .HasColumnType("varchar(20)")
                .HasColumnName("MobilePhone");

            entity.Property(e => e.eMail)
                .HasColumnType("varchar(100)")
                .HasColumnName("eMail");

            entity.Property(e => e.Notifier)
                .HasColumnType("tinyint")
                .HasColumnName("Notifier");

            entity.Property(e => e.NRIC)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("NRIC");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy")
                .IsRequired();

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy")
                .IsRequired();



            entity.HasOne(r => r.SecurityUser)
                .WithOne(r => r.UserProfile)
                .HasForeignKey<UserProfile>(r => r.UserID)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}