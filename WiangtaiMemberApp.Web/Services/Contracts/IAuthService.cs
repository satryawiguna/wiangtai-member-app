using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Services.Contracts;

public interface IAuthService
{
    Task<SecurityUser?> Login(string username, string password);
}