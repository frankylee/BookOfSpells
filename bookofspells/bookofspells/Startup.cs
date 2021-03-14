using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using bookofspells.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace bookofspells
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
            services.AddControllersWithViews();
            // Inject repositories into controller
            services.AddTransient<IContactFormRepository, ContactFormRepository>();
            services.AddTransient<INewsletterSignup, NewsletterSignupRepository>();
            services.AddTransient<ISpellRepository, SpellRepository>();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                services.AddDbContext<BookOfSpellsContext>(options => options.UseSqlServer(Configuration["ConnectionString:AzureSQL"]));
            else
                services.AddDbContext<BookOfSpellsContext>(
                    options => options.UseSqlite(Configuration["ConnectionString:SQLite"])
                    //.EnableSensitiveDataLogging()  // development only
                );

            // Add Identity service with default password options
            services.AddIdentity<AppUser, IdentityRole>(options => {
                // Require unique email address for user
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<BookOfSpellsContext>()
                .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, BookOfSpellsContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); // identity
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapAreaControllerRoute(
                //    name: "admin",
                //    areaName: "Admin",
                //    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Use(async (ctx, next) =>
            {
                // Prevent clickjacking by setting X-Frame-Options at the code level;
                // use this header to ensure content cannot be iframed
                // X-Frame-Options Header Not Set 
                ctx.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                // X-Content-Type-Options Header Missing
                ctx.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                await next();
            });

            // Use SeedData if database is empty
            SeedData.Seed(ctx);
        }
    }
}
