using System;
namespace WiangtaiMemberApp.Model.Request;

public class PageSearchRequestDto
{
    public int offset = 0;
    public int limit = 10;
    public string? orderColumn;
    public string orderDirection = "DESC";
    public string? keyword;
    
}

