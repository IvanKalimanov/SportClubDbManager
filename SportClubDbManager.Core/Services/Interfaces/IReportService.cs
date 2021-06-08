using SportClubDbManager.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<string>> GetSportsmenMovesReport();
        Task<IEnumerable<string>> GetPairedSportErrorReport();
        Task<IEnumerable<string>> GetSportsmenWithoutMovesReport();
        Task<IEnumerable<string>> GetOpponentSameSportReport();
    }
}
