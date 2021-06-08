using Microsoft.EntityFrameworkCore;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Infrastructure.Repositories
{
    public class TrainerRepository : ITrainerRepository
    {
        private readonly SportClubDBContext _context;

        public TrainerRepository(SportClubDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(decimal id)
        {
            var trainer = await _context.Trainers.FirstOrDefaultAsync(x => x.Id == id);
            if (trainer == null)
            {
                return false;
            }
            _context.Trainers.Remove(trainer);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Trainer>> GetAll()
        {
            return await _context.Trainers.ToListAsync();
        }

        public async Task<Trainer> GetById(decimal id)
        {
            return await _context.Trainers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> Insert(Trainer item)
        {
            var result = await _context.Trainers.AddAsync(item);
            if (result.Entity == null)
            {
                return false;
            }
            int res = await _context.SaveChangesAsync();
            return res > 0;
        }

        public async Task<bool> Update(Trainer item)
        {
            _context.Trainers.Update(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
