using System;
namespace WiangtaiMemberApp.Model;

public class Region
{
    public Guid RegionID { get; set; }
    public string RegionName { get; set; }
    public string RegionCode { get; set; }
    public Nullable<System.Guid> RegionTypeID { get; set; }
    public Nullable<System.Guid> RegionParentID { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public string Nationality { get; set; }

    public virtual ICollection<Entity> Entities { get; set; }
    public virtual ICollection<Entity> Entities1 { get; set; }
    public virtual ICollection<Entity> Entities2 { get; set; }
    public virtual ICollection<MemberRedemption> MemberRedemptions { get; set; }
    public virtual ICollection<MemberRedemption> MemberRedemptions1 { get; set; }
    public virtual ICollection<MemberRedemption> MemberRedemptions2 { get; set; }
    public virtual ICollection<PriceTypeCriteria> PriceTypeCriterias { get; set; }
    public virtual ICollection<Region> Region1 { get; set; }
    public virtual Region Region2 { get; set; }
    public virtual RegionType RegionType { get; set; }
    public virtual ICollection<MasterAccount> MasterAccounts { get; set; }
    public virtual ICollection<MasterAccount> MasterAccounts1 { get; set; }
    public virtual ICollection<MasterAccount> MasterAccounts2 { get; set; }
    public virtual ICollection<MasterAccount> MasterAccounts3 { get; set; }
}

