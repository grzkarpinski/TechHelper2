using System.Collections.Generic;
using System.Threading.Tasks;
using TechHelper.Infrastructure.Entities;

namespace TechHelper.Application.Services.Interfaces
{
    public interface ICutterHeadService
    {
        Task<IEnumerable<CutterHead>> GetAllAsync();
        Task<CutterHead?> GetByIdAsync(int id);
        Task AddAsync(CutterHead cutterHead);
        Task UpdateAsync(CutterHead cutterHead);
        Task DeleteAsync(int id);
        Task<IEnumerable<CutterHead>> GetByMillingInsertIdAsync(int millingInsertId);
    }
}
