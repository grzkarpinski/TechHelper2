using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Infrastructure.Repositories.Interfaces
{
    public interface ICutterHeadRepository : IRepository<CutterHead>
    {
        Task<IEnumerable<CutterHead>> GetByMillingInsertIdAsync(int millingInsertId);
    }
}
