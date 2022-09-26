using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Models.Auth;
using WiangtaiMemberApp.Web.Services.Contracts;

namespace WiangtaiMemberApp.Web.Controllers;

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
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginVM model)
    {
        if (ModelState.IsValid)
        {
            var loginResponse = _authService.Login(model.Username, model.Password);

            if (loginResponse != null)
            {
                return RedirectToAction("Index", "Dashboard");
            }

            AddTempData("message", "danger", $"Incorrect Password or Username.");

            return RedirectToAction("Login", "Auth");
        }

        AddTempData("message", "danger", $"Login form datas is not valid");

        return RedirectToAction("Login", "Auth");
    }

    public void AddTempData(string key, string alert, string value)
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
}

