using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Commons;

public class Shared
{
    internal static UserMemberTierAccess GetUserMemberTierAccessList(List<ServiceAgentConfig> serviceAgentConfigs)
    {
        UserMemberTierAccess userMemberTierAccess = new UserMemberTierAccess();

        if (serviceAgentConfigs != null && serviceAgentConfigs.Count > 0)
        {
            userMemberTierAccess.MemberTypeList = serviceAgentConfigs.Where(p => p.MemberTypeId.HasValue).Select(p => p.MemberTypeId.Value).ToList();
            userMemberTierAccess.MemberGroupList = serviceAgentConfigs.Where(p => p.MemberGroupId.HasValue).Select(p => p.MemberGroupId.Value).ToList();

            return userMemberTierAccess;
        }

        return new UserMemberTierAccess();
    }
}

internal class UserMemberTierAccess
{
    public List<Guid> MemberTypeList = new List<Guid>();
    public List<Guid> MemberGroupList = new List<Guid>();
}