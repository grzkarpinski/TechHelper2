using Microsoft.EntityFrameworkCore;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Drill> Drills { get; set; }
        public DbSet<MillingTool> MillingTools { get; set; }
        public DbSet<MillingInsert> MillingInserts { get; set; }
        public DbSet<CutterHead> CutterHeads { get; set; }
        public DbSet<CuttingParametersRange> CuttingParametersRanges { get; set; }
        public DbSet<CuttingParametersFinal> CuttingParametersFinals { get; set; }
    }
}
