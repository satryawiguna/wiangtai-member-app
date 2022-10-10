using System.ComponentModel.DataAnnotations;

namespace WiangtaiMemberApp.Web.Models.Member;

public class CreateMemberVM
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public byte intNoType { get; set; }

    [Required]
    public string PassportNo { get; set; }

    [Required]
    [Phone]
    public string MobilePhone { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public Guid MemberTypeId { get; set; }
}
