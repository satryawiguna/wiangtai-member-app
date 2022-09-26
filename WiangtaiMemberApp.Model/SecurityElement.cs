using System;

namespace WiangtaiMemberApp.Model;

public class SecurityElement
{
    public Guid ElementID { get; set; }
    public Guid PageID { get; set; }
    public string ElementName { get; set; }
    public string ElementPageName { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual SecurityPage SecurityPage { get; set; }
    public virtual ICollection<SecurityRoleAccess> SecurityRoleAccesses { get; set; }
}
