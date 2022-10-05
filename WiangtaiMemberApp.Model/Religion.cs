using System;
namespace WiangtaiMemberApp.Model;

public class Religion
{
    public Guid ReligionID { get; set; }
    public string ReligionName { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string Code { get; set; }

    public virtual ICollection<Member> Members { get; set; }
}

