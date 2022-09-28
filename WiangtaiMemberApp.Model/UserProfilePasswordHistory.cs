using System;

namespace WiangtaiMemberApp.Model;

public class UserProfilePasswordHistory
{
    public Guid idPwdHistory { get; set; }
    public string strLoginId { get; set; } = "";
    public string strPassword { get; set; } = "";
    public DateTime dtPwdGenerate { get; set; }
    public Guid UserID { get; set; }
    public Nullable<byte> intChangeType { get; set; }

    public virtual UserProfile UserProfile { get; set; }
}