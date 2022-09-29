using System;
namespace WiangtaiMemberApp.Model;

public class RegionType
{
    public Guid RegionTypeID { get; set; }
    public string RegionType1 { get; set; }
    public Nullable<byte> RegionTypeLevel { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public string RegionTypeCode { get; set; }

    public virtual ICollection<Region> Regions { get; set; }
}