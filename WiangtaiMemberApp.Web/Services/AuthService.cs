using System;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Services;

public class AuthService : IAuthService
{
    private readonly ISecurityUserRepository _securityUserRepository;

    public AuthService(ISecurityUserRepository securityUserRepository)
    {
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

