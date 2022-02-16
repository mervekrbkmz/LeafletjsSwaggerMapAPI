using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace BackendService
{
    static partial class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
  

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));

            // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://127.0.0.1:5500") });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            
            app.UseCors("corsapp");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
            CreateHostBuilder(args).Build().Run();




        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(config =>
                {

                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    // Call additional providers here as needed.
                    // Call AddEnvironmentVariables last if you need to allow
                    // environment variables to override values from other 
                    // providers.
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //string port = Environment.GetEnvironmentVariable("PORT") ?? "8088";
                    string port = Environment.GetEnvironmentVariable("PORT") ?? "80";
                    string url = string.Concat("http://0.0.0.0:", port);

                    //webBuilder.UseStartup<Startup>().UseUrls(url);                 
                    webBuilder.UseIISIntegration();
                    //webBuilder.UseStartup<Startup>();
                    //webBuilder.ConfigureKestrel(serverOptions => { }).UseStartup<Startup>();
                });
    }


}















