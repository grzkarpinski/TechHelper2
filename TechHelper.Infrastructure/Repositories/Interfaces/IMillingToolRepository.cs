using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Repositories.Interfaces
{
    public interface IMillingToolRepository : IRepository<MillingTool>
    {
        Task<IEnumerable<MillingTool>> GetByProducerAsync(string producer);
        Task<IEnumerable<MillingTool>> GetByTypeAsync(MillingToolType type);
    }
}
