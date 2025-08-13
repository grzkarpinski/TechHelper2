using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Shared.Enums;

namespace TechHelper.Application.Services.Interfaces
{
    public interface IDrillService
    {
        Task<IEnumerable<Drill>> GetAllAsync();
        Task<Drill?> GetByIdAsync(int id);
        Task AddAsync(Drill drill);
        Task UpdateAsync(Drill drill);
        Task DeleteAsync(int id);
        Task<IEnumerable<Drill>> GetByProducerAsync(string producer);
        Task<IEnumerable<Drill>> GetByTypeAsync(DrillType type);
    }
}
