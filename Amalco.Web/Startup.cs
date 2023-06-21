using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amalco.Data;
using Amalco.Data.Repositories;
using Amalco.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Amalco.Web.Service;
using Microsoft.AspNetCore.Rewrite;
using Amalco.Web.Middleware;

namespace Amalco.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<Context>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddDbContext<ProfileContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DBConnectionDB")));
            services.AddScoped<IUnitofWork, UnitofWork>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddIdentity<IdentityUser,IdentityRole>()
                .AddEntityFrameworkStores<Context>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt => 
                { opt.LoginPath = new PathString("/admin/login");
                    opt.CookieHttpOnly = true;
                    opt.CookieName = "SessionId";
                });
            services.Configure<CookieTempDataProviderOptions>(options => {
                options.Cookie.IsEssential = true;
            });
            services.ConfigureApplicationCookie(opt => opt.LoginPath = "/admin/login");
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //RewriteOptions options = new RewriteOptions();
            //options.AddRedirectToWwwPermanent();
            app.UseMiddleware<RederictToNonewww>();
            //app.UseMiddleware<Test>();
            //app.UseRewriter(options);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
               
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
               
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
           name: "areas",
           template: "{area:exists}/{controller=Index}/{action=Index}/{id?}"
         );
                routes.MapRoute("Home", "",
             defaults: new { controller = "Home", action = "Index" });
                routes.MapRoute("AddOrder", "addorder",
            defaults: new { controller = "Order", action = "Add" });
                routes.MapRoute("ServiceIndex", "uslugi",
          defaults: new { controller = "Service", action = "Index" });
                routes.MapRoute("Call", "zvonok",
                         defaults: new { controller = "Order", action = "Call" });
                routes.MapRoute("Contacts", "kontakty",
           defaults: new { controller = "StaticPage", action = "Contacts" });
                routes.MapRoute("Order", "zakazat-domashniy-personal",
        defaults: new { controller = "Order", action = "Index" });
                routes.MapRoute("About", "ob-agentstve",
          defaults: new { controller = "StaticPage", action = "About" });
                routes.MapRoute("VacancyResponse", "vacancyresponse",
          defaults: new { controller = "StaticPage", action = "VacancyResponse" });
                routes.MapRoute("Applicants", "soiskatelyam",
         defaults: new { controller = "StaticPage", action = "Applicants" });
                routes.MapRoute("Service", "{url}/{subUrl?}",
              defaults: new { controller = "Service", action = "Page" });

                
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
