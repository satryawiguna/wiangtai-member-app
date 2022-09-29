using System;
namespace WiangtaiMemberApp.Model;

public class ProductPromotionQuantity
{
    public Guid PromotionQuantityID { get; set; }
    public Guid PromotionID { get; set; }
    public int Quantity { get; set; }
    public Nullable<decimal> DiscountAmount { get; set; }
    public Nullable<byte> DiscountPercent { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ProductPromotion ProductPromotion { get; set; }
}

