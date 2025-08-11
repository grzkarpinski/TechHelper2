using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Infrastructure.Persistence;
using TechHelper.Infrastructure.Repositories.Interfaces;

namespace TechHelper.Infrastructure.Repositories.Implementations
{
    public class CuttingParametersRangeRepository : ICuttingParametersRangeRepository
    {
        private readonly AppDbContext _context;
        public CuttingParametersRangeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CuttingParametersRange>> GetAllAsync() => await _context.CuttingParametersRanges.ToListAsync();
        public async Task<CuttingParametersRange?> GetByIdAsync(int id) => await _context.CuttingParametersRanges.FindAsync(id);
        public async Task AddAsync(CuttingParametersRange entity)
        {
            await _context.CuttingParametersRanges.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CuttingParametersRange entity)
        {
            _context.CuttingParametersRanges.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.CuttingParametersRanges.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<CuttingParametersRange>> GetByDrillIdAsync(int drillId) =>
            await _context.CuttingParametersRanges.Where(x => x.DrillId == drillId).ToListAsync();
        public async Task<IEnumerable<CuttingParametersRange>> GetByMillingToolIdAsync(int millingToolId) =>
            await _context.CuttingParametersRanges.Where(x => x.MillingToolId == millingToolId).ToListAsync();
        public async Task<IEnumerable<CuttingParametersRange>> GetByMillingInsertIdAsync(int millingInsertId) =>
            await _context.CuttingParametersRanges.Where(x => x.MillingInsertId == millingInsertId).ToListAsync();
    }
}
