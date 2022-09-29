using System;

namespace WiangtaiMemberApp.Model;

public class Interest
{
    public int idInterest { get; set; }
    public string Name { get; set; }

    public virtual ICollection<MemberInterest> MemberInterests { get; set; }
}