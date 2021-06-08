using SportClubDbManager.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services.Interfaces
{
    public interface IPreviousTrainerService
    {
        Task<IEnumerable<PreviousTrainerDto>> GetAll();
        Task<bool> Insert(PreviousTrainerDto item);
        Task<bool> Delete(decimal trainerId, decimal sportsmanCertNum);
    }
}
