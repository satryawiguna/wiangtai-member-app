using System;
namespace WiangtaiMemberApp.Model.Request;

public class SearchRequestDto
{
    public string? orderColumn;

    public string orderDirection = "ASC";

    public string? keyword;
}
