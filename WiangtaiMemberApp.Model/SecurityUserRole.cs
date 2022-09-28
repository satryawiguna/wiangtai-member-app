namespace WiangtaiMemberApp.Model;

public class SecurityUserRole
{
    public Guid UserID { get; set; }
    public Guid RoleID { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual SecurityRole SecurityRole { get; set; }
    public virtual SecurityUser SecurityUser { get; set; }
}
