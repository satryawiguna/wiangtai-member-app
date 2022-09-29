using System;
namespace WiangtaiMemberApp.Model;

public class ProductBrand
{
    public Guid BrandID { get; set; }
    public string BrandName { get; set; }
    public string BrandDesc { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}

