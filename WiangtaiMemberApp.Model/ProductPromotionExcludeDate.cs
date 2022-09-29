using System;
namespace WiangtaiMemberApp.Model;

public class ProductPromotionExcludeDate
{
    public Guid ProductPromotionExcludedDateID { get; set; }
    public Guid PromotionID { get; set; }
    public DateTime ExcludedDate { get; set; }
    public string Remark { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ProductPromotion ProductPromotion { get; set; }
}

