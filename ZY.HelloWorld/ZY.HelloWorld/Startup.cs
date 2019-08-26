using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ZY.EFCore.Entities;
using WS.Sqlsugar;

namespace ZY.HelloWorld
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

            //注入EF上下文对象
            services.AddDbContext<LMSData_1226Context>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("LMSData_1226Connection"))
            );

            //注入Sqlsugar
            services.AddSqlSugarClient<DbFactory>((sp,op)=> 
            {
                //数据库链接字符串
                op.ConnectionString = sp.GetService<IConfiguration>().GetConnectionString("mysqlConn");
                //数据库类型
                op.DbType = SqlSugar.DbType.MySql;
                //是否自动释放链接
                op.IsAutoCloseConnection = true;
                //Attribute是DbFirst，SystemTable是CodeFirst
                op.InitKeyType = SqlSugar.InitKeyType.Attribute;
                //设为true相同线程是同一个SqlConnection
                op.IsShardSameThread = false;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
