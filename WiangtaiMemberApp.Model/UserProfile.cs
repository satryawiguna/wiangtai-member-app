using System;

namespace WiangtaiMemberApp.Model;

public class UserProfile
{
    public Guid UserID { get; set; }
    public string EmployeeCode { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string DisplayName { get; set; } = "";
    public Nullable<Guid> DepartmentID { get; set; }
    public string JobTitle { get; set; } = "";
    public string ReportTo { get; set; } = "";
    public string BusinessPhone { get; set; } = "";
    public string MobilePhone { get; set; } = "";
    public string eMail { get; set; } = "";
    public Nullable<byte> Notifier { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string NRIC { get; set; } = "";

    public virtual SecurityUser SecurityUser { get; set; }
    public virtual ICollection<UserProfilePasswordHistory> UserProfilePasswordHistories { get; set; }

}

