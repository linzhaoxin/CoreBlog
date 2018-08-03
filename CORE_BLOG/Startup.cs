using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE_BLOG.BLL;
using CORE_BLOG.DAL;
using CORE_BLOG.IBLL;
using CORE_BLOG.IDAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CORE_BLOG.Entity;


namespace CORE_BLOG
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
        
            //配置获取 ConnectionStrings
            services.Configure<CONNECTION_STRINGS>(Configuration.GetSection("ConnectionStrings"));
            services.AddScoped<USER_IDAL, USER_DAL>();
            services.AddScoped<USER_LOGIN_IBLL, USER_LOGIN_BLL>();
            services.AddScoped<BLOG_COLUMN_IDAL, BLOG_COLUMN_DAL>();
            services.AddScoped<BLOG_COLUMN_IBLL, BLOG_COLUMN_BLL>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //处理静态文件
            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
