using System;
namespace WiangtaiMemberApp.Model;

public class RewardFundMaster
{
    public Guid RewardFundID { get; set; }
    public string strRewardFundCode { get; set; }
    public string strRewardFundName { get; set; }
    public string strDescription { get; set; }
    public Nullable<Guid> CreatedBy { get; set; }
    public Nullable<DateTime> CreatedDate { get; set; }
    public Nullable<Guid> ModifiedBy { get; set; }
    public Nullable<DateTime> ModifiedDate { get; set; }
    public Nullable<long> idPointCurrency { get; set; }

    public virtual ICollection<Loyalty> Loyalties { get; set; }
    public virtual ICollection<ProductPromotion> ProductPromotions { get; set; }
    public virtual ICollection<ProductReward> ProductRewards { get; set; }
    public virtual ICollection<CorporateProductReward> CorporateProductRewards { get; set; }
}