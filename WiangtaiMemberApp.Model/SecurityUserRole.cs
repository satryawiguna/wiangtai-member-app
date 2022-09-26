namespace WiangtaiMemberApp.Model;

public class SecurityUserRole
{
    public System.Guid UserID { get; set; }
    public System.Guid RoleID { get; set; }
    public System.Guid CreatedBy { get; set; }
    public System.Guid ModifiedBy { get; set; }
    public System.DateTime CreatedDate { get; set; }
    public System.DateTime ModifiedDate { get; set; }

    public virtual SecurityRole SecurityRole { get; set; }
    public virtual SecurityUser SecurityUser { get; set; }
}
