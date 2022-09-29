using System;
namespace WiangtaiMemberApp.Model
{
    public class ProductVariantPrice
    {
        public Guid SellingPriceID { get; set; }
        public Nullable<System.Guid> VariantID { get; set; }
        public Guid PriceTypeID { get; set; }
        public DateTime EffectiveDate { get; set; }
        public Guid SellingPriceCurrencyID { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal PlusFare { get; set; }
        public decimal EliteFare { get; set; }
        public decimal LinkFare { get; set; }
        public decimal BKEFare { get; set; }
        public decimal MetraFare { get; set; }
        public decimal KLAFare { get; set; }
        public decimal SGDFare { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Nullable<System.Guid> DiscountCurrencyID { get; set; }
        public Nullable<byte> DiscountType { get; set; }
        public Nullable<decimal> DiscountValue { get; set; }

        public virtual ProductVariant ProductVariant { get; set; }
    }
}

