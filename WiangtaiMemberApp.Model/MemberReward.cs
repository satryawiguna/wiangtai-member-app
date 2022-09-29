using System;

namespace WiangtaiMemberApp.Model;

public class MemberReward
{
    public Guid RewardID { get; set; }
    public Guid MemberID { get; set; }
    public Nullable<Guid> ToMemberID { get; set; }
    public byte RewardMethod { get; set; }
    public byte RewardType { get; set; }
    public Nullable<decimal> RewardValue { get; set; }
    public Nullable<decimal> UsageAmount { get; set; }
    public long RewardRefNo { get; set; }
    public Nullable<DateTime> IssuedDate { get; set; }
    public Nullable<DateTime> EffectiveDate { get; set; }
    public Nullable<DateTime> ExpiryDate { get; set; }
    public Nullable<decimal> ConsumeValue { get; set; }
    public Nullable<decimal> BalanceValue { get; set; }
    public string Remarks { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public DateTime EntitlementDate { get; set; }
    public Nullable<System.Guid> RewardFundID { get; set; }
    public string idBatch { get; set; }
    public Nullable<bool> isExpired { get; set; }
    public Nullable<decimal> decPointCost { get; set; }

    public virtual Member Member { get; set; }
    public virtual ICollection<MemberRewardDetail> MemberRewardDetails { get; set; }
    public virtual ICollection<MemberRewardDeductionTnx> MemberRewardDeductionTnxes { get; set; }
}