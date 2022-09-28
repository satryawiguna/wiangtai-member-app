using System;

namespace WiangtaiMemberApp.Model;

public class SecurityPage
{
    public Guid PageID { get; set; }
    public Guid ModuleID { get; set; }
    public string PageName { get; set; } = "";
    public string FilePath { get; set; } = "";
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public string Icon { get; set; } = "";
    public Nullable<short> Sort { get; set; }

    public virtual ICollection<SecurityElement> SecurityElements { get; set; }
}
