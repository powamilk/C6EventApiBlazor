using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public interface IGiaoDichService
    {
        Task<IEnumerable<GiaoDichTaiChinh>> GetAllAsync();
        Task<GiaoDichTaiChinh> GetByIdAsync(Guid id);
        Task AddAsync(GiaoDichTaiChinh vm);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(GiaoDichTaiChinh vm);
    }
}
