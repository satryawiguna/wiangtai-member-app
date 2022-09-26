using System;
using System.Security;

namespace WiangtaiMemberApp.Model;

public class SecurityRoleAccess
{
    public Guid AccessID { get; set; }
    public Guid RoleID { get; set; }
    public Guid ModuleID { get; set; }
    public Nullable<Guid> PageID { get; set; }
    public Nullable<Guid> ElementID { get; set; }
    public byte Access { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual SecurityElement SecurityElement { get; set; }
    public virtual SecurityRole SecurityRole { get; set; }
}

