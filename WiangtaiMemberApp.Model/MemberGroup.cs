using System;
namespace WiangtaiMemberApp.Model;

public class MemberGroup
{
    public Guid MemberGroupID { get; set; }
    public Guid MemberGroupTypeID { get; set; }
    public string MemberGroup1 { get; set; }
    public string Address { get; set; }
    public Nullable<Guid> CountryID { get; set; }
    public Nullable<Guid> StateID { get; set; }
    public Nullable<Guid> CityID { get; set; }
    public string Postcode { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Nullable<byte> intCustomerType { get; set; }
    public Nullable<Guid> idMemberGroup { get; set; }
    public Nullable<Guid> idDocument { get; set; }
    public Nullable<bool> bitDuplicates { get; set; }
    public Nullable<bool> bitReportGrouping { get; set; }

    public virtual MemberGroupType MemberGroupType { get; set; }
    public virtual ICollection<MemberGroupDetail> MemberGroupDetails { get; set; }
    public virtual ICollection<ProductPromotion> ProductPromotions { get; set; }
    public virtual ICollection<ProductReward> ProductRewards { get; set; }
}