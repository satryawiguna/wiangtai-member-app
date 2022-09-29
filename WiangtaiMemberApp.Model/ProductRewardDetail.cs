using System;
namespace WiangtaiMemberApp.Model;

public class ProductRewardDetail
{
    public Guid PromotionID { get; set; }
    public Guid VariantID { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
}
