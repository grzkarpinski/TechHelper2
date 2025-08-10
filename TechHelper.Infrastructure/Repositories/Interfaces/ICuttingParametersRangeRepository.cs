using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Infrastructure.Repositories.Interfaces
{
    public interface ICuttingParametersRangeRepository : IRepository<CuttingParametersRange>
    {
        Task<IEnumerable<CuttingParametersRange>> GetByDrillIdAsync(int drillId);
        Task<IEnumerable<CuttingParametersRange>> GetByMillingToolIdAsync(int millingToolId);
        Task<IEnumerable<CuttingParametersRange>> GetByMillingInsertIdAsync(int millingInsertId);
    }
}
