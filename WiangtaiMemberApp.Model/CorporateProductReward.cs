using System;
namespace WiangtaiMemberApp.Model;

public class CorporateProductReward
{
    public Guid ProductRewardID { get; set; }
    public string RewardName { get; set; }
    public Nullable<byte> RewardType { get; set; }
    public Nullable<DateTime> FromDate { get; set; }
    public Nullable<DateTime> ToDate { get; set; }
    public Nullable<byte> ExpiryType { get; set; }
    public Nullable<int> ExpiryValue { get; set; }
    public Nullable<byte> TxnType { get; set; }
    public Nullable<Guid> MemberTypeID { get; set; }
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
    public byte intRewardTierAgreegateMode { get; set; }

    public virtual MemberType MemberType { get; set; }
    public virtual RewardFundMaster RewardFundMaster { get; set; }
    public virtual ICollection<CorporateProductRewardDetail> CorporateProductRewardDetails { get; set; }
    public virtual ICollection<CorporateProductRewardExclude> CorporateProductRewardExcludes { get; set; }
    public virtual ICollection<CorporateProductRewardPrice> CorporateProductRewardPrices { get; set; }
}

