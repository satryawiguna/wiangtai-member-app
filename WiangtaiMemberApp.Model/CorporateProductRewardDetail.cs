using System;
namespace WiangtaiMemberApp.Model;

public class CorporateProductRewardDetail
{
    public Guid ProductRewardID { get; set; }
    public Guid ProductVariantID { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ProductVariant ProductVariant { get; set; }
    public virtual CorporateProductReward CorporateProductReward { get; set; }
}

