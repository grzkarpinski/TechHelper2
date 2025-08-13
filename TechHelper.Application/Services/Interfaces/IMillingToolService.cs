using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;
using TechHelper.Shared.Enums;

namespace TechHelper.Application.Services.Interfaces
{
    public interface IMillingToolService
    {
        Task<IEnumerable<MillingTool>> GetAllAsync();
        Task<MillingTool?> GetByIdAsync(int id);
        Task AddAsync(MillingTool millingTool);
        Task UpdateAsync(MillingTool millingTool);
        Task DeleteAsync(int id);
        Task<IEnumerable<MillingTool>> GetByProducerAsync(string producer);
        Task<IEnumerable<MillingTool>> GetByTypeAsync(MillingToolType type);
    }
}
