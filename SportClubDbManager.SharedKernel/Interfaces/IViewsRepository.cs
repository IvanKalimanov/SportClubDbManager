using SportClubDbManager.Data;
using SportClubDbManager.Data.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface IViewsRepository
    {
        Task<IEnumerable<PairedSportError>> GetPairedSportErrorView();
        Task<IEnumerable<SportsmenMove>> GetSportsmenMoveView();
        Task<IEnumerable<SportsmenWithoutMove>> GetSportsmenWithoutMoveView();
        Task<IEnumerable<OpponentSameSport>> GetOpponentSameSportView();
    }
}
