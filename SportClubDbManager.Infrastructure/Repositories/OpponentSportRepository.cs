using Microsoft.EntityFrameworkCore;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Infrastructure.Repositories
{
    public class OpponentSportRepository : IOpponentSportRepository
    {
        private readonly SportClubDBContext _context;

        public OpponentSportRepository(SportClubDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(string name)
        {
            var sport = await _context.OpponentSports.FirstOrDefaultAsync(x => x.Name == name);
            if (sport == null)
            {
                return false;
            }
            _context.OpponentSports.Remove(sport);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<OpponentSport>> GetAll()
        {
            return await _context.OpponentSports.AsNoTracking().ToListAsync();
        }

        public async Task<OpponentSport> GetByName(string name)
        {
            return await _context.OpponentSports.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<bool> Insert(OpponentSport item)
        {
            var result = await _context.OpponentSports.AddAsync(item);
            if (result.Entity == null)
            {
                return false;
            }
            int res = await _context.SaveChangesAsync();
            return res > 0;
        }

        public async Task<bool> Update(OpponentSport item)
        {
            _context.OpponentSports.Update(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
