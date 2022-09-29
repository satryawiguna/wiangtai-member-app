using System;
namespace WiangtaiMemberApp.Model;

public class MemberTypeDetail
{
    public Guid MemberTypeDetailID { get; set; }
    public Guid MemberTypeID { get; set; }
    public Guid CurrencyID { get; set; }
    public decimal AnnualFee { get; set; }
    public DateTime EffectiveDate { get; set; }
    public int Points { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual MemberType MemberType { get; set; }
}
