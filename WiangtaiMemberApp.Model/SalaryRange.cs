using System;
namespace WiangtaiMemberApp.Model;

public class SalaryRange
{
    public Guid SalaryRangeID { get; set; }
    public string SalaryRange1 { get; set; }
    public int? Grade { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<Member> Members { get; set; }
}

