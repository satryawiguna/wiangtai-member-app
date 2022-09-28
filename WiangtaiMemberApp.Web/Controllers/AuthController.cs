using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Models.Auth;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Controllers;

[AllowAnonymous]
public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    private readonly IAuthService _authService;

    public AuthController(ILogger<AuthController> logger,
        IAuthService authService)
    {
        _logger = logger;
        _authService = authService;
    }

    [HttpGet]
    public IActionResult Login()
    {
        var username = HttpContext.User.Identity.Name;

        if (username is not null)
        {
            return Redirect("/Dashboard");
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginVM model)
    {
        if (ModelState.IsValid)
        {
            var securityUser = await _authService.Login(model.Username, model.Password);

            if (securityUser is not null)
            {
                 await SignInUser(securityUser);

                if (string.IsNullOrWhiteSpace(model.ReturnUrl) || !model.ReturnUrl.StartsWith("/"))
                {
                    model.ReturnUrl = "/Dashboard";
                }

                return Redirect(model.ReturnUrl);
            }

            SetTempData("message", "danger", $"Incorrect Password or Username.");
        }
        else
        {
            SetTempData("message", "danger", $"Login form datas is not valid");
        }

        return Redirect("/Auth/Login");
    }

    private void SetTempData(string key, string alert, string value)
    {
        try
        {
            TempData.Remove(key);
            TempData.Add(key, value);
            TempData.Add("alertType", alert);
        }
        catch
        {
            Debug.WriteLine("TempDataMessage Error");
        }
    }

    private async Task SignInUser(SecurityUser? securityUser)
    {
        var securityRole = (securityUser.SecurityUserRoles is not null) ? securityUser.SecurityUserRoles.First() : null;

        var roleName = (securityUser.SecurityUserRoles is not null) ? securityUser.SecurityUserRoles.Select(sr => sr.SecurityRole).First().RoleName ?? "" : "";

        var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, securityUser.UserLogin),
                new Claim(ClaimTypes.Role, roleName),
                new Claim("FullName", securityUser.UserName),
            };

        var claimsIdentity = new ClaimsIdentity(claims,
            CookieAuthenticationDefaults.AuthenticationScheme);

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity));
    }
}

