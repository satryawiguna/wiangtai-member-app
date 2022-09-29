using System;
namespace WiangtaiMemberApp.Model;

public class MemberGroupDetail
{
    public Guid MemberGroupDetailID { get; set; }
    public Guid MemberGroupID { get; set; }
    public Guid MemberTypeID { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual MemberGroup MemberGroup { get; set; }
    public virtual MemberType MemberType { get; set; }
}

