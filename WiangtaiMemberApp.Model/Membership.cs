using System;
namespace WiangtaiMemberApp.Model;

public class Membership
{
    public Guid MembershipID { get; set; }
    public Guid MemberID { get; set; }
    public Guid MemberTypeID { get; set; }
    public long? CardNumber { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid? CurrencyID { get; set; }
    public decimal? AnnualFee { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool NotifyExpiring15Days { get; set; }
    public bool NotifyExpired15Days { get; set; }
    public bool NotifyExpired30Days { get; set; }
    public bool PassAutoRenewal { get; set; }
    public bool SMSNotifyExpiring15Days { get; set; }
    public string CardNumberEncrypted { get; set; }
    public string CardNumberShow { get; set; }
    public string strIndicatorCode { get; set; }
    public string strReasonCode { get; set; }
    public string strReasonDesc { get; set; }

    public virtual Member Member { get; set; }
    public virtual MemberType MemberType { get; set; }
    public virtual Currency Currency { get; set; }
}

