using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBarDG.Bussines.Comanda;
using APIBarDG.Data;
using APIBarDG.Data.Comanda;
using APIBarDG.Data.Service;
using APIBarDG.Service.ComandaService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace APIBarDG
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "API Bar do DG",
                        Version = "v1",
                        Description = "Exemplo de API REST criada com o ASP.NET Core para controle de comanda do bar do DG",
                        Contact = new OpenApiContact
                        {
                            Name = "Lucas Hiroaki",
                            Url = new Uri("https://github.com/hiroakilucas")
                        }
                    });
            });

            services.AddTransient<IComandaDAO, ComandaDAO>();
            services.AddTransient<IControlaComanda, ComandaBussines>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connection = Configuration["ConexaoSqlite:SqliteConnectionString"];
            services.AddDbContext<ComandaContext>(options =>
                options.UseSqlite(connection)
            );
            // Add framework services.

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Bar do DG");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}