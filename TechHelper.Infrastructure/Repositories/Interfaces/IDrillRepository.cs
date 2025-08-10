using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Repositories.Interfaces
{
    public interface IDrillRepository : IRepository<Drill>
    {
        Task<IEnumerable<Drill>> GetByProducerAsync(string producer);
        Task<IEnumerable<Drill>> GetByTypeAsync(DrillType type);
    }
}
