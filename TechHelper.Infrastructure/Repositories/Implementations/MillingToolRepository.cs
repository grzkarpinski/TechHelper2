using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Infrastructure.Persistence;
using TechHelper.Infrastructure.Repositories.Interfaces;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Repositories.Implementations
{
    public class MillingToolRepository : IMillingToolRepository
    {
        private readonly AppDbContext _context;
        public MillingToolRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MillingTool>> GetAllAsync() => await _context.MillingTools.ToListAsync();
        public async Task<MillingTool?> GetByIdAsync(int id) => await _context.MillingTools.FindAsync(id);
        public async Task AddAsync(MillingTool entity)
        {
            await _context.MillingTools.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(MillingTool entity)
        {
            _context.MillingTools.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.MillingTools.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<MillingTool>> GetByProducerAsync(string producer) =>
            await _context.MillingTools.Where(x => x.Producer == producer).ToListAsync();
        public async Task<IEnumerable<MillingTool>> GetByTypeAsync(MillingToolType type) =>
            await _context.MillingTools.Where(x => x.MillingToolType == type).ToListAsync();
    }
}
