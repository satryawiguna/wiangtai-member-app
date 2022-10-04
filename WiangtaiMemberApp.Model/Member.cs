using System;

namespace WiangtaiMemberApp.Model;

public class Member
{
    public Guid MemberID { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string? DisplayName { get; set; }
    public byte? intNoType { get; set; }
    public string? PassportNo { get; set; }
    public string? Email { get; set; }
    public string? MobilePhone { get; set; }
    public byte? Notification { get; set; }
    public Guid? MemberTypeID { get; set; }
    public DateTime? MemberSince { get; set; }
    public DateTime? BirthDate { get; set; }
    public byte? Gender { get; set; }
    public Guid? RaceTypeID { get; set; }
    public byte? MaritalStatus { get; set; }
    public Guid? ReligionID { get; set; }
    public Guid? SalaryRangeID { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }

    public virtual MemberType MemberType { get; set; }
    public virtual RaceType RaceType { get; set; }
    public virtual Religion Religion { get; set; }
    public virtual SalaryRange SalaryRange { get; set; }

    public virtual ICollection<Membership> Memberships { get; set; }
    public virtual ICollection<MemberReward> MemberRewards { get; set; }
}