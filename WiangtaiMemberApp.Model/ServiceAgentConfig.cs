namespace WiangtaiMemberApp.Model;

public class ServiceAgentConfig
{
    public Guid idServiceAgentConfig { get; set; }
    public Guid UserId { get; set; }
    public Guid? MemberTypeId { get; set; }
    public DateTime dtCreate { get; set; }
    public DateTime dtModify { get; set; }
    public string strCreatedBy { get; set; }
    public string strModifiedBy { get; set; }
    public Guid? MemberGroupId { get; set; }

    public virtual SecurityUser SecurityUser { get; set; }
}

