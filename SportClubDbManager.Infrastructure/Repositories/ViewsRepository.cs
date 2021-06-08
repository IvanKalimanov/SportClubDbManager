using Microsoft.EntityFrameworkCore;
using SportClubDbManager.Data;
using SportClubDbManager.Data.Views;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Infrastructure.Repositories
{
    public class ViewsRepository : IViewsRepository
    {
        private readonly SportClubDBContext _context;

        public ViewsRepository(SportClubDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PairedSportError>> GetPairedSportErrorView()
        {
            return await _context.PairedSportErrors.ToListAsync();
        }

        public async Task<IEnumerable<SportsmenMove>> GetSportsmenMoveView()
        {
            return await _context.SportsmenMoves.ToListAsync();
        }

        public async Task<IEnumerable<SportsmenWithoutMove>> GetSportsmenWithoutMoveView()
        {
            return await _context.SportsmenWithoutMoves.ToListAsync();
        }

        public async Task<IEnumerable<OpponentSameSport>> GetOpponentSameSportView()
        {
            return await _context.OpponentSameSports.ToListAsync();
        }
    }
}
