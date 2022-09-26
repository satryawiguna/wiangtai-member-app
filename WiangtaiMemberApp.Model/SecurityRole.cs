using System;

namespace WiangtaiMemberApp.Model;

public class SecurityRole
{
    public Guid RoleID { get; set; }
    public string RoleName { get; set; }
    public string RoleDesc { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual ICollection<SecurityRoleAccess> SecurityRoleAccesses { get; set; }
    public virtual ICollection<SecurityRoleEntity> SecurityRoleEntities { get; set; }
    public virtual ICollection<SecurityUserRole> SecurityUserRoles { get; set; }
}

