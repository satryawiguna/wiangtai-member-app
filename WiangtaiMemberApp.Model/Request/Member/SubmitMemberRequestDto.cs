using System;
namespace WiangtaiMemberApp.Model.Request.Member;

public class SubmitMemberRequestDto
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public byte intNoType { get; set; }

    public string PassportNo { get; set; }

    public string MobilePhone { get; set; }

    public string Email { get; set; }

    public Guid MemberTypeId { get; set; }
}

