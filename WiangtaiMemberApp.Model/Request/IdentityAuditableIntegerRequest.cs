using System;

namespace WiangtaiMemberApp.Model.Request;

public class IdentityAuditableIntegerRequest : AuditableRequest
{
    public int ID { get; set; }
}