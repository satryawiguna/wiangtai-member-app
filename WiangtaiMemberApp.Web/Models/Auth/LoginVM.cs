using System.ComponentModel.DataAnnotations;

namespace WiangtaiMemberApp.Web.Models.Auth;

public class LoginVM
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    public string ReturnUrl { get; set; }
}