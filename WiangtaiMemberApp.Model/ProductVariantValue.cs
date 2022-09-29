using System;
namespace WiangtaiMemberApp.Model;

public class ProductVariantValue
{
    public Guid ValueID { get; set; }
    public Guid VariantID { get; set; }
    public Guid AttributeID { get; set; }
    public string ValueText { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public byte intOperator { get; set; }

    public virtual ProductVariant ProductVariant { get; set; }
}