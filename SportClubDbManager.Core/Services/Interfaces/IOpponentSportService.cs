using SportClubDbManager.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services.Interfaces
{
    public interface IOpponentSportService
    {
        Task<IEnumerable<OpponentSportDto>> GetAll();
        Task<bool> Insert(OpponentSportDto item);
        Task<bool> Update(OpponentSportDto item);
        Task<bool> Delete(string name);
    }
}
