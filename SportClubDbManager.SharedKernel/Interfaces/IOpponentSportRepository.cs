using SportClubDbManager.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface IOpponentSportRepository
    {
        Task<IEnumerable<OpponentSport>> GetAll();
        Task<OpponentSport> GetByName(string name);
        Task<bool> Insert(OpponentSport item);
        Task<bool> Update(OpponentSport item);
        Task<bool> Delete(string name);
    }
}
