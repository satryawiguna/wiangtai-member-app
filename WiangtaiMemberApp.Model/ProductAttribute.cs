using System;
namespace WiangtaiMemberApp.Model;

public class ProductAttribute
{
    public Guid ProductID { get; set; }
    public Guid AttributeID { get; set; }
    public Nullable<int> Sequence { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual Attribute Attribute { get; set; }
    public virtual Product Product { get; set; }
}
