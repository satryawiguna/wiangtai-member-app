using System;
namespace WiangtaiMemberApp.Model;

public class ProductReward
{
    public Guid ProductRewardID { get; set; }
    public string RewardName { get; set; }
    public Nullable<byte> RewardType { get; set; }
    public Nullable<DateTime> FromDate { get; set; }
    public Nullable<DateTime> ToDate { get; set; }
    public Nullable<byte> ExpiryType { get; set; }
    public Nullable<int> ExpiryValue { get; set; }
    public Nullable<byte> TxnType { get; set; }
    public Nullable<System.Guid> MemberTypeID { get; set; }
    public Nullable<decimal> SubsidyAmount { get; set; }
    public Nullable<byte> GracePeriod { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<decimal> FormulaPrice { get; set; }
    public Nullable<int> FormulaPoint { get; set; }
    public string PromoCode { get; set; }
    public Nullable<Guid> RewardFundID { get; set; }
    public Nullable<int> CalculationFrequency { get; set; }
    public Nullable<int> ProcessDay { get; set; }
    public Nullable<DateTime> Time { get; set; }
    public Nullable<Guid> idRewardPromo { get; set; }
    public Nullable<byte> intSpecialRules { get; set; }
    public string ProgramCode { get; set; }
    public Nullable<byte> intRunStatus { get; set; }
    public Nullable<byte> intStatus { get; set; }
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

    public virtual MemberGroup MemberGroup { get; set; }
    public virtual MemberType MemberType { get; set; }
    public virtual RewardFundMaster RewardFundMaster { get; set; }
    public virtual RewardPromo RewardPromo { get; set; }
    public virtual ICollection<ProductRewardDetail> ProductRewardDetails { get; set; }
    public virtual ICollection<ProductRewardExclude> ProductRewardExcludes { get; set; }
    public virtual ICollection<ProductRewardPrice> ProductRewardPrices { get; set; }
}

