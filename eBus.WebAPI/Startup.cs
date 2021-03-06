using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eBus.Model.Request;
using eBus.WebAPI.Database;
using eBus.WebAPI.Fillters;
using eBus.WebAPI.Security;
using eBus.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace eBus.WebAPI
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
            //Dodavanje filtera (prikaz gre�ke korisniku)
            services.AddMvc(XmlConfigurationExtensions => XmlConfigurationExtensions.Filters.Add<ErrFilter>());

            services.AddControllers();

            //services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BasicAuth", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });
            });

            var connection = Configuration.GetConnectionString("db");
            services.AddDbContext<eBusContext>(options => options.UseSqlServer(connection));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Authentication
            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            //Methods and services
            services.AddScoped<KorisniciServiceInterface, KorisniciService>();
            services.AddScoped<IPutnikService, PutnikService>();
            services.AddScoped<ICRUDService<Model.Autobus, Model.Autobus, Model.Autobus, Model.Autobus>, AutobusService>();
            services.AddScoped<ICRUDService<Model.Grad, Model.Grad, Model.Grad, Model.Grad>, GradService>();
            services.AddScoped<ICRUDService<Model.Drzava, Model.Drzava, DrzInsRequst, Model.Drzava>, DrzavaService>();
   
            services.AddScoped<ICRUDService<Model.Putnici, PutnikSearchRequest, PutnikUpsertRequest, PutnikUpsertRequest>, PutnikService>();
            services.AddScoped<ICRUDService<Model.Vozaci, Model.Vozaci, Model.Vozaci, Model.Vozaci>, VozaciServis>();
            services.AddScoped<ICRUDService<Model.Karta, Model.Request.KartaSearchRequest, Model.Request.KartaInsertRequest, Model.Karta>, IKartaService>();
            services.AddScoped<ICRUDService<Model.VrstaKarte, Model.VrstaKarte, Model.VrstaKarte, Model.VrstaKarte>, VrstaKarteService>();
            services.AddScoped<ICRUDService<Model.Uloge, Model.Uloge, Model.Uloge, Model.Uloge>, UlogeService>();
            services.AddScoped<ICRUDService<Model.KorisniciUloge, Model.KorisniciUloge, Model.KorisniciUloge, Model.KorisniciUloge>, KorisniciUlogeService>();
            services.AddScoped<ICRUDService<Model.Ocjena, Model.Request.OcjenaSearchRequest, Model.Request.OcjenaInsertRequest, Model.Ocjena>, OcjenaService>();
            services.AddScoped<ICRUDService<Model.Novosti, Model.Request.NovostiSearchRequest, Model.Request.NovostiUpsertRequset, Model.Request.NovostiUpsertRequset>, NovostiService>();
            services.AddScoped<ICRUDService<Model.Notifikacije, Model.Request.NotifikacijeSearchRequest, Model.Request.NotifikacijeUpsertRequest, Model.Request.NotifikacijeUpsertRequest>, NotifikacijaService>();
            services.AddScoped<ICRUDService<Model.PutnikNotifikacije, Model.Request.PutnikNotifikacijeSearchRequest, Model.Request.PutnikNotifikacijeUpsertRequest, Model.Request.PutnikNotifikacijeUpsertRequest>, PutnikNotifikacijeService>();
            services.AddScoped<ICRUDService<Model.RezervacijaSjedista, Model.RezervacijaSjedista, Model.Request.SjedisteInsertRequest, Model.RezervacijaSjedista>, RezervacijaSjedistaService>();
            services.AddScoped<ICRUDService<Model.RezervacijaKarte, Model.Request.RezervacijaSearchRequest, Model.Request.RezervacijaInsertRequest, Model.Request.RezervacijaKarteUpdateRequest>, RezervacijaKarteService>();
            services.AddScoped<ICRUDService<Model.RedVoznje, RedVoznjeSearchRequest, RedVoznjeUpsertRequest, RedVoznjeUpsertRequest>, RedVoznjeService>();
            services.AddScoped<ISistemPreporuke, SistemPreporukeService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });


            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
