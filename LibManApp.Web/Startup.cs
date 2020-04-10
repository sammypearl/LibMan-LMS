using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using LibManApp.Web.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LibManApp.Data;
using LibManApp.Data.Models;
using LibManApp.Service;
using Microsoft.Extensions.Logging;
using LibManApp.Web.Data.IdentityModels;

namespace LibManApp.Web
{
    public class Startup
    {

       // private readonly ILogger _logger;

        public Startup(IConfiguration configuration)// ILogger<Startup> logger)
        {
            Configuration = configuration;
           // _logger = logger;
        }
       
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddApplicationInsightsTelemetry();
           
            // The following will be picked up by Application Insights.
           // _logger.LogInformation("Logging from ConfigureServices.");

            services.AddDbContext<LibraryDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("LibManConnection")));

            services.AddDbContext<IdentityContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("IdentityConnection")));
           
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>()
                .AddDefaultTokenProviders();


            //services.AddAuthentication()
            //    .AddGoogle(option => {
            //        option.ClientId = "879714282546-tuprf6tueni7oltn9gjdu3q8t7t3es2r.apps.googleusercontent.com";
            //        option.ClientSecret = "RmCqZPZNCjsKfPk9R96cTwPs";

            //    });

            //services.AddAuthentication().AddMicrosoftAccount(options =>
            //{
            //    options.ClientId = Configuration["Authentication:Microsoft:ClientId"];
            //    options.ClientSecret = Configuration["Authentication:Microsoft:ClientSecret"];
            //});

            //services.AddAuthentication().AddFacebook(facebookOptions =>
            //{
            //    facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
            //    facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            //});

            

            services.AddSingleton(Configuration);
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped<ILibraryCardService, LibraryCardService>();
            services.AddScoped<ILibraryBranchService, LibraryBranchService>();
            services.AddScoped<IPatronService, PatronService>();
            services.AddScoped<ICheckoutService, CheckoutService>();
            services.AddScoped<ILibraryAssetService, LibraryAssetService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IVideoService, VideoService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddMvc();
           // services.AddControllersWithViews();
           // services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
           // loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
              //  _logger.LogInformation("Configuring for Development environment");
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
               // _logger.LogInformation("Configuring for Production environment");
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
                endpoints.MapRazorPages();
            });
        }
    }
}
