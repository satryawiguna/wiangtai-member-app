using System;
namespace WiangtaiMemberApp.Model;

public class PriceType
{
    public Guid PriceTypeID { get; set; }
    public string PriceType1 { get; set; }
    public string PriceTypeName { get; set; }
    public Nullable<byte> TargetGroup { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<PriceTypeCriteria> PriceTypeCriterias { get; set; }
    public virtual ICollection<ProductPriceType> ProductPriceTypes { get; set; }
}