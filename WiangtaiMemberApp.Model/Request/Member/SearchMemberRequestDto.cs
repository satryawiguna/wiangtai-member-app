using System;
namespace WiangtaiMemberApp.Model.Request.Member;

public class SearchMemberRequestDto
{
    public string keyword { get; set; }
    public int intNoType { get; set; }
    public int memberType { get; set; }
}
