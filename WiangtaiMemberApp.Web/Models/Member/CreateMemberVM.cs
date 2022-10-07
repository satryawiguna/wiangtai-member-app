using System;
using System.ComponentModel.DataAnnotations;

namespace WiangtaiMemberApp.Web.Models.Member;

public class CreateMemberVM
{
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Reference type is required")]
    public byte intNoType { get; set; }

    [Required(ErrorMessage = "First number is required")]
    public string PassportNo { get; set; }

    [Required(ErrorMessage = "Mobile phone is required")]
    [Phone(ErrorMessage = "Phone format invalid")]
    public string MobilePhone { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email format invalid")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Member type is required")]
    public Guid MemberType { get; set; }
}
