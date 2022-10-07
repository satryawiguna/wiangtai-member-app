using System;
namespace WiangtaiMemberApp.Model;

public class MemberReward
{
    public Guid RewardID { get; set; }
    public Guid MemberID { get; set; }
    public Guid? ToMemberID { get; set; }
    public byte RewardMethod { get; set; }
    public byte RewardType { get; set; }
    public decimal? RewardValue { get; set; }
    public decimal? UsageAmount { get; set; }
    public long RewardRefNo { get; set; }
    public DateTime? IssuedDate { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public decimal? ConsumeValue { get; set; }
    public decimal? BalanceValue { get; set; }
    public string Remarks { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public DateTime EntitlementDate { get; set; }
    public Guid? RewardFundID { get; set; }
    public string idBatch { get; set; }
    public bool? isExpired { get; set; }
    public decimal? decPointCost { get; set; }

    public virtual Member Member { get; set; }
}

