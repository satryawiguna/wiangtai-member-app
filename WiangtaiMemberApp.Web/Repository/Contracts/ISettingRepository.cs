using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Repository.Contracts;

public interface ISettingRepository : IBaseRepository<Setting>
{
    Setting? GetByFilter(Expression<Func<Setting, bool>> filter);
}

