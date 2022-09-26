using System.Linq.Expressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface IAuthService
{
    public SecurityUser? Login(string username, string password);
}