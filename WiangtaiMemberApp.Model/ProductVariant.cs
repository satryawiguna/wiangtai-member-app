using System;
namespace WiangtaiMemberApp.Model;

public class ProductVariant
{
    public Guid VariantID { get; set; }
    public Guid ProductID { get; set; }
    public string VariantCode { get; set; }
    public string VariantName { get; set; }
    public string VariantDesc { get; set; }
    public Nullable<DateTime> SaleStartDate { get; set; }
    public Nullable<DateTime> SaleEndDate { get; set; }
    public Nullable<Guid> MainImageID { get; set; }
    public Nullable<Guid> ThumbnailImageID { get; set; }
    public Nullable<Guid> CurrencyID { get; set; }
    public Nullable<decimal> CostPrice { get; set; }
    public Nullable<decimal> SalePrice { get; set; }
    public Nullable<Guid> PriceTypeID { get; set; }
    public Nullable<bool> Featured { get; set; }
    public Nullable<bool> FreeGift { get; set; }
    public Nullable<bool> ShowInCatalog { get; set; }
    public Nullable<bool> Consignment { get; set; }
    public Nullable<int> Point { get; set; }
    public Nullable<int> PointExpiry { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<MemberRewardDetail> MemberRewardDetails { get; set; }
    public virtual Product Product { get; set; }
    public virtual ICollection<ProductPriceType> ProductPriceTypes { get; set; }
    public virtual ICollection<ProductPromotionExclude> ProductPromotionExcludes { get; set; }
    public virtual ICollection<ProductRewardDetail> ProductRewardDetails { get; set; }
    public virtual ICollection<ProductRewardExclude> ProductRewardExcludes { get; set; }
    public virtual ICollection<ProductVariantPrice> ProductVariantPrices { get; set; }
    public virtual ICollection<ProductVariantValue> ProductVariantValues { get; set; }
    public virtual ICollection<CorporateProductRewardDetail> CorporateProductRewardDetails { get; set; }
    public virtual ICollection<CorporateProductRewardExclude> CorporateProductRewardExcludes { get; set; }
}
