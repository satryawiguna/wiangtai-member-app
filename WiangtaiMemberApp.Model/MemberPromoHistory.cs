using System;
namespace WiangtaiMemberApp.Model;

public class MemberPromoHistory
{
    public Guid MemberPromoHistoryID { get; set; }
    public Nullable<Guid> MemberID { get; set; }
    public Nullable<Guid> idRewardPromo { get; set; }
    public Nullable<DateTime> dtStartDate { get; set; }
    public Nullable<DateTime> dtEndDate { get; set; }
    public string strRemarks { get; set; }
    public Nullable<Guid> CreatedBy { get; set; }
    public Nullable<DateTime> CreatedDate { get; set; }
    public Nullable<Guid> ModifiedBy { get; set; }
    public Nullable<DateTime> ModifiedDate { get; set; }

    public virtual RewardPromo RewardPromo { get; set; }
}

