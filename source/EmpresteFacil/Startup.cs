using EmpresteFacil.Context;
using EmpresteFacil.Models;
using EmpresteFacil.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EmpresteFacil;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {


        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

        services.Configure<CookiePolicyOptions>(options =>
        {
            //this lambda determines whether user consent for non-essential cookies is needed for a given request.

            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.None;
        });

        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
        {
            options.AccessDeniedPath = "/Account/AccessDenied";
            options.LoginPath = "/Account/Login";
        });



        services.AddIdentity<Usuario, IdentityRole>(config =>
        {
            config.SignIn.RequireConfirmedAccount = false;
            config.SignIn.RequireConfirmedEmail = false;
            config.SignIn.RequireConfirmedPhoneNumber = false;
        })
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();


        services.AddControllersWithViews();

        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

        services.AddMemoryCache();
        services.AddSession();
    }



    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ISeedUserRoleInitial seedUserRoleInitial)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();


        seedUserRoleInitial.SeedRoles();
        seedUserRoleInitial.SeedUsers();

        app.UseSession();

        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseCookiePolicy();

        app.UseEndpoints(endpoints =>
        {

            endpoints.MapControllerRoute(
             name: "areas",
             pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
