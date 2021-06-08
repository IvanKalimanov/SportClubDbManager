using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services.Interfaces
{
    public interface ISportsmanService
    {
        Task<IEnumerable<SportsmanDto>> GetAll();
        Task<bool> Insert(SportsmanDto item);
        Task<bool> Delete(decimal certNum);
        Task<bool> Update(SportsmanDto item);
        Task<IEnumerable<SportsmanDto>> SearchSportsmen(SportsmanSearchModel searchParams);
    }
}
