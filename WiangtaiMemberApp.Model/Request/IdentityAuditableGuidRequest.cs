using System;

namespace WiangtaiMemberApp.Model.Request;

public class IdentityAuditableGuidRequest : AuditableRequest
{
    public Guid ID { get; set; }
}