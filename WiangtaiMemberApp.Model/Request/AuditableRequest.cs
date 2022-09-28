using System;

namespace WiangtaiMemberApp.Model.Request;

public abstract class AuditableRequest
{
    public Guid? RequestBy { get; set; }
}

