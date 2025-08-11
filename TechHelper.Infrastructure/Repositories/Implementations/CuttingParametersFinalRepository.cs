using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Infrastructure.Persistence;
using TechHelper.Infrastructure.Repositories.Interfaces;

namespace TechHelper.Infrastructure.Repositories.Implementations
{
    public class CuttingParametersFinalRepository : ICuttingParametersFinalRepository
    {
        private readonly AppDbContext _context;
        public CuttingParametersFinalRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CuttingParametersFinal>> GetAllAsync() => await _context.CuttingParametersFinals.ToListAsync();
        public async Task<CuttingParametersFinal?> GetByIdAsync(int id) => await _context.CuttingParametersFinals.FindAsync(id);
        public async Task AddAsync(CuttingParametersFinal entity)
        {
            await _context.CuttingParametersFinals.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CuttingParametersFinal entity)
        {
            _context.CuttingParametersFinals.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.CuttingParametersFinals.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<CuttingParametersFinal>> GetByDrillIdAsync(int drillId) =>
            await _context.CuttingParametersFinals.Where(x => x.DrillId == drillId).ToListAsync();
        public async Task<IEnumerable<CuttingParametersFinal>> GetByMillingToolIdAsync(int millingToolId) =>
            await _context.CuttingParametersFinals.Where(x => x.MillingToolId == millingToolId).ToListAsync();
        public async Task<IEnumerable<CuttingParametersFinal>> GetByCutterHeadIdAsync(int cutterHeadId) =>
            await _context.CuttingParametersFinals.Where(x => x.CutterHeadId == cutterHeadId).ToListAsync();
    }
}
