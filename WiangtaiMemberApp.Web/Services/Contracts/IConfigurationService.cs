using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface IConfigurationService
{
    IEnumerable<ServiceAgentConfig> GetAllServiceAgentConfigsByFilter(Expression<Func<ServiceAgentConfig, bool>> filter);
}

