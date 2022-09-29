using System;
namespace WiangtaiMemberApp.Model;

public class MemberRedemption
{
    public Guid RedemptionID { get; set; }
    public Guid MemberID { get; set; }
    public byte RedemptionStatus { get; set; }
    public DateTime RedeemDate { get; set; }
    public string DeliverContact { get; set; }
    public string DeliverAddress1 { get; set; }
    public string DeliverAddress2 { get; set; }
    public string DeliverAddress3 { get; set; }
    public Nullable<Guid> DeliverCountryID { get; set; }
    public Nullable<Guid> DeliverStateID { get; set; }
    public Nullable<Guid> DeliverCityID { get; set; }
    public string DeliverPostcode { get; set; }
    public string DeliverPhone { get; set; }
    public Nullable<int> TotalPoint { get; set; }
    public Nullable<decimal> TotalAmount { get; set; }
    public Nullable<decimal> TotalSubsidy { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<Guid> EntityID { get; set; }
    public string DeliverAddress { get; set; }
    public int RedeemRefNo { get; set; }
    public string DeliverCity { get; set; }
    public string strRedemptionNo { get; set; }
    public Nullable<byte> intChannel { get; set; }
    public Nullable<long> idMasterAccount { get; set; }
    public Nullable<byte> RedemptionLevel { get; set; }
    public Nullable<long> idMerchantLogin { get; set; }
    public string IssuedByID { get; set; }
    public Nullable<int> IssuedByType { get; set; }

    public virtual Region Region { get; set; }
    public virtual Region Region1 { get; set; }
    public virtual Region Region2 { get; set; }
    public virtual ICollection<MemberRedemptionDetail> MemberRedemptionDetails { get; set; }
}

