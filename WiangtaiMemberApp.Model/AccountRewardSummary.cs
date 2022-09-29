using System;

namespace WiangtaiMemberApp.Model;

public class AccountRewardSummary
{
    public long idRewardSummary { get; set; }
    public Nullable<long> idMasterAccount { get; set; }
    public Nullable<Guid> MemberID { get; set; }
    public DateTime dtStatementMth { get; set; }
    public int intBillingCycle { get; set; }
    public int intOpenPointBalance { get; set; }
    public decimal decOpenRebateBalance { get; set; }
    public Nullable<int> intPointsEarned { get; set; }
    public Nullable<int> intPointsRedeem { get; set; }
    public Nullable<decimal> decRebateEarned { get; set; }
    public Nullable<decimal> decRebateRedeem { get; set; }
    public Nullable<int> IntClosePointBalance { get; set; }
    public Nullable<decimal> decCloseRebateBalance { get; set; }
    public DateTime dtCreate { get; set; }
    public Nullable<DateTime> dtLastUpdate { get; set; }
    public Nullable<int> IntStatus { get; set; }
    public Nullable<int> intPointsExpired { get; set; }
    public Nullable<int> intPointsTransfer { get; set; }
    public Nullable<int> intPointsAdjust { get; set; }
    public Nullable<decimal> decRebateExpire { get; set; }
    public Nullable<decimal> decRebateAdjust { get; set; }
    public Nullable<decimal> decRebateTransfer { get; set; }
    public Nullable<decimal> decRebateExpired { get; set; }

    public virtual Member Member { get; set; }
    public virtual ICollection<AccountRewardDetail> AccountRewardDetails { get; set; }
    public virtual MasterAccount MasterAccount { get; set; }
}