using System;
using Microsoft.AspNetCore.Mvc;

namespace WiangtaiMemberApp.Model;

public class Product
{
    public Guid ProductID { get; set; }
    public Guid ProductCategoryID { get; set; }
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public string ProductDesc { get; set; }
    public Nullable<bool> ProductCatalog { get; set; }
    public Nullable<bool> FreeGift { get; set; }
    public Nullable<bool> FeaturedProduct { get; set; }
    public Nullable<Guid> MainImageID { get; set; }
    public Nullable<Guid> ThumbnailImageID { get; set; }
    public Nullable<Guid> ProductBrandID { get; set; }
    public Nullable<Guid> ProductUOMID { get; set; }
    public Nullable<bool> Taxable { get; set; }
    public Nullable<Guid> TaxID { get; set; }
    public string Reference { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<bool> AllowManualTransaction { get; set; }

    public virtual ProductBrand ProductBrand { get; set; }
    public virtual ProductCategory ProductCategory { get; set; }
    public virtual Tax Tax { get; set; }
    public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
    public virtual ICollection<ProductVariant> ProductVariants { get; set; }
}

