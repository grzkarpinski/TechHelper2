using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Infrastructure.Persistence;
using TechHelper.Infrastructure.Repositories.Interfaces;

namespace TechHelper.Infrastructure.Repositories.Implementations
{
    public class CutterHeadRepository : ICutterHeadRepository
    {
        private readonly AppDbContext _context;
        public CutterHeadRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CutterHead>> GetAllAsync() => await _context.CutterHeads.ToListAsync();
        public async Task<CutterHead?> GetByIdAsync(int id) => await _context.CutterHeads.FindAsync(id);
        public async Task AddAsync(CutterHead entity)
        {
            await _context.CutterHeads.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CutterHead entity)
        {
            _context.CutterHeads.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.CutterHeads.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<CutterHead>> GetByMillingInsertIdAsync(int millingInsertId) =>
            await _context.CutterHeads
                .Where(ch => ch.MillingInserts.Any(mi => mi.Id == millingInsertId))
                .ToListAsync();
    }
}
