using System;
namespace WiangtaiMemberApp.Model;

public class ProductPromotion
{
    public Guid PromotionID { get; set; }
    public string SchemeName { get; set; }
    public string SchemeDesc { get; set; }
    public int AdditionalPoints { get; set; }
    public Nullable<DateTime> FromDate { get; set; }
    public Nullable<DateTime> ToDate { get; set; }
    public Nullable<DateTime> StartTime { get; set; }
    public Nullable<DateTime> EndTime { get; set; }
    public byte AvailableDay { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<byte> DiscountPercent { get; set; }
    public Nullable<decimal> DiscountAmount { get; set; }
    public Nullable<byte> DiscountSelection { get; set; }
    public Nullable<bool> LastMinuteDeal { get; set; }
    public Nullable<Guid> ImageID { get; set; }
    public Nullable<int> PromotionPointsAllotment { get; set; }
    public Nullable<decimal> PromotionRebatesAllotment { get; set; }
    public string ReferenceCode { get; set; }
    public Nullable<int> intPointsQuotaMember { get; set; }
    public Nullable<int> GracePeriod { get; set; }
    public Nullable<decimal> decRebatesQuotaMember { get; set; }
    public Nullable<int> ExpiryType { get; set; }
    public Nullable<int> ExpiryValue { get; set; }
    public Nullable<byte> intMemberQuotaType { get; set; }
    public Nullable<byte> intMemberLevel { get; set; }
    public Nullable<Guid> RewardFundID { get; set; }
    public Nullable<byte> GiftType { get; set; }
    public Nullable<byte> CalculationFrequency { get; set; }
    public Nullable<byte> ProcessDay { get; set; }
    public Nullable<DateTime> ProcessDate { get; set; }
    public Nullable<DateTime> ProcessTime { get; set; }
    public Nullable<Guid> idRewardPromo { get; set; }
    public Nullable<Guid> MemberTypeID { get; set; }
    public string strNotificationEmail { get; set; }
    public string CampaignCode { get; set; }
    public Nullable<byte> intRunStatus { get; set; }
    public Nullable<byte> intStatus { get; set; }
    public Nullable<byte> intSpecialRules { get; set; }
    public string strRuleName { get; set; }
    public Nullable<Guid> idActivityQuerySchedule { get; set; }
    public Nullable<bool> bitGroupType { get; set; }
    public Nullable<Guid> MemberGroupId { get; set; }
    public Nullable<byte> RewardDriver { get; set; }
    public Nullable<byte> TierRule { get; set; }
    public Nullable<short> intRoundingMethod { get; set; }
    public Nullable<short> intNoOfDecimal { get; set; }
    public Nullable<int> intDirectCampaign { get; set; }
    public Nullable<int> intNotifyXDaysBeforeEnd { get; set; }
    public Nullable<int> intNotifyQuotaReachedPercent { get; set; }

    public virtual MemberGroup MemberGroup { get; set; }
    public virtual MemberType MemberType { get; set; }
    public virtual RewardFundMaster RewardFundMaster { get; set; }
    public virtual RewardPromo RewardPromo { get; set; }
    public virtual ICollection<ProductPromotionExclude> ProductPromotionExcludes { get; set; }
    public virtual ICollection<ProductPromotionExcludeDate> ProductPromotionExcludeDates { get; set; }
    public virtual ICollection<ProductPromotionQuantity> ProductPromotionQuantities { get; set; }
}

