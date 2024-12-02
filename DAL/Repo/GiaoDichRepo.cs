using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class GiaoDichRepo : IGiaoDichRepo
    {
        private readonly AppDbContext _context;
        public GiaoDichRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(GiaoDichTaiChinh giaoDichTaiChinh)
        {
            giaoDichTaiChinh.Id = Guid.NewGuid();   
            await _context.GiaoDichTaiChinhs.AddAsync(giaoDichTaiChinh);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var giaoDich = await _context.GiaoDichTaiChinhs.FindAsync(id);
            if(giaoDich != null)
            {
                _context.GiaoDichTaiChinhs.Remove(giaoDich);
                await _context.SaveChangesAsync();  
            }
        }

        public async Task<IEnumerable<GiaoDichTaiChinh>> GetAllAsync()
        {
            return await _context.GiaoDichTaiChinhs.ToListAsync();
        }

        public async Task<GiaoDichTaiChinh> GetByIdAsync(Guid id)
        {
            return await _context.GiaoDichTaiChinhs.FindAsync(id);
        }

        public async Task UpdateAsync(GiaoDichTaiChinh giaoDichTaiChinh)
        {
            _context.GiaoDichTaiChinhs.Update(giaoDichTaiChinh);
            await _context.SaveChangesAsync();

        }
    }
}
