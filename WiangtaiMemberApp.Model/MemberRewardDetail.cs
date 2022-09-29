using System;

namespace WiangtaiMemberApp.Model;

public class MemberRewardDetail
{
    public Guid MemberRewardDetailID { get; set; }
    public Guid RewardID { get; set; }
    public Guid VariantID { get; set; }
    public decimal RewardValue { get; set; }
    public decimal UsageAmount { get; set; }
    public Nullable<Guid> ProductRewardPriceID { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<Guid> idMemberRedemption { get; set; }

    public virtual MemberReward MemberReward { get; set; }
}