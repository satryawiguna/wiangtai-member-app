using System;
namespace WiangtaiMemberApp.Model.Response.Member;

public class MemberResponseDto
{
    public Guid MemberId { get; set; }

    public byte? intNoType { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PassportNo { get; set; }

    public string Email { get; set; }

    public string MobilePhone { get; set; }

    public byte? EmailConsent { get; set; }

    public byte? MobileConsent { get; set; }

    public MemberType MemberType { get; set; }

    public Membership Membership { get; set; }

    public DateTime? MemberSince { get; set; }

    public decimal TotalPointBalance { get; set; }

    public decimal TotalCashBack { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public Guid ModifiedBy { get; set; }
}

