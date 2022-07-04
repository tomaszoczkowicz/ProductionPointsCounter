using Microsoft.EntityFrameworkCore;
using ProductionPointsCounterAPI.Entities;

namespace ProductionPointsCounterAPI
{
    public class Program
    {
        public static void Main()
        {
            var builder = WebApplication.CreateBuilder();

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddDbContext<Sandbox_01Context>(
                option => option
                .UseSqlServer(builder.Configuration.GetConnectionString("ProductionConnectionString")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}