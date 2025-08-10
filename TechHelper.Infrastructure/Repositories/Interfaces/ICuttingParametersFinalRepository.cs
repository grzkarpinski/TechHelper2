using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Infrastructure.Repositories.Interfaces
{
    public interface ICuttingParametersFinalRepository : IRepository<CuttingParametersFinal>
    {
        Task<IEnumerable<CuttingParametersFinal>> GetByDrillIdAsync(int drillId);
        Task<IEnumerable<CuttingParametersFinal>> GetByMillingToolIdAsync(int millingToolId);
        Task<IEnumerable<CuttingParametersFinal>> GetByCutterHeadIdAsync(int cutterHeadId);
    }
}
