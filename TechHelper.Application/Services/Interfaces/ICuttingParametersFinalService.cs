using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Application.Services.Interfaces
{
    public interface ICuttingParametersFinalService
    {
        Task<IEnumerable<CuttingParametersFinal>> GetAllAsync();
        Task<CuttingParametersFinal?> GetByIdAsync(int id);
        Task AddAsync(CuttingParametersFinal entity);
        Task UpdateAsync(CuttingParametersFinal entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<CuttingParametersFinal>> GetByDrillIdAsync(int drillId);
        Task<IEnumerable<CuttingParametersFinal>> GetByMillingToolIdAsync(int millingToolId);
        Task<IEnumerable<CuttingParametersFinal>> GetByCutterHeadIdAsync(int cutterHeadId);
    }
}
