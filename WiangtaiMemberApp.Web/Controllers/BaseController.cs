using System;
using Microsoft.AspNetCore.Mvc;
using WiangtaiMemberApp.Web.Commons.Attributes;

namespace WiangtaiMemberApp.Web.Controllers;

[BreadcrumbActionFilter]
public class BaseController : Controller
{
}