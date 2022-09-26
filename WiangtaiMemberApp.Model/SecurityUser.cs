using System;

namespace WiangtaiMemberApp.Model;

public class SecurityUser
{
    public Guid UserID { get; set; }
    public string UserName { get; set; }
    public string UserLogin { get; set; }
    public string UserPassword { get; set; }
    public byte UserStatus { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool bMustChangePassword { get; set; }
    public bool bSuspend { get; set; }
    public byte intAttempts { get; set; }
    public DateTime dteChangepass { get; set; }
    public DateTime dteSuspend { get; set; }

    public virtual ICollection<SecurityRoleEntity> SecurityRoleEntities { get; set; }
    public virtual ICollection<SecurityUserRole> SecurityUserRoles { get; set; }
    public virtual ICollection<SecuritySessionLogin> SecuritySessionLogins { get; set; }
    public virtual UserProfile UserProfile { get; set; }
}
