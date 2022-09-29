using System;

namespace WiangtaiMemberApp.Model;

public class Member
{
    public Guid MemberID { get; set; }
    public long MemberCode { get; set; }
    public Nullable<Guid> SalutationID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public Nullable<DateTime> BirthDate { get; set; }
    public Nullable<byte> Gender { get; set; }
    public Nullable<byte> MaritalStatus { get; set; }
    public string NRIC { get; set; }
    public string PassportNo { get; set; }
    public string CompanyName { get; set; }
    public Nullable<Guid> JobTitleID { get; set; }
    public string CompanyAddress { get; set; }
    public Nullable<Guid> CompanyCountryID { get; set; }
    public Nullable<Guid> CompanyStateID { get; set; }
    public Nullable<Guid> CompanyCityID { get; set; }
    public string CompanyPostCode { get; set; }
    public string CompanyPhone { get; set; }
    public string CompanyFax { get; set; }
    public string HomeAddress1 { get; set; }
    public string HomeAddress2 { get; set; }
    public string HomeAddress3 { get; set; }
    public Nullable<Guid> HomeCountryID { get; set; }
    public Nullable<Guid> HomeStateID { get; set; }
    public Nullable<Guid> HomeCityID { get; set; }
    public string HomePostcode { get; set; }
    public string HomePhone { get; set; }
    public string HomeFax { get; set; }
    public string MobilePhone { get; set; }
    public string Email { get; set; }
    public Nullable<byte> PreferredContact { get; set; }
    public string MemberLogin { get; set; }
    public string MemberPassword { get; set; }
    public Nullable<Guid> MemberGroupID { get; set; }
    public Nullable<Guid> MemberTypeID { get; set; }
    public Nullable<DateTime> MemberSince { get; set; }
    public Nullable<byte> MemberStatus { get; set; }
    public Nullable<Guid> RefererID { get; set; }
    public Nullable<byte> Notification { get; set; }
    public Nullable<Guid> NationalityID { get; set; }
    public Nullable<Guid> EducationID { get; set; }
    public Nullable<Guid> SalaryRangeID { get; set; }
    public Nullable<Guid> ParentMemberID { get; set; }
    public Nullable<Guid> RaceTypeID { get; set; }
    public Nullable<Guid> ReligionID { get; set; }
    public string ReNo { get; set; }
    public string Remarks { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string HomeAddress { get; set; }
    public string HomeCity { get; set; }
    public bool ConvertFromTnG { get; set; }
    public Nullable<DateTime> NextBirthday { get; set; }
    public Nullable<short> intBIllingCycle { get; set; }
    public Nullable<byte> intNoType { get; set; }
    public bool intAllowRedem { get; set; }
    public Nullable<bool> intAllowGetPoints { get; set; }
    public Nullable<byte> intCustomerType { get; set; }
    public Nullable<bool> bitEStatement { get; set; }
    public Nullable<DateTime> dtEStatementSubscribe { get; set; }
    public Nullable<bool> bitValidateMasterAccount { get; set; }
    public string HomeState { get; set; }
    public string HomeCountry { get; set; }

    public virtual ICollection<MemberReward> MemberRewards { get; set; }
    public virtual ICollection<MemberRewardHistory> MemberRewardHistories { get; set; }
    public virtual ICollection<AccountRewardDetail> AccountRewardDetails { get; set; }
    public virtual ICollection<MasterAccountMember> MasterAccountMembers { get; set; }
    public virtual ICollection<MasterAccountMemberArchive> MasterAccountMemberArchives { get; set; }
    public virtual ICollection<MemberHobby> MemberHobbies { get; set; }
    public virtual ICollection<MemberInterest> MemberInterests { get; set; }
    public virtual ICollection<MemberTypeMoveHistory> MemberTypeMoveHistories { get; set; }
    public virtual ICollection<MerchantProductRating> MerchantProductRatings { get; set; }
}