using Microsoft.EntityFrameworkCore;

namespace TechHelper.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        // Add other DbSet<TEntity> properties here as needed
    }
}
