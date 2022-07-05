using Microsoft.EntityFrameworkCore;
using ProductionPointsCounterAPI.Entities;
using ProductionPointsCounterAPI.Services;

namespace ProductionPointsCounterAPI
{
    public class Program
    {
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddDbContext<DataBaseContext>(
                option => option
                .UseSqlServer(builder.Configuration.GetConnectionString("ProductionConnectionString")));
            builder.Services.AddScoped<IProductionAnalysisService, ProductionAnalysisService>();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("FrontEndClient", builder => 
                builder.AllowAnyMethod()
                       .AllowAnyHeader()
                       .AllowAnyOrigin());
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseCors("FrontEndClient");
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}