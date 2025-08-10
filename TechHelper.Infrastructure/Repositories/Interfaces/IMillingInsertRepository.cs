using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Infrastructure.Repositories.Interfaces
{
    public interface IMillingInsertRepository : IRepository<MillingInsert>
    {
        Task<IEnumerable<MillingInsert>> GetByCutterHeadIdAsync(int cutterHeadId);
    }
}
