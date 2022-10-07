using System;
namespace WiangtaiMemberApp.Model;

public class Setting
{
    public Guid idSetting { get; set; }
    public string strName { get; set; }
    public string strValue { get; set; }
    public string strType { get; set; }
    public Nullable<short> intSort { get; set; }
    public Nullable<short> intGroup { get; set; }
}

