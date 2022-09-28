using System;

namespace WiangtaiMemberApp.Model.Response;

public class GenericObjectResponse<TObject> : BasicResponse
{
    public TObject Dto { get; set; }
}