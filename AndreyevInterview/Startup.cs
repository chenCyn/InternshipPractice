using System;
using AndreyevInterview.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AndreyevInterview
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
            services.AddCors(options => options.AddPolicy(
                "CorsPolicy",
                builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin())
            );

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("CorsPolicy",
            //                          builder =>
            //                          {
            //                              builder.WithOrigins("*");
            //                          });
            //});

            services.AddControllers();

            // Register DbContext
            var dbPath = Environment.CurrentDirectory + "andreyev_interview.db";
            services.AddMvc();
            services.AddDbContext<AIDbContext>(options =>
                options.UseSqlite(@"Data Source=" + dbPath)
            );

            //swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddTransient<IInvoiceServices, InvoiceServices>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors("CorsPolicy");

                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}