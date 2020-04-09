using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using vnpost.Models.Repository;
using vnpost.Models.Services;

namespace vnpost
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
            services.AddSession(options =>
            {                                               // Đăng ký dịch vụ Session
                options.IdleTimeout = new TimeSpan(3600);   // Thời gian tồn tại của Session
            });
            services.AddMvc(MvcOptions =>
            {
                MvcOptions.EnableEndpointRouting = false;
            });
            services.AddTransient<IInfomation, RInfomation>();
            services.AddTransient<IIsAdmin, RIsAdmin>();
            services.AddTransient<IIsLogin, RIsLogin>();
            services.AddTransient<IIsMenuSinger1, RIsMenuSinger1>();
            services.AddTransient<IIsNavbar, RIsNavbar>();
            services.AddTransient<IIsNavSinger, RIsNavSinger>();
            services.AddTransient<IIsPost, RIsPost>();
            services.AddTransient<IIsSpecies, RIsSpecies>();
            services.AddTransient<IIsTheme, RIsTheme>();
            services.AddTransient<IIsVideo, RIsVideo>();
            services.AddTransient<IThanTrang, RThanTrang>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseMvc(routes =>
            {

                routes.MapRoute(
                        name: "default",
                        template: "{controller=Home}/{action=TrangChu}/{id?}");
                routes.MapRoute(//khai bao ereas admin
                         name: "Admin",
                         template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
