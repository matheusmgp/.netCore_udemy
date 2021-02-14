
using AutoMapper;
using MgpTechTickets.Application.service;
using MgpTechTickets.Data;
using MgpTechTickets.Domain.interfaces.repositories;
using MgpTechTickets.Domain.repositories;
using MgpTechTickets.Domain.Repositories;
using MgpTechTickets.Models;
using MgpTechTickets.Services.interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace MgpTechTickets
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
            services.AddDbContext<DataContext>(
                    context => context.UseSqlite(Configuration.GetConnectionString("Default")));

            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IAgendaRepository, AgendasRepository>();                 
            services.AddScoped<IAmbienteRepository, AmbienteRepository>();
            services.AddScoped<ICanaisRepository, CanaisRepository>();
            services.AddScoped<ICategoriaRepository, CategoriasRepository>();

          //  services.AddScoped<IBaseRepository<Agenda>, AgendasRepository>();
          //  services.AddScoped<IBaseRepository<Ambiente>, AmbienteRepository>();
          //  services.AddScoped<IBaseRepository<CanaisComunicacao>, CanaisRepository>();
          //  services.AddScoped<IBaseRepository<Categoria>, CategoriasRepository>();

            //services.AddScoped<IServiceBase<Agenda>, AgendaService>();
           // services.AddScoped<IServiceBase<Ambiente>, AmbienteService>();
           // services.AddScoped<IServiceBase<CanaisComunicacao>, CanaisService>();

            services.AddScoped<IAmbienteService, AmbienteService>();
            services.AddScoped<IAgendaService, AgendaService>();
            services.AddScoped<ICanaisService, CanaisService>();
            services.AddScoped<ICategoriaService, CategoriaService>();


            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    "mgptechapi",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Version = "v1",
                        Title = "MgpTech API",
                        Description = "API criada para o sistema de chamados da MgpTech",
                        //TermsOfService = new Uri("https://example.com/terms"),
                        Contact = new OpenApiContact
                        {
                            Name = "Matheus Gustavo",
                            Email = "matheus_mgp@hotmail.com",
                            Url = new Uri("https://github.com/matheusmgp"),
                        },
                        License = new OpenApiLicense
                        {
                            Name = "Use under LICX",
                            Url = new Uri("https://github.com/matheusmgp"),
                        }
                    }
                );

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                options.IncludeXmlComments(xmlCommentsFullPath);
            });

            services.AddCors(options => options.AddDefaultPolicy(
                    builder => builder.AllowAnyOrigin()
                ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/mgptechapi/swagger.json", "mgptechapi");
                    options.RoutePrefix = "";
                });
            app.UseAuthorization();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors();
        }
    }
}
