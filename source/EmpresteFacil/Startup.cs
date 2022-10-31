using EmpresteFacil.Context;
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
        services.AddControllersWithViews();
        services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        services.AddIdentity<IdentityUser, IdentityRole>(config =>
        {
            config.SignIn.RequireConfirmedAccount = false;
            config.SignIn.RequireConfirmedEmail = false;
            config.SignIn.RequireConfirmedPhoneNumber = false;
        })
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();

        services.AddDatabaseDeveloperPageExceptionFilter();
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

        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
