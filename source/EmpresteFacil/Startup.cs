using EmpresteFacil.Context;
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
            options.AccessDeniedPath = "/Usuarios/AccessDenied";
            options.LoginPath = "/Usuarios/Login";
        });



        services.AddIdentity<IdentityUser, IdentityRole>(config =>
        {
            config.SignIn.RequireConfirmedAccount = false;
            config.SignIn.RequireConfirmedEmail = false;
            config.SignIn.RequireConfirmedPhoneNumber = false;
        })
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();


        services.AddControllersWithViews();

        services.AddDatabaseDeveloperPageExceptionFilter();

        //Serviço para acessar a session
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        //Configurando a session
        services.AddMemoryCache();
        services.AddSession();
    }



    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

        //Ativando a Session //
        app.UseSession();

        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseCookiePolicy();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
