using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
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
using WiangtaiMemberApp.Web.Commons.Mappers.ValueResolver;
using WiangtaiMemberApp.Web.Middleware;
using WiangtaiMemberApp.Web.Repository;
using WiangtaiMemberApp.Web.Repository.Contracts;
using WiangtaiMemberApp.Web.Services;
using WiangtaiMemberApp.Web.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

try
{
    var container = new Container();
    container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

    ConfigureServiceContainer(container);
    ConfigureDbConnection();
    ConfigureLogger();
    ConfigureAuthentication();
    ConfigureAutoMapper(container);

    services.AddRazorPages();
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
            .AddControllerActivation()
            .AddViewComponentActivation()
            .AddPageModelActivation()
            .AddTagHelperActivation(); ;
        options.AddLogging();
    });

    services.AddHealthChecks();

    var app = builder.Build();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.Services.UseSimpleInjector(container);

    app.MapHealthChecks("/health");

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthentication();
    app.UseAuthorization();

    app.UseMiddleware<RequesterLogMiddleware>(container);

    app.MapRazorPages();
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Dashboard}/{action=Index}/{id?}");

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

void ConfigureAuthentication()
{
    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.SlidingExpiration = true;
        options.AccessDeniedPath = "/Forbidden/";
    });
}

void ConfigureServiceContainer(Container container)
{
    container.Register<TotalPointsBalanceResolver>();
    container.Register<TotalCashbackBalanceResolver>();

    //container.Register(typeof(IBaseRepository<>), new[] { typeof(BaseRepository<>).Assembly });
    container.Register<ISecurityUserRepository, SecurityUserRepository>(Lifestyle.Scoped);
    container.Register<IMemberRepository, MemberRepository>(Lifestyle.Scoped);
    container.Register<IMemberTypeRepository, MemberTypeRepository>(Lifestyle.Scoped);
    container.Register<IMemberRewardRepository, MemberRewardRepository>(Lifestyle.Scoped);
    container.Register<ISettingRepository, SettingRepository>(Lifestyle.Scoped);
    container.Register<IReferenceTypeRepository, ReferenceTypeRepository>(Lifestyle.Scoped);
    container.Register<IRaceTypeRepository, RaceTypeRepository>(Lifestyle.Scoped);
    container.Register<IServiceAgentConfigRepository, ServiceAgentConfigRepository>(Lifestyle.Scoped); 

    container.Register<IAuthService, AuthService>(Lifestyle.Scoped);
    container.Register<IMemberService, MemberService>(Lifestyle.Scoped);
    container.Register<ISettingService, SettingService>(Lifestyle.Scoped);
    container.Register<IConfigurationService, ConfigurationService>(Lifestyle.Scoped);
}

void ConfigureAutoMapper(Container container)
{
    container.RegisterSingleton<MapperProvider>();
    container.RegisterSingleton(() => container.GetInstance<MapperProvider>().GetMapper());
}