using System;
namespace WiangtaiMemberApp.Model;

public class RewardPromo
{
    public Guid idRewardPromo { get; set; }
    public string strRewardPromoCode { get; set; }
    public string strRewardPromoName { get; set; }
    public string strDescription { get; set; }
    public Nullable<Guid> CreatedBy { get; set; }
    public Nullable<DateTime> CreatedDate { get; set; }
    public Nullable<Guid> ModifiedBy { get; set; }
    public Nullable<DateTime> ModifiedDate { get; set; }
    public string strReferenceCode { get; set; }
    public Nullable<Guid> PromoIcon { get; set; }
    public Nullable<byte> intPromoType { get; set; }

    public virtual ICollection<ProductPromotion> ProductPromotions { get; set; }
    public virtual ICollection<ProductReward> ProductRewards { get; set; }
    public virtual ICollection<MemberPromo> MemberPromoes { get; set; }
    public virtual ICollection<MemberPromoHistory> MemberPromoHistories { get; set; }
    public virtual ICollection<RewardPromoMemberType> RewardPromoMemberTypes { get; set; }
}
