using System;

namespace WiangtaiMemberApp.Model;

public class SecuritySessionLogin
{
    public Guid idSecuritySessionLogin { get; set; }
    public Guid UserID { get; set; }
    public DateTime dtCreate { get; set; }
    public DateTime dtExpiry { get; set; }
    public string strCode { get; set; }

    public virtual SecurityUser SecurityUser { get; set; }
}
