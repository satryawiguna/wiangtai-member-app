using System;

namespace WiangtaiMemberApp.Model.Response;

public class GenericPagedSearchResponse<TObject> : BasicResponse
{
    private ICollection<TObject> _dtoList;

    public ICollection<TObject> DtoCollection
    {
        get { return this._dtoList ?? (this._dtoList = new List<TObject>()); }
    }

    public int TotalCount { get; set; }
}