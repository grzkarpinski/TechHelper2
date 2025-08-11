using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Infrastructure.Persistence;
using TechHelper.Infrastructure.Repositories.Interfaces;

namespace TechHelper.Infrastructure.Repositories.Implementations
{
    public class MillingInsertRepository : IMillingInsertRepository
    {
        private readonly AppDbContext _context;
        public MillingInsertRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MillingInsert>> GetAllAsync() => await _context.MillingInserts.ToListAsync();
        public async Task<MillingInsert?> GetByIdAsync(int id) => await _context.MillingInserts.FindAsync(id);
        public async Task AddAsync(MillingInsert entity)
        {
            await _context.MillingInserts.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(MillingInsert entity)
        {
            _context.MillingInserts.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.MillingInserts.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<MillingInsert>> GetByCutterHeadIdAsync(int cutterHeadId) =>
            await _context.MillingInserts
                .Where(mi => mi.CutterHeads.Any(ch => ch.Id == cutterHeadId))
                .ToListAsync();
    }
}
