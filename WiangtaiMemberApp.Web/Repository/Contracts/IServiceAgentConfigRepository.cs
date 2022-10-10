using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface IServiceAgentConfigRepository : IBaseRepository<ServiceAgentConfig>
{
    List<ServiceAgentConfig> GetListByFilter(Expression<Func<ServiceAgentConfig, bool>> filter);
}
