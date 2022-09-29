using System;

namespace WiangtaiMemberApp.Model;

public class MemberRewardDeductionTnx
{
    public Guid MemberRewardDeductionTxnID { get; set; }
    public Guid RewardID { get; set; }
    public Guid HistoryID { get; set; }
    public decimal Value { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual MemberReward MemberReward { get; set; }
}