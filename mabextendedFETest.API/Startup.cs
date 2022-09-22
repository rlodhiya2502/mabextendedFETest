using mabextendedFETest.Manager.Interfaces;
using mabextendedFETest.Manager.Implementation;
using mabextendedFETest.Utility;
using mabextenedFETest.DataAccess.Implementation;
using mabextenedFETest.DataAccess.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mabextendedFETest.API
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
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                   builder =>
                   {
                       builder.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
                   });
            });
            services.AddSingleton<IConfiguration>(Configuration);
            string connectionString = Configuration.GetConnectionString("MySQLDatabase");
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddTransient(_ => new MySqlDatabase(connectionString));

            services.AddSwaggerDocument(c => c.Title = "MabExpandedFrontEndTechnicalTest");

            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region Dependency
            services.AddTransient<IPlayersDataAccess, PlayersDataAccess>();
            services.AddTransient<IPlayersManager, PlayersManager>();
            services.AddTransient<IGamesDataAccess, GamesDataAccess>();
            services.AddTransient<IGamesManager, GamesManager>();
            services.AddTransient<IScoreCardsDataAccess, ScoreCardsDataAccess>();
            services.AddTransient<IScoreCardsManager, ScoreCardsManager>();
            #endregion
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("AllowAllHeaders");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.UseOpenApi();
            app.UseSwaggerUi3(c => c.DocumentTitle = "MabExpandedTechTest");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
