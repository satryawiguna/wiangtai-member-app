using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Serilog;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using WiangtaiMemberApp.Common;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Web.Commons.Mappers;
using WiangtaiMemberApp.Web.Middleware;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

try
{
    var container = new Container();
    container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

    ConfigureDbConnection();
    ConfigureLogger();
    ConfigureAutoMapper(container);

    services.AddControllersWithViews()
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            options.SerializerSettings.DateParseHandling = DateParseHandling.DateTime;

            options.SerializerSettings.Converters.Add(new StringEnumConverter());
            options.SerializerSettings.ContractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
        });

    services.AddSimpleInjector(container, options =>
    {
        options.AddAspNetCore()
            .AddControllerActivation();
        options.AddLogging();
    });

    services.AddHealthChecks();

    var app = builder.Build();

    app.Services.UseSimpleInjector(container);

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.MapHealthChecks("/health");

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthentication();
    app.UseAuthorization();

    app.UseMiddleware<RequesterLogMiddleware>(container);

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}
catch (Exception ex)
{
    if (ex.GetType().Name.Equals("StopTheHostException", StringComparison.Ordinal))
        throw;

    Log.Fatal(ex, $"Failed to run the application.");
}
finally
{
    Log.CloseAndFlush();
}



void ConfigureDbConnection()
{
    services.AddDbContextPool<WiangtaiMemberAppDbContext>(options =>
    {
        var connectionString = configuration.GetConnectionString(AppConstants.WebMsSqlDbConnectionName);

        options.UseSqlServer(connectionString);
    });
}

void ConfigureLogger()
{
    builder.Host.UseSerilog();

    services.AddW3CLogging(logging =>
    {
        logging.LoggingFields = W3CLoggingFields.All;
    });

    var logger = new LoggerConfiguration();

    Log.Logger = logger
        .ReadFrom.Configuration(configuration)
        .CreateLogger();
}

void ConfigureAutoMapper(Container container)
{
    container.RegisterSingleton<MapperProvider>();
    container.RegisterSingleton(() => container.GetInstance<MapperProvider>().GetMapper());
}
