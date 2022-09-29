using System;

namespace WiangtaiMemberApp.Model;

public class MemberRewardHistory
{
    public Guid HistoryID { get; set; }
    public Guid MemberID { get; set; }
    public Nullable<Guid> ToMemberID { get; set; }
    public byte HistoryType { get; set; }
    public byte RewardType { get; set; }
    public decimal RewardValue { get; set; }
    public string Remarks { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<System.Guid> RewardID { get; set; }
    public Nullable<byte> TransferReasonType { get; set; }
    public Nullable<System.Guid> RewardFundID { get; set; }
    public Nullable<System.Guid> idBatch { get; set; }

    public virtual Member Member { get; set; }
    public virtual ICollection<MemberRewardDeductionTnx> MemberRewardDeductionTnxes { get; set; }
}