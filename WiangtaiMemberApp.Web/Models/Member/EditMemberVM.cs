using System;
using System.ComponentModel.DataAnnotations;

namespace WiangtaiMemberApp.Web.Models.Member;

public class EditMemberVM
{
    [Required]
    public Guid MemberID { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public byte intNoType { get; set; }

    public string PassportNo { get; set; }

    [Required]
    [Phone]
    public string MobilePhone { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public byte? EmailConsent { get; set; }

    [Required]
    public byte? MobileConsent { get; set; }

    public Guid MemberTypeId { get; set; }

    public long[]? MemberCard { get; set; }

    public DateTime? MemberSince { get; set; }

    public decimal TotalPointBalance { get; set; }

    public decimal TotalCashBack { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    public int Gender { get; set; }

    [Required]
    public int RaceTypeID { get; set; }

    [Required]
    public int MaritalStatus { get; set; }

    [Required]
    public int ReligionID { get; set; }

    [Required]
    public int SalaryRangeID { get; set; }
}