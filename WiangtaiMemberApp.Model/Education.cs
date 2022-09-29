using System;

namespace WiangtaiMemberApp.Model;

public class Education
{
    public Guid EducationID { get; set; }
    public string Education1 { get; set; }
    public Nullable<int> Grade { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string Code { get; set; }

    public virtual ICollection<MasterAccount> MasterAccounts { get; set; }
}