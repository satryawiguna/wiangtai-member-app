using System;
namespace WiangtaiMemberApp.Model;

public class PointCurrencyValueRate
{
    public long idPointCurrencyRate { get; set; }
    public Nullable<long> idPointCurrency { get; set; }
    public Nullable<DateTime> dtEffective { get; set; }
    public Nullable<decimal> decPointValue { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual PointCurrencyValue PointCurrencyValue { get; set; }
}

