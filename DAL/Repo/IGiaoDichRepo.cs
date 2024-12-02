using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public interface IGiaoDichRepo
    {
        Task<IEnumerable<GiaoDichTaiChinh>> GetAllAsync();
        Task<GiaoDichTaiChinh> GetByIdAsync(Guid id);
        Task AddAsync(GiaoDichTaiChinh giaoDichTaiChinh);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(GiaoDichTaiChinh giaoDichTaiChinh);
    }
}
