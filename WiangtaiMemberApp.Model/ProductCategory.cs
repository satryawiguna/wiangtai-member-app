using System;
namespace WiangtaiMemberApp.Model;

public class ProductCategory
{
    public Guid ProductCategoryID { get; set; }
    public Nullable<Guid> ProductCategoryParentID { get; set; }
    public string ProductCategoryName { get; set; }
    public short intType { get; set; }
    public string ProductCategoryDesc { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<Product> Products { get; set; }
    public virtual ICollection<ProductCategory> ProductCategory1 { get; set; }
    public virtual ProductCategory ProductCategory2 { get; set; }
}

