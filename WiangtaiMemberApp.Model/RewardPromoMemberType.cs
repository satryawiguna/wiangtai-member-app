using System;
namespace WiangtaiMemberApp.Model;

public class RewardPromoMemberType
{
    public Guid idRewardPromoMemberType { get; set; }
    public Guid idRewardPromo { get; set; }
    public Guid MemberTypeID { get; set; }
    public DateTime dtCreate { get; set; }
    public string strCreateBy { get; set; }
    public DateTime dtLastModify { get; set; }
    public string strLastModifiedBy { get; set; }

    public virtual MemberType MemberType { get; set; }
    public virtual RewardPromo RewardPromo { get; set; }
}