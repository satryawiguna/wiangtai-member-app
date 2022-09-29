using System;
namespace WiangtaiMemberApp.Model;

public class MemberRedemptionDetail
{
    public Guid RedemptionDetailID { get; set; }
    public Guid RedemptionID { get; set; }
    public Guid RedemptionProductID { get; set; }
    public byte RedemptionDetailStatus { get; set; }
    public Nullable<int> RedeemPoint { get; set; }
    public Nullable<decimal> RedeemAmount { get; set; }
    public Nullable<decimal> RedeemSubsidy { get; set; }
    public Nullable<int> Quantity { get; set; }
    public Nullable<int> TotalPoint { get; set; }
    public Nullable<decimal> TotalAmount { get; set; }
    public Nullable<decimal> TotalSubsidy { get; set; }
    public string VoucherPrefix { get; set; }
    public Nullable<long> VoucherNo { get; set; }
    public int VoucherPrintCount { get; set; }
    public Nullable<DateTime> PostedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<Guid> VoucherID { get; set; }
    public string strBatchNo { get; set; }
    public string strTrackingNo { get; set; }
    public Nullable<DateTime> dtResponseDate { get; set; }
    public Nullable<DateTime> dtShipDate { get; set; }
    public Nullable<DateTime> dtDeliveryDate { get; set; }
    public string strConsignmentNo { get; set; }
    public string remark { get; set; }
    public Nullable<Guid> idRedemptionProductDetail { get; set; }

    public virtual MemberRedemption MemberRedemption { get; set; }
    public virtual RedemptionProduct RedemptionProduct { get; set; }
}

