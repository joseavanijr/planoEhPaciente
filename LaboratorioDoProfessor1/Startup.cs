using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioDoProfessor1.Contexts;
using LaboratorioDoProfessor1.Repositories;
using LaboratorioDoProfessor1.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LaboratorioDoProfessor1
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

            var stringConexao = @"Server=(local); Integrated Security = true; Initial Catalog=bd_laboratorio";

            services.AddDbContext<LabContext>(options => options.UseSqlServer(stringConexao));

            //Injeção de Dependência
            services.AddTransient<PlanoDeSaudeRepository, PlanoDeSaudeRepository>();
            services.AddTransient<PacienteRepository, PacienteRepository>();

            services.AddTransient<PlanoDeSaudeService, PlanoDeSaudeService>();
            services.AddTransient<PacienteService, PacienteService>();
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
