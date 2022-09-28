using System;

namespace WiangtaiMemberApp.Model.Request;

public class PageSearchRequest
{
    public int PageIndex { get; set; }

    public int PageSize { get; set; }

    public string OrderByFieldName { get; set; }

    public string SortOrder { get; set; }

    public string Keyword { get; set; }
}