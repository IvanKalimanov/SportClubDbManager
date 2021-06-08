using SportClubDbManager.Core.Services.Interfaces;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services
{
    public class ReportService : IReportService
    {
        private readonly IViewsRepository _viewsRepository;

        public ReportService(IViewsRepository viewsRepository)
        {
            _viewsRepository = viewsRepository;
        }

        public async Task<IEnumerable<string>> GetSportsmenMovesReport()
        {
            return (await _viewsRepository.GetSportsmenMoveView()).Select(x => x.ToString());
        }

        public async Task<IEnumerable<string>> GetSportsmenWithoutMovesReport()
        {
            return (await _viewsRepository.GetSportsmenWithoutMoveView()).Select(x => x.ToString());
        }

        public async Task<IEnumerable<string>> GetPairedSportErrorReport()
        {
            return (await _viewsRepository.GetPairedSportErrorView()).Select(x => x.ToString());
        }

        public async Task<IEnumerable<string>> GetOpponentSameSportReport()
        {
            return (await _viewsRepository.GetOpponentSameSportView()).Select(x => x.ToString());
        }
    }
}
