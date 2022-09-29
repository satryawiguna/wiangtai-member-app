using System;

namespace WiangtaiMemberApp.Model;

public class MemberInterest
{
    public Guid MemberID { get; set; }
    public int idInterest { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual Member Member { get; set; }
    public virtual Interest Interest { get; set; }
}