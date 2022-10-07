using System;
namespace WiangtaiMemberApp.Model.Response.Member;

public class MemberDto
{
    public Guid MemberId { get; set; }

    public string FirstName { get; set; }

    public string? LastName { get; set; }

    public byte? intNoType { get; set; }

    public string? PassportNo { get; set; }

    public string? Email { get; set; }

    public string? MobilePhone { get; set; }

    public byte? EmailConsent { get; set; }

    public byte? MobileConsent { get; set; }

    public string? MemberType { get; set; }

    public long[]? MemberCard { get; set; }

    public DateTime? MemberSince { get; set; }

    public decimal TotalPointBalance { get; set; }

    public decimal TotalCashBack { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public Guid ModifiedBy { get; set; }

    public DateTime? BirthDate { get; set; }

    public byte? Gender { get; set; }

    public string? Race { get; set; }

    public int? MaritalStatus { get; set; }

    public string? Religion { get; set; }

    public string? SalaryRange { get; set; }

}

