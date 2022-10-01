using System;

namespace WiangtaiMemberApp.Model;

public class SecurityRole
{
    public Guid RoleID { get; set; }
    public string RoleName { get; set; }
    public string RoleDesc { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<SecurityUserRole> SecurityUserRoles { get; set; }
}

