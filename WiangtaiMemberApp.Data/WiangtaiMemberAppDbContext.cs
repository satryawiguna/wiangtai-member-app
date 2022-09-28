using Microsoft.EntityFrameworkCore;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Data;

public class WiangtaiMemberAppDbContext : DbContext
{
    public WiangtaiMemberAppDbContext(DbContextOptions<WiangtaiMemberAppDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }

    public DbSet<SecurityRole> SecurityRole { get; set; }

    public DbSet<SecurityRoleAccess> SecurityRoleAccess { get; set; }

    public DbSet<SecurityRoleEntity> SecurityRoleEntity { get; set; }

    public DbSet<SecuritySessionLogin> SecuritySessionLogin { get; set; }

    public DbSet<SecurityUser> SecurityUser { get; set; }

    public DbSet<SecurityUserRole> SecurityUserRole { get; set; }

    public DbSet<UserProfile> UserProfile { get; set; }

    public DbSet<UserProfilePasswordHistory> UserProfilePasswordHistory { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SecurityElement>(entity =>
        {
            entity.ToTable("SecurityElement");

            entity.HasKey(e => e.ElementID);

            entity.Property(e => e.ElementID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ElementID");

            entity.Property(e => e.PageID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("PageID")
                .IsRequired();

            entity.Property(e => e.ElementName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("ElementName")
                .IsRequired();

            entity.Property(e => e.ElementPageName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("ElementPageName")
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



            entity.HasOne(r => r.SecurityPage)
                .WithMany(r => r.SecurityElements)
                .HasForeignKey(r => r.PageID)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<SecurityPage>(entity =>
        {
            entity.ToTable("SecurityPage");

            entity.HasKey(e => e.PageID);

            entity.Property(e => e.PageID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ElementID");

            entity.Property(e => e.ModuleID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModuleID")
                .IsRequired();

            entity.Property(e => e.PageName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("PageName")
                .IsRequired();

            entity.Property(e => e.FilePath)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("FilePath")
                .IsRequired();

            entity.Property(e => e.Icon)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("Icon");

            entity.Property(e => e.Sort)
                .HasColumnType("smallint")
                .HasColumnName("Sort");

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
        });

        modelBuilder.Entity<SecurityRole>(entity =>
        {
            entity.ToTable("SecurityRole");

            entity.HasKey(e => e.RoleID);

            entity.Property(e => e.RoleID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("RoleID");

            entity.Property(e => e.RoleName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("RoleName")
                .IsRequired();

            entity.Property(e => e.RoleDesc)
                .HasColumnType("text")
                .HasColumnName("RoleDesc")
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
        });

        modelBuilder.Entity<SecurityRoleAccess>(entity =>
        {
            entity.ToTable("SecurityRoleAccess");

            entity.HasKey(e => e.AccessID);

            entity.Property(e => e.AccessID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("AccessID");

            entity.Property(e => e.RoleID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("RoleId")
                .IsRequired();

            entity.Property(e => e.ModuleID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("ModuleID")
                .IsRequired();

            entity.Property(e => e.PageID)
                .HasColumnType("varchar")
                .HasMaxLength(32)
                .HasColumnName("PageID");

            entity.Property(e => e.ElementID)
                .HasColumnType("varchar(32)")
                .HasColumnName("ElementID");

            entity.Property(e => e.Access)
                .HasColumnType("tinyint")
                .HasColumnName("Access")
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



            entity.HasOne(r => r.SecurityRole)
                .WithMany(r => r.SecurityRoleAccesses)
                .HasForeignKey(r => r.RoleID)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(r => r.SecurityElement)
                .WithMany(r => r.SecurityRoleAccesses)
                .HasForeignKey(r => r.RoleID)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<SecurityRoleEntity>(entity =>
        {
            entity.ToTable("SecurityRoleEntity");

            entity.HasKey(e => new { e.RoleID, e.EntityID });

            entity.Property(e => e.RoleID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("RoleID");

            entity.Property(e => e.EntityID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("EntityID");

            entity.Property(e => e.UserID)
                .HasColumnType("varchar")
                .HasMaxLength(32)
                .HasColumnName("UserID");

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
                .WithMany(r => r.SecurityRoleEntities)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.Restrict);
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
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<SecurityUser>(entity =>
        {
            entity.ToTable("SecurityUser");

            entity.HasKey(e => e.UserID);

            entity.Property(e => e.UserID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("UserID");

            entity.Property(e => e.UserName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("UserName")
                .IsRequired();

            entity.Property(e => e.UserLogin)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .HasColumnName("UserLogin")
                .IsRequired();

            entity.Property(e => e.UserPassword)
                .HasColumnType("varchar")
                .HasMaxLength(100)
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
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.ToTable("UserProfile");

            entity.HasKey(e => e.UserID);

            entity.Property(e => e.UserID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("UserID");

            entity.Property(e => e.EmployeeCode)
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .HasColumnName("EmployeeCode");

            entity.Property(e => e.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("FirstName");

            entity.Property(e => e.LastName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasColumnName("LastName");

            entity.Property(e => e.DisplayName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("DisplayName");

            entity.Property(e => e.DepartmentID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("DepartmentID");

            entity.Property(e => e.JobTitle)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("JobTitle");

            entity.Property(e => e.ReportTo)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("ReportTo");

            entity.Property(e => e.BusinessPhone)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .HasColumnName("BusinessPhone");

            entity.Property(e => e.MobilePhone)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .HasColumnName("MobilePhone");

            entity.Property(e => e.eMail)
                .HasColumnType("varchar")
                .HasMaxLength(100)
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
                .HasForeignKey<UserProfile>(r => r.UserID);
        });

        modelBuilder.Entity<UserProfilePasswordHistory>(entity =>
        {
            entity.ToTable("tblUserProfilePwdHistory");

            entity.HasKey(e => e.idPwdHistory);

            entity.Property(e => e.idPwdHistory)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("idPwdHistory");

            entity.Property(e => e.strLoginId)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnName("strLoginId")
                .IsRequired();

            entity.Property(e => e.strPassword)
                .HasColumnType("text")
                .HasColumnName("strPassword")
                .IsRequired();

            entity.Property(e => e.dtPwdGenerate)
                .HasColumnName("dtPwdGenerate")
                .IsRequired();

            entity.Property(e => e.UserID)
                .HasColumnType("uniqueindentifier")
                .HasColumnName("UserID")
                .IsRequired();

            entity.Property(e => e.intChangeType)
                .HasColumnType("tinyint")
                .HasColumnName("intChangeType");



            entity.HasOne(r => r.UserProfile)
                .WithMany(r => r.UserProfilePasswordHistories)
                .HasForeignKey(r => r.UserID)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}