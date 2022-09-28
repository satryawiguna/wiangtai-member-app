using System;
using Microsoft.AspNetCore.Mvc;
using WiangtaiMemberApp.Common.Attribute;

namespace WiangtaiMemberApp.Web.Controllers;

[BreadcrumbActionFilter]
public class BaseController : Controller
{

}