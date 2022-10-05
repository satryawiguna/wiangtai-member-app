using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using Microsoft.EntityFrameworkCore;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Model.Response.Functions;

namespace WiangtaiMemberApp.Data;

public class WiangtaiMemberAppDbContext : DbContext
{
    public WiangtaiMemberAppDbContext(DbContextOptions<WiangtaiMemberAppDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }

    public DbSet<CardMaster> CardMaster { get; set; }

    public DbSet<Currency> Currency { get; set; }

    public DbSet<Member> Member { get; set; }

    public DbSet<MemberReward> MemberReward { get; set; }

    public DbSet<Membership> Membership { get; set; }

    public DbSet<MemberType> MemberType { get; set; }

    public DbSet<SecurityRole> SecurityRole { get; set; }

    public DbSet<SecuritySessionLogin> SecuritySessionLogin { get; set; }

    public DbSet<SecurityUser> SecurityUser { get; set; }

    public DbSet<SecurityUserRole> SecurityUserRole { get; set; }

    public DbSet<UserProfile> UserProfile { get; set; }

    public DbSet<Setting> Setting { get; set; }


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
                .HasColumnName("CardNumber")
                .IsRequired(false);

            entity.Property(e => e.SalesDate)
                .HasColumnName("SalesDate")
                .IsRequired(true);

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.CardNumberEncrypted)
                .HasColumnName("CardNumberEncrypted")
                .IsRequired(true);

            entity.Property(e => e.CardNumberShow)
                .HasColumnName("CardNumberShow")
                .IsRequired(true);
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
                .IsRequired(true);

            entity.Property(e => e.CurrencyName)
                .HasColumnType("varchar(100)")
                .HasColumnName("CurrencyName")
                .IsRequired(true);

            entity.Property(e => e.ExchangeUnit)
                .HasColumnType("int(11)")
                .HasColumnName("ExchangeUnit")
                .IsRequired(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnType("decimal(18,4)")
                .HasColumnName("ExchangeRate")
                .IsRequired(false);

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");



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
                .HasColumnType("varchar(100)")
                .HasColumnName("FirstName")
                .IsRequired(true);

            entity.Property(e => e.LastName)
                .HasColumnType("varchar(100)")
                .HasColumnName("LastName")
                .IsRequired(false); ;

            entity.Property(e => e.DisplayName)
                .HasColumnType("varchar(100)")
                .HasColumnName("DisplayName")
                .IsRequired(false); ;

            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("BirthDate")
                .IsRequired(false); ;

            entity.Property(e => e.Gender)
                .HasColumnType("tinyint")
                .HasColumnName("Gender")
                .IsRequired(false); ;

            entity.Property(e => e.MaritalStatus)
                .HasColumnType("tinyint")
                .HasColumnName("MaritalStatus")
                .IsRequired(false); ;

            entity.Property(e => e.PassportNo)
                .HasColumnType("varchar(200)")
                .HasColumnName("PassportNo")
                .IsRequired(false); ;

            entity.Property(e => e.MobilePhone)
               .HasColumnType("varchar(50)")
               .HasColumnName("MobilePhone")
               .IsRequired(false); ;

            entity.Property(e => e.Email)
               .HasColumnType("varchar(100)")
               .HasColumnName("Email")
               .IsRequired(false); ;

            entity.Property(e => e.MemberTypeID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("MemberTypeID")
               .IsRequired(false); ;

            entity.Property(e => e.MemberSince)
               .HasColumnType("datetime")
               .HasColumnName("MemberSince")
               .IsRequired(false); ;

            entity.Property(e => e.Notification)
               .HasColumnType("tinyint")
               .HasColumnName("Notification")
               .IsRequired(false); ;

            entity.Property(e => e.SalaryRangeID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("SalaryRangeID")
               .IsRequired(false); ;

            entity.Property(e => e.RaceTypeID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("RaceTypeID")
               .IsRequired(false); ;

            entity.Property(e => e.ReligionID)
               .HasColumnType("uniqueindentifier")
               .HasColumnName("ReligionID")
               .IsRequired(false); ;

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.intNoType)
               .HasColumnType("tinyint")
               .HasColumnName("intNoType")
               .IsRequired(false);



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

            entity.HasOne(r => r.SalaryRange)
                .WithMany(r => r.Members)
                .HasForeignKey(r => r.SalaryRangeID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(r => r.Memberships)
                .WithOne(r => r.Member)
                .HasForeignKey(r => r.MemberID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(r => r.MemberRewards)
                .WithOne(r => r.Member)
                .HasForeignKey(r => r.MemberID)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<MemberReward>(entity =>
        {
            entity.ToTable("MemberReward");

            entity.HasKey(e => e.RewardID);

            entity.Property(e => e.RewardID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("RewardID");

            entity.Property(e => e.MemberID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("MemberID")
                .IsRequired(true);

            entity.Property(e => e.ToMemberID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ToMemberID")
                .IsRequired(false);

            entity.Property(e => e.RewardMethod)
                .HasColumnType("tinyint")
                .HasColumnName("RewardMethod")
                .IsRequired(true);

            entity.Property(e => e.RewardType)
                .HasColumnType("tinyint")
                .HasColumnName("RewardType")
                .IsRequired(true);

            entity.Property(e => e.RewardValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RewardValue")
                .IsRequired(false);

            entity.Property(e => e.UsageAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UsageAmount")
                .IsRequired(false);

            entity.Property(e => e.RewardRefNo)
                .HasColumnType("bigint(20)")
                .HasColumnName("RewardRefNo")
                .IsRequired(true);

            entity.Property(e => e.IssuedDate)
                .HasColumnName("IssuedDate")
                .IsRequired(false);

            entity.Property(e => e.EffectiveDate)
                .HasColumnName("EffectiveDate")
                .IsRequired(false);

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("ExpiryDate")
                .IsRequired(false);

            entity.Property(e => e.ConsumeValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ConsumeValue")
                .IsRequired(false);

            entity.Property(e => e.BalanceValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BalanceValue")
                .IsRequired(false);

            entity.Property(e => e.Remarks)
                .HasColumnType("text")
                .HasColumnName("Remarks")
                .IsRequired(false);

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.EntitlementDate)
                .HasColumnName("EntitlementDate")
                .IsRequired(true);

            entity.Property(e => e.RewardFundID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("RewardFundID")
                .IsRequired(false);

            entity.Property(e => e.idBatch)
                .HasColumnType("varchar(200)")
                .HasColumnName("idBatch")
                .IsRequired(true);

            entity.Property(e => e.isExpired)
                .HasColumnType("bool")
                .HasColumnName("isExpired")
                .IsRequired(false);

            entity.Property(e => e.decPointCost)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("decPointCost")
                .IsRequired(false);



            entity.HasOne(r => r.Member)
                .WithMany(r => r.MemberRewards)
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
                .IsRequired(true);

            entity.Property(e => e.MemberTypeID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("MemberTypeID")
                .IsRequired(true);

            entity.Property(e => e.CardNumber)
                .HasColumnType("bigint(20)")
                .HasColumnName("CardNumber")
                .IsRequired(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("StartDate")
                .IsRequired(true);

            entity.Property(e => e.EndDate)
                .HasColumnName("EndDate")
                .IsRequired(false);

            entity.Property(e => e.CurrencyID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CurrencyID")
                .IsRequired(false);

            entity.Property(e => e.AnnualFee)
                .HasColumnType("decimal(18,2)")
                .HasColumnName("AnnualFee")
                .IsRequired(false);

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.NotifyExpired15Days)
                .HasColumnType("bool")
                .HasColumnName("NotifyExpired15Days")
                .IsRequired(true);

            entity.Property(e => e.NotifyExpired15Days)
                .HasColumnType("bool")
                .HasColumnName("NotifyExpired15Days")
                .IsRequired(true);

            entity.Property(e => e.NotifyExpired30Days)
                .HasColumnType("bool")
                .HasColumnName("NotifyExpired30Days")
                .IsRequired(true);

            entity.Property(e => e.PassAutoRenewal)
                .HasColumnType("bool")
                .HasColumnName("PassAutoRenewal")
                .IsRequired(true);

            entity.Property(e => e.SMSNotifyExpiring15Days)
                .HasColumnType("bool")
                .HasColumnName("SMSNotifyExpiring15Days")
                .IsRequired(true);

            entity.Property(e => e.CardNumberEncrypted)
                .HasColumnName("CardNumberEncrypted")
                .IsRequired(true);

            entity.Property(e => e.CardNumberShow)
                .HasColumnName("CardNumberShow")
                .IsRequired(true);

            entity.Property(e => e.strIndicatorCode)
                .HasColumnName("strIndicatorCode")
                .IsRequired(true);

            entity.Property(e => e.strReasonCode)
                .HasColumnName("strReasonCode")
                .IsRequired(true);

            entity.Property(e => e.strReasonDesc)
                .HasColumnName("strReasonDesc")
                .IsRequired(true);



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

        modelBuilder.Entity<MemberType>(entity =>
        {
            entity.ToTable("MemberType");

            entity.HasKey(e => e.MemberTypeID);

            entity.Property(e => e.MemberTypeID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("MemberTypeID");

            entity.Property(e => e.MemberTypeName)
                .HasColumnType("varchar(100)")
                .HasColumnName("MemberTypeName")
                .IsRequired(true);

            entity.Property(e => e.MemberTypeDesc)
                .HasColumnType("text")
                .HasColumnName("MemberTypeDesc")
                .IsRequired(true);

            entity.Property(e => e.Grade)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("Grade")
                .IsRequired(false);

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.CurrencyID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CurrencyID")
                .IsRequired(false);

            entity.Property(e => e.AnnualFee)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("AnnualFee")
                .IsRequired(false);

            entity.Property(e => e.ValidityPeriod)
                .HasColumnType("tinyint")
                .HasColumnName("ValidityPeriod")
                .IsRequired(true);

            entity.Property(e => e.ReferenceCode)
                .HasColumnType("varchar(50)")
                .HasColumnName("ReferenceCode")
                .IsRequired(false);

            entity.Property(e => e.intCustomerType)
                .HasColumnType("tinyint")
                .HasColumnName("intCustomerType")
                .IsRequired(false);

            entity.Property(e => e.bitAllowPointTransfer)
                .HasColumnType("bool")
                .HasColumnName("bitAllowPointTransfer")
                .IsRequired(false);

            entity.Property(e => e.bitAllowCashTransfer)
                .HasColumnType("bool")
                .HasColumnName("bitAllowCashTransfer")
                .IsRequired(false);

            entity.Property(e => e.idDocument)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("idDocument")
                .IsRequired(false);

            entity.Property(e => e.bitPreRegister)
                .HasColumnType("bool")
                .HasColumnName("bitPreRegister")
                .IsRequired(false);

            entity.Property(e => e.bitEnableEmoney)
                .HasColumnType("bool")
                .HasColumnName("bitEnableEmoney")
                .IsRequired(false);

            entity.Property(e => e.bitEnableWriteToCard)
                .HasColumnType("bool")
                .HasColumnName("bitEnableWriteToCard")
                .IsRequired(false);

            entity.Property(e => e.intCardProtocal)
                .HasColumnType("int")
                .HasColumnName("intCardProtocal")
                .IsRequired(false);

            entity.Property(e => e.bitMandatoryMemberReg)
                .HasColumnType("bool")
                .HasColumnName("bitMandatoryMemberReg")
                .IsRequired(false);

            entity.Property(e => e.bitMandatoryNonMemberReg)
                .HasColumnType("bool")
                .HasColumnName("bitMandatoryNonMemberReg")
                .IsRequired(false);

            entity.Property(e => e.bitMandatoryCardReplacement)
                .HasColumnType("bool")
                .HasColumnName("bitMandatoryCardReplacement")
                .IsRequired(false);



            entity.HasOne(r => r.Currency)
                .WithMany(r => r.MemberTypes)
                .HasForeignKey(r => r.CurrencyID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(r => r.Members)
                .WithOne(r => r.MemberType)
                .HasForeignKey(r => r.MemberID)
                .OnDelete(DeleteBehavior.NoAction);

            entity.HasMany(r => r.Memberships)
                .WithOne(r => r.MemberType)
                .HasForeignKey(r => r.MemberTypeID)
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
                .IsRequired(true);

            entity.Property(e => e.RoleDesc)
                .HasColumnType("text")
                .HasColumnName("RoleDesc")
                .IsRequired(true);

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

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
                .IsRequired(true);

            entity.Property(e => e.dtCreate)
                .HasColumnName("dtCreate")
                .IsRequired(true);

            entity.Property(e => e.dtExpiry)
                .HasColumnName("dtExpiry")
                .IsRequired(true);

            entity.Property(e => e.strCode)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("strCode")
                .IsRequired(true);



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
                .IsRequired(true);

            entity.Property(e => e.UserLogin)
                .HasColumnType("varchar(20)")
                .HasColumnName("UserLogin")
                .IsRequired(true);

            entity.Property(e => e.UserPassword)
                .HasColumnType("varchar(100)")
                .HasColumnName("UserPassword")
                .IsRequired(true);

            entity.Property(e => e.UserStatus)
                .HasColumnType("tinyint")
                .HasColumnName("UserStatus")
                .IsRequired(true);

            entity.Property(e => e.bMustChangePassword)
                .HasColumnType("bit")
                .HasColumnName("bMustChangePassword")
                .IsRequired(true);

            entity.Property(e => e.bSuspend)
                .HasColumnType("bit")
                .HasColumnName("bSuspend")
                .IsRequired(true);

            entity.Property(e => e.intAttempts)
                .HasColumnType("tinyint")
                .HasColumnName("intAttempts")
                .IsRequired(true);

            entity.Property(e => e.dteChangepass)
                .HasColumnName("dteChangepass")
                .IsRequired(true);

            entity.Property(e => e.dteSuspend)
                .HasColumnName("dteSuspend")
                .IsRequired(true);

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");



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
                .HasColumnName("CreatedBy");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");

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
                .HasColumnName("EmployeeCode")
                .IsRequired(false);

            entity.Property(e => e.FirstName)
                .HasColumnType("varchar(50)")
                .HasColumnName("FirstName")
                .IsRequired(false);

            entity.Property(e => e.LastName)
                .HasColumnType("varchar(50)")
                .HasColumnName("LastName")
                .IsRequired(false);

            entity.Property(e => e.DisplayName)
                .HasColumnType("varchar(100)")
                .HasColumnName("DisplayName")
                .IsRequired(false);

            entity.Property(e => e.DepartmentID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("DepartmentID")
                .IsRequired(false);

            entity.Property(e => e.JobTitle)
                .HasColumnType("varchar(100)")
                .HasColumnName("JobTitle")
                .IsRequired(false);

            entity.Property(e => e.ReportTo)
                .HasColumnType("varchar(100)")
                .HasColumnName("ReportTo")
                .IsRequired(false);

            entity.Property(e => e.BusinessPhone)
                .HasColumnType("varchar(20)")
                .HasColumnName("BusinessPhone")
                .IsRequired(false);

            entity.Property(e => e.MobilePhone)
                .HasColumnType("varchar(20)")
                .HasColumnName("MobilePhone")
                .IsRequired(false);

            entity.Property(e => e.eMail)
                .HasColumnType("varchar(100)")
                .HasColumnName("eMail")
                .IsRequired(false);

            entity.Property(e => e.Notifier)
                .HasColumnType("tinyint")
                .HasColumnName("Notifier");

            entity.Property(e => e.NRIC)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("NRIC")
                .IsRequired(false);

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("CreatedBy");

            entity.Property(e => e.ModifiedDate)
                .HasColumnName("ModifiedDate");

            entity.Property(e => e.ModifiedBy)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModifiedBy");



            entity.HasOne(r => r.SecurityUser)
                .WithOne(r => r.UserProfile)
                .HasForeignKey<UserProfile>(r => r.UserID)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("tblSetting");

            entity.HasKey(e => e.idSetting);

            entity.Property(e => e.idSetting)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("idSetting");

            entity.Property(e => e.strName)
                .HasColumnType("varchar(200)")
                .HasColumnName("strName")
                .IsRequired(false);

            entity.Property(e => e.strValue)
                .HasColumnType("varchar(200)")
                .HasColumnName("strValue")
                .IsRequired(false);

            entity.Property(e => e.strType)
                .HasColumnType("varchar(50)")
                .HasColumnName("strType")
                .IsRequired(false);

            entity.Property(e => e.intSort)
                .HasColumnType("smallint")
                .HasColumnName("intSort")
                .IsRequired(false);

            entity.Property(e => e.intGroup)
                .HasColumnType("smallint")
                .HasColumnName("intGroup")
                .IsRequired(false);
        });



        modelBuilder.Entity<RedemptionAllowedFundDto>(entity =>
        {
            entity.HasNoKey();
        });
    }


    [DbFunction("GetRedemptionAllowedFund", "dbo")]
    public virtual IQueryable<RedemptionAllowedFundDto> GetRedemptionAllowedFund(Guid? redemptionProductId)
    {
        var redemptionProductIdParameter = redemptionProductId.HasValue ?
            new ObjectParameter("RedemptionProductId", redemptionProductId) :
            new ObjectParameter("RedemptionProductId", typeof(Guid));

        return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<RedemptionAllowedFundDto>(string.Format("[{0}].{1}", GetType().Name,
                    "[GetRedemptionAllowedFund](@RedemptionProductId)"), redemptionProductIdParameter);
    }
}