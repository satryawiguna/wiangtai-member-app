using System;
namespace WiangtaiMemberApp.Model;

public class MemberPromo
{
    public Guid MemberPromoID { get; set; }
    public Guid MemberID { get; set; }
    public Guid idRewardPromo { get; set; }
    public Nullable<DateTime> dtStartDate { get; set; }
    public Nullable<Guid> CreatedBy { get; set; }
    public Nullable<DateTime> CreatedDate { get; set; }
    public Nullable<Guid> ModifiedBy { get; set; }
    public Nullable<DateTime> ModifiedDate { get; set; }

    public virtual RewardPromo RewardPromo { get; set; }
}