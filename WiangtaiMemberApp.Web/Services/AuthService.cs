using System;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
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

    public SecurityUser? Login(string username, string password)
    {
        var user = _securityUserRepository.GetByFilter(r => r.UserName == username && r.UserPassword == sha256_hash(password));

        if (user != null)
        {
            var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Name, user.UserID.ToString()),
                new Claim("UserName", user.UserName)
            }, CookieAuthenticationDefaults.AuthenticationScheme);
        }

        return user;
    }

    private String sha256_hash(String value)
    {
        StringBuilder Sb = new StringBuilder();

        using (SHA256 hash = SHA256Managed.Create())
        {
            Encoding enc = Encoding.UTF8;
            Byte[] result = hash.ComputeHash(enc.GetBytes(value));

            foreach (Byte b in result)
                Sb.Append(b.ToString("x2"));
        }

        return Sb.ToString();
    }
}

