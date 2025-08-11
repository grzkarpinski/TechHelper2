using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Infrastructure.Persistence;
using TechHelper.Infrastructure.Repositories.Interfaces;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Repositories.Implementations
{
    public class DrillRepository : IDrillRepository
    {
        private readonly AppDbContext _context;
        public DrillRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Drill>> GetAllAsync() => await _context.Drills.ToListAsync();
        public async Task<Drill?> GetByIdAsync(int id) => await _context.Drills.FindAsync(id);
        public async Task AddAsync(Drill entity)
        {
            await _context.Drills.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Drill entity)
        {
            _context.Drills.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Drills.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<Drill>> GetByProducerAsync(string producer) =>
            await _context.Drills.Where(x => x.Producer == producer).ToListAsync();
        public async Task<IEnumerable<Drill>> GetByTypeAsync(DrillType type) =>
            await _context.Drills.Where(x => x.DrillType == type).ToListAsync();
    }
}
