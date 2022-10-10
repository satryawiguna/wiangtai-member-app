using System.Linq.Expressions;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class ServiceAgentConfigRepository : BaseRepository<ServiceAgentConfig>, IServiceAgentConfigRepository
{
    public ServiceAgentConfigRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }

    public List<ServiceAgentConfig> GetListByFilter(Expression<Func<ServiceAgentConfig, bool>> filter)
    {
        return _entities.Where(filter).ToList();
    }
}