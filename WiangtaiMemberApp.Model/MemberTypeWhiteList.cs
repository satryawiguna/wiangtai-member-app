using System;
namespace WiangtaiMemberApp.Model;

public class MemberTypeWhiteList
{
    public int idMemberTypeWhiteList { get; set; }
    public Guid idFromMemberType { get; set; }
    public Guid idToMemberType { get; set; }

    public virtual MemberType MemberType { get; set; }
}

