using System;
namespace WiangtaiMemberApp.Model;

public class RedemptionProductDetail
{
    public Guid RedemptionProductDetailID { get; set; }
    public Guid RedemptionProductID { get; set; }
    public Guid CurrencyID { get; set; }
    public int RedeemPoint { get; set; }
    public decimal RedeemAmount { get; set; }
    public decimal SubsidyAmount { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<decimal> CashPayment { get; set; }
    public Nullable<int> CashMode { get; set; }
    public Nullable<int> NumberMonths { get; set; }
    public Nullable<System.Guid> MemberTypeID { get; set; }
    public Nullable<decimal> Cash { get; set; }
    public Nullable<decimal> InstallmentAmount { get; set; }
    public Nullable<decimal> Interest { get; set; }
    public Nullable<int> Duration { get; set; }
    public Nullable<byte> intRedeemMode { get; set; }
    public Nullable<byte> decMonthlyPayment { get; set; }
    public Nullable<decimal> decMonths { get; set; }
    public Nullable<decimal> decInterest { get; set; }
    public string strPlanNumber { get; set; }
    public string strOldPrice { get; set; }

    public virtual RedemptionProduct RedemptionProduct { get; set; }
}

