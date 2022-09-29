using System;
using System.IO;

namespace WiangtaiMemberApp.Model;

public class ProductPriceType
{
    public Guid VariantID { get; set; }
    public Guid PriceTypeID { get; set; }
    public Guid CurrencyID { get; set; }
    public decimal SalePrice { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual PriceType PriceType { get; set; }
    public virtual ProductVariant ProductVariant { get; set; }
}

