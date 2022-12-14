using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Reflection;
using System.Text.RegularExpressions;
using WiangtaiMemberApp.Model;

namespace WiangtaiMemberApp.Web.Commons.Attributes;

public class BreadcrumbActionFilter : ActionFilterAttribute
{
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.HttpContext.Request.Path.HasValue && context.HttpContext.Request.Path.Value.Contains("Api"))
        {
            base.OnActionExecuted(context);
            return;
        }

        var breadcrumbs = this.ConfigureBreadcrumb(context);

        var controller = context.Controller as Controller;
        controller.ViewBag.Breadcrumbs = breadcrumbs;

        base.OnActionExecuted(context);
    }

    private List<Breadcrumb> ConfigureBreadcrumb(ActionExecutedContext context)
    {
        var breadcrumbList = new List<Breadcrumb>();
        var homeControllerName = "Dashboard";

        breadcrumbList.Add(new Breadcrumb
        {
            Text = "Home",
            Action = "Index",
            Controller = homeControllerName,
            Active = true
        });

        if (context.HttpContext.Request.Path.HasValue)
        {
            var pathSplit = context.HttpContext.Request.Path.Value.Split("/");

            for (var i = 0; i < pathSplit.Length; i++)
            {
                if (string.IsNullOrEmpty(pathSplit[i]) || string.Compare(pathSplit[i], homeControllerName, true) == 0)
                {
                    continue;
                }

                var controller = this.GetControllerType(pathSplit[i] + "Controller");

                if (controller != null)
                {
                    var indexMethod = controller.GetMethod("Index");

                    if (indexMethod != null)
                    {
                        breadcrumbList.Add(new Breadcrumb
                        {
                            Text = this.CamelCaseSpacing(pathSplit[i]),
                            Action = "Index",
                            Controller = pathSplit[i],
                            Active = true
                        });

                        if (i + 1 < pathSplit.Length && string.Compare(pathSplit[i + 1], "Index", true) == 0)
                        {
                            breadcrumbList.LastOrDefault().Active = false;

                            return breadcrumbList;
                        }
                    }
                }

                if (i - 1 > 0)
                {
                    var controllerName = pathSplit[i - 1] + "Controller";
                    var prevController = this.GetControllerType(controllerName);

                    if (prevController != null)
                    {
                        var method = prevController.GetMethod(pathSplit[i]);

                        if (method != null)
                        {
                            breadcrumbList.Add(new Breadcrumb
                            {
                                Text = this.CamelCaseSpacing(pathSplit[i]),
                                Action = pathSplit[i],
                                Controller = pathSplit[i - 1]
                            });
                        }
                    }
                }
            }
        }

        breadcrumbList.LastOrDefault().Active = false;

        return breadcrumbList;
    }

    private Type GetControllerType(string name)
    {
        Type controller = null;

        try
        {
            controller = Assembly.GetCallingAssembly().GetType("WiangtaiMemberApp.Web.Controllers." + name);
        }
        catch
        { }

        return controller;
    }

    private string CamelCaseSpacing(string s)
    {
        var r = new Regex(@"
            (?<=[A-Z])(?=[A-Z][a-z]) |
             (?<=[^A-Z])(?=[A-Z]) |
             (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

        return r.Replace(s, " ");
    }
}

