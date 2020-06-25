using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AdminLTEASPNETEmployees.CustomHandler;
using AdminLTEASPNETEmployees.Data;
using AdminLTEASPNETEmployees.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AdminLTEASPNETEmployees
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
            services.AddDbContext<EmployeesDBContext>(opt => opt.UseSqlServer
            (Configuration.GetConnectionString("EmployeesConnection")));
            services.AddControllersWithViews();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IEmployeesRepo, SqlEmployeesRepo>();

            services.AddAuthentication("CookieAuthentication")  
                 .AddCookie("CookieAuthentication", config =>  
                 {  
                     config.Cookie.Name = "AdminUserCookie"; // Name of cookie     
                     config.LoginPath = "/Home/Index"; // Path for the redirect to user login page    
                     config.AccessDeniedPath = "/Login/UserAccessDenied";  
                 });  
  
            services.AddScoped<IAuthorizationHandler, PoliciesAuthorizationHandler>();  
            services.AddScoped<IAuthorizationHandler, RolesAuthorizationHandler>();  
  
            services.AddControllersWithViews();  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();  
            app.UseStaticFiles();

            app.UseRouting();

            // who are you?  
            app.UseAuthentication();

            // are you allowed?  
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
