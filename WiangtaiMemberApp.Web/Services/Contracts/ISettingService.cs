using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface ISettingService
{
    Setting? GetSettingByFilter(Expression<Func<Setting, bool>> filter);
}

