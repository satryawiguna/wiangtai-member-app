using System;
namespace WiangtaiMemberApp.Model;

public class MemberGroupType
{
    public Guid MemberGroupTypeID { get; set; }
    public string MemberGroupType1 { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual ICollection<MemberGroup> MemberGroups { get; set; }
}
