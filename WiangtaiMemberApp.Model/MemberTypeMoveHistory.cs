using System;

namespace WiangtaiMemberApp.Model;

public class MemberTypeMoveHistory
{
    public long idMemberTypeMoveHistory { get; set; }
    public Guid MemberId { get; set; }
    public Guid MemberTypeId { get; set; }
    public Nullable<Guid> DestMemberTypeId { get; set; }
    public long idMemberTypeMoveRule { get; set; }
    public Nullable<DateTime> dtMove { get; set; }
    public Nullable<decimal> decThresholdValueMin { get; set; }
    public Nullable<decimal> decThresholdValueMax { get; set; }
    public Nullable<decimal> decActualValue { get; set; }
    public bool intStatus { get; set; }
    public DateTime dtCreate { get; set; }
    public DateTime dtModify { get; set; }
    public Nullable<DateTime> expiryDate { get; set; }
    public Nullable<DateTime> lastPurchaseDate { get; set; }
    public Nullable<Guid> idMemberTypeMoveRuleDetail { get; set; }
    public Nullable<bool> isExtended { get; set; }

    public virtual Member Member { get; set; }
}