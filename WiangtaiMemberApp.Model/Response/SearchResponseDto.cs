using System;
namespace WiangtaiMemberApp.Model.Response;

public class SearchResponseDto<T> where T : class, new()
{
    public int Total { get; set; }

    public IEnumerable<T> Data { get; set; } = default!;
}

