using SportClubDbManager.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface IPreviousTrainerRepository
    {
        Task<IEnumerable<PreviousTrainer>> GetAll();
        Task<bool> Insert(PreviousTrainer item);
        Task<bool> Update(PreviousTrainer item);
        Task<bool> Delete(decimal trainerId, decimal sportsmanCertNum);
    }
}
