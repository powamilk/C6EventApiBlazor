
using DAL.Entities;

namespace PL.Guides.Service
{
    public interface IGiaoDichService
    {
        Task<IEnumerable<GiaoDichTaiChinh>> GetAllAsync();
        Task<GiaoDichTaiChinh> GetByIdAsync(Guid id);
        Task AddAsync(GiaoDichTaiChinh vm);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Guid id, GiaoDichTaiChinh vm);
    }
}
