using System;
using Serilog.Context;
using Serilog.Core.Enrichers;

namespace WiangtaiMemberApp.Web.Middleware;

public class RequesterLogMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var requester = GetRequesterDetails();

        PropertyEnricher requesterIdentifierProperty = new PropertyEnricher("RequesterId", requester.Id);
        PropertyEnricher requesterNameProperty = new PropertyEnricher("RequesterName", requester.Name);

        using (LogContext.Push(requesterIdentifierProperty, requesterNameProperty))
        {
            await next(context);
        }
    }

    private (string Id, string Name) GetRequesterDetails()
    {
        return (string.Empty, "Anonymous");
    }
}

