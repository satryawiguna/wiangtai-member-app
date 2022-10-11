using System;
namespace WiangtaiMemberApp.Model.Request.Member;

public class UpdateMemberRequestDto
{
    public Guid MemberID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string MobilePhone { get; set; }

    public byte? EmailConsent { get; set; }

    public byte? MobileConsent { get; set; }

    public DateTime? BirthDate { get; set; }

    public byte? Gender { get; set; }

    public string? Race { get; set; }

    public int? MaritalStatus { get; set; }

    public string? Religion { get; set; }

    public string? SalaryRange { get; set; }
}