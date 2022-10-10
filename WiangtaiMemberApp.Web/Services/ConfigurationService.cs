using System.Linq.Expressions;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Services;

public class ConfigurationService : IConfigurationService
{
    private readonly IServiceAgentConfigRepository _serviceAgentConfigRepository;

    public ConfigurationService(IServiceAgentConfigRepository serviceAgentConfigRepository)
    {
        _serviceAgentConfigRepository = serviceAgentConfigRepository;
    }

    public IEnumerable<ServiceAgentConfig> GetAllServiceAgentConfigsByFilter(Expression<Func<ServiceAgentConfig, bool>> filter)
    {
        return _serviceAgentConfigRepository.GetListByFilter(filter);
    }
}