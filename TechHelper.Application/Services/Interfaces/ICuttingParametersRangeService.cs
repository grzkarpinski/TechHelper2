using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Application.Services.Interfaces
{
    public interface ICuttingParametersRangeService
    {
        Task<IEnumerable<CuttingParametersRange>> GetAllAsync();
        Task<CuttingParametersRange?> GetByIdAsync(int id);
        Task AddAsync(CuttingParametersRange entity);
        Task UpdateAsync(CuttingParametersRange entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<CuttingParametersRange>> GetByDrillIdAsync(int drillId);
        Task<IEnumerable<CuttingParametersRange>> GetByMillingToolIdAsync(int millingToolId);
        Task<IEnumerable<CuttingParametersRange>> GetByMillingInsertIdAsync(int millingInsertId);
    }
}
