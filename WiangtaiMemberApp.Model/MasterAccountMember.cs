using System;

namespace WiangtaiMemberApp.Model;

public class MasterAccountMember
{
    public long idMasterAccount { get; set; }
    public Guid MemberId { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }

    public virtual Member Member { get; set; }
    public virtual MasterAccount MasterAccount { get; set; }
}