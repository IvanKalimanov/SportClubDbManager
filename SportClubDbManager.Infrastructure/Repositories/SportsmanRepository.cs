using Microsoft.EntityFrameworkCore;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Infrastructure.Repositories
{
    public class SportsmanRepository : ISportsmanRepository
    {
        private readonly SportClubDBContext _context;

        public SportsmanRepository(SportClubDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Delete(decimal certNum)
        {
            var sportsman = await _context.Sportsmen.FirstOrDefaultAsync(x => x.CertNum == certNum);
            if (sportsman == null)
            {
                return false;
            }
            _context.Sportsmen.Remove(sportsman);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Sportsman>> GetAll()
        {
            return await _context.Sportsmen
                .Include(x => x.TrainerNavigation)
                .Include(x => x.PartnerNavigation)
                .ToListAsync();
        }

        public async Task<Sportsman> GetByCertNum(decimal certNum)
        {
            return await _context.Sportsmen.FirstOrDefaultAsync(x => x.CertNum == certNum);
        }

        public async Task<bool> Insert(Sportsman item)
        {
            var result = await _context.Sportsmen.AddAsync(item);
            if (result.Entity != null)
            {
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> Update(Sportsman item)
        {
            var sportsman = await _context.Sportsmen.FirstOrDefaultAsync(x => x.CertNum == item.CertNum);
            sportsman.Fio = item.Fio;
            sportsman.BirthDate = item.BirthDate;
            sportsman.StartDate = item.StartDate;
            sportsman.Sex = item.Sex;
            sportsman.Trainer = item.Trainer;
            sportsman.Partner = item.Partner;
            sportsman.MobilePhone = item.MobilePhone;
            sportsman.HomePhone = item.HomePhone;
            sportsman.Address = item.Address;
            sportsman.Level = item.Level;
            sportsman.Rating = item.Rating;
            _context.Sportsmen.Update(sportsman);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
