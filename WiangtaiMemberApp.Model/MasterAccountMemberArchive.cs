using System;

namespace WiangtaiMemberApp.Model;

public class MasterAccountMemberArchive
{
    public long idMasterAccountMemberArchive { get; set; }
    public long idMasterAccount { get; set; }
    public Guid MemberId { get; set; }
    public DateTime dtCreate { get; set; }
    public DateTime dtRemove { get; set; }
    public string strRemarks { get; set; }
    public Guid idCreateBy { get; set; }
    public Guid idRemoveBy { get; set; }

    public virtual Member Member { get; set; }
}