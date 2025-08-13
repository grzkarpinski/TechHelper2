using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Application.Services.Interfaces
{
    public interface IMillingInsertService
    {
        Task<IEnumerable<MillingInsert>> GetAllAsync();
        Task<MillingInsert?> GetByIdAsync(int id);
        Task AddAsync(MillingInsert millingInsert);
        Task UpdateAsync(MillingInsert millingInsert);
        Task DeleteAsync(int id);
        Task<IEnumerable<MillingInsert>> GetByCutterHeadIdAsync(int cutterHeadId);
    }
}
