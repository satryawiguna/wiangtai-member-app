using System;
namespace WiangtaiMemberApp.Model;

public class PointCurrencyValue
{
    public long idPointCurrency { get; set; }
    public string tblPointCurrencyValue1 { get; set; }
    public byte intPCVType { get; set; }
    public string strPCVCode { get; set; }
    public string strDescription { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string strName { get; set; }

    public virtual ICollection<MemberType> MemberTypes { get; set; }
    public virtual ICollection<PointCurrencyValueRate> PointCurrencyValueRates { get; set; }
}

