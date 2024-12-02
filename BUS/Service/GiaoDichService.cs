using AutoMapper;
using DAL.Entities;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class GiaoDichService : IGiaoDichService
    {
        private readonly IGiaoDichRepo _repo;

        public GiaoDichService(IGiaoDichRepo repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(GiaoDichTaiChinh vm)
        {
            await _repo.AddAsync(vm);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repo.DeleteAsync(id);    
        }

        public async Task<IEnumerable<GiaoDichTaiChinh>> GetAllAsync()
        {
            var respone = await _repo.GetAllAsync();
            return respone;
        }

        public async Task<GiaoDichTaiChinh> GetByIdAsync(Guid id)
        {
            var giaoDich = await _repo.GetByIdAsync(id);    
            return giaoDich;
        }

        public async Task UpdateAsync(GiaoDichTaiChinh vm)
        {
            var existing = await _repo.GetByIdAsync(vm.Id);
            if (existing != null)
            {
                await _repo.UpdateAsync(existing);
            }
        }
    }
}
