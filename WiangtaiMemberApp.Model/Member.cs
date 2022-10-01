using System;

namespace WiangtaiMemberApp.Model;

public class Member
{
    public Guid MemberID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public Nullable<byte> intNoType { get; set; }
    public string PassportNo { get; set; }
    public string Email { get; set; }
    public string MobilePhone { get; set; }
    public Nullable<byte> Notification { get; set; }
    public Nullable<Guid> MemberTypeID { get; set; }
    public Nullable<DateTime> MemberSince { get; set; }
    public Nullable<DateTime> BirthDate { get; set; }
    public Nullable<byte> Gender { get; set; }
    public Nullable<Guid> RaceTypeID { get; set; }
    public Nullable<byte> MaritalStatus { get; set; }
    public Nullable<Guid> ReligionID { get; set; }
    public Nullable<Guid> SalaryRangeID { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual MemberType MemberType { get; set; }
    public virtual RaceType RaceType { get; set; }
    public virtual Religion Religion { get; set; }

    public virtual ICollection<Membership> Memberships { get; set; }
}