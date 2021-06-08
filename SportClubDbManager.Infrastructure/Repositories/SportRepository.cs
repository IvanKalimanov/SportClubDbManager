using Microsoft.EntityFrameworkCore;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Infrastructure.Repositories
{
    public class SportRepository : ISportRepository
    {
        private readonly SportClubDBContext _context;

        public SportRepository(SportClubDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(string name)
        {
            var sport = await _context.Sports.FirstOrDefaultAsync(x => x.Name == name);
            if (sport == null)
            {
                return false;
            }
            _context.Sports.Remove(sport);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Sport>> GetAll()
        {
            return await  _context.Sports.AsNoTracking().ToListAsync();
        }

        public async Task<Sport> GetByName(string name)
        {
            return await _context.Sports.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<bool> Insert(Sport item)
        {
            var result = await _context.Sports.AddAsync(item);
            if (result.Entity == null)
            {
                return false;
            }
            int res = await _context.SaveChangesAsync();
            return res > 0;
        }

        public async Task<bool> Update(Sport item)
        {
            var sport = await _context.Sports.FirstOrDefaultAsync(x => x.Name == item.Name);
            sport.Type = item.Type;
            _context.Sports.Update(sport);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
