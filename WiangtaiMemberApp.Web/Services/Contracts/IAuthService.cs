using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface IAuthService
{
    SecurityUser GetByFilter(Expression<Func<SecurityUser, bool>> filter);
}