using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using core_bili.ef;
using core_bili.Myserver;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace core_bili
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
            
            services.AddScoped<IMyserver<student>, Mydata>();

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<IdentityDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<biliDbContext>(d => d.UseSqlServer(Configuration.GetConnectionString("default")));

            services.AddDbContext<IdentityDbContext>(d => d.UseSqlServer(Configuration.GetConnectionString("default"), b => b.MigrationsAssembly("core_bili")));

            services.Configure<IdentityOptions>(option =>
            {
                //必须包含数字
                option.Password.RequireDigit = false;

                //必须不包含数值(ascll码也算数值)
                option.Password.RequireNonAlphanumeric = false;

                //必须包含大写
                option.Password.RequireUppercase = false;

                //必须包含小写
                option.Password.RequireLowercase = false;

                //所需数量(可能是MinLength)
                option.Password.RequiredUniqueChars = 0;

                //要求长度(可能是MaxLength)
                option.Password.RequiredLength = 0;               

            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/node_modules",
                FileProvider=new PhysicalFileProvider(Path.Combine(env.ContentRootPath,"node_modules"))
            });

            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "ss",
                    template: "{controller=first}/{action=Index}/{number?}"
                    );
            });
        }
    }
}
