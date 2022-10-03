using System;
namespace WiangtaiMemberApp.Model;

public class Currency
{
    public Guid CurrencyID { get; set; }
    public string CurrencyCode { get; set; }
    public string CurrencyName { get; set; }
    public int? ExchangeUnit { get; set; }
    public decimal? ExchangeRate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual ICollection<Membership> Memberships { get; set; }
    public virtual ICollection<MemberType> MemberTypes { get; set; }
}
