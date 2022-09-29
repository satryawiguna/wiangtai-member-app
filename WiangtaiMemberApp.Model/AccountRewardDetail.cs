using System;

namespace WiangtaiMemberApp.Model;

public class AccountRewardDetail
{
    public long idRewardSummarydDetail { get; set; }
    public Nullable<long> idRewardSummary { get; set; }
    public Nullable<long> idMasterAccount { get; set; }
    public Nullable<Guid> MemberId { get; set; }
    public Nullable<Guid> RewardId { get; set; }
    public Nullable<Guid> RedemptionId { get; set; }

    public virtual Member Member { get; set; }
    public virtual MasterAccount MasterAccount { get; set; }
    public virtual MemberReward MemberReward { get; set; }
    public virtual AccountRewardSummary AccountRewardSummary { get; set; }
}