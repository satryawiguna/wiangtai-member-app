using System;
namespace WiangtaiMemberApp.Model;

public class PriceTypeCriteria
{
    public Guid CriteriaID { get; set; }
    public Guid PriceTypeID { get; set; }
    public Guid SourceID { get; set; }
    public string SourceTable { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual PriceType PriceType { get; set; }
    public virtual Region Region { get; set; }
}