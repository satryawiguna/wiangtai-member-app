using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Services;

public class AuthService : IAuthService
{
    private readonly ILogger<AuthService> _logger;
    private readonly IMapper _mapper;
    private readonly ISecurityUserRepository _securityUserRepository;

    public AuthService(ILogger<AuthService> logger,
        IMapper mapper,
        ISecurityUserRepository securityUserRepository)
    {
        _logger = logger;
        _mapper = mapper;
        _securityUserRepository = securityUserRepository;
    }

    public async Task<SecurityUser?> Login(string username, string password)
    {
        return _securityUserRepository.GetByFilterIncludeRole(r => r.UserName == username && r.UserPassword == sha256_hash(password));
    }

    private String sha256_hash(String value)
    {
        StringBuilder stringBuilder = new StringBuilder();

        using (SHA256 hash = SHA256Managed.Create())
        {
            Encoding encoding = Encoding.UTF8;
            Byte[] results = hash.ComputeHash(encoding.GetBytes(value));

            foreach (Byte result in results)
                stringBuilder.Append(result.ToString("x2"));
        }

        return stringBuilder.ToString();
    }
}

