using System;
namespace WiangtaiMemberApp.Model.Response;

public class PageSearchResponseDto<T> where T : class, new()
{
    public int Total { get; set; }

    public int Offset { get; set; }

    public int Limit { get; set; }

    public IEnumerable<T> Data { get; set; } = default!;
}

