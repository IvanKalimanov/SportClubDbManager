using Microsoft.EntityFrameworkCore;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Infrastructure.Repositories
{
    public class PreviousTrainerRepository : IPreviousTrainerRepository
    {
        private readonly SportClubDBContext _context;

        public PreviousTrainerRepository(SportClubDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(decimal trainerId, decimal sportsmanCertNum)
        {
            var item = await _context.PreviousTrainers.FirstOrDefaultAsync(x =>
                x.Sportsman == sportsmanCertNum && x.Trainer == trainerId);
            if(item != null)
            {
                _context.PreviousTrainers.Remove(item);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<PreviousTrainer>> GetAll()
        {
            return await _context.PreviousTrainers
                .Include(x => x.SportsmanNavigation)
                .Include(x => x.TrainerNavigation)
                .ToListAsync();
        }

        public async Task<bool> Insert(PreviousTrainer item)
        {
            var result = await _context.PreviousTrainers.AddAsync(item);
            if (result.Entity != null)
            {
                await _context.SaveChangesAsync();
                return true;
            }
            
            return false;
        }

        public async Task<bool> Update(PreviousTrainer item)
        {
            _context.PreviousTrainers.Update(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
