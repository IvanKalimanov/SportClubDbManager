using SportClubDbManager.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface ITrainerRepository
    {
        Task<IEnumerable<Trainer>> GetAll();
        Task<Trainer> GetById(decimal id);
        Task<bool> Insert(Trainer item);
        Task<bool> Update(Trainer item);
        Task<bool> Delete(decimal id);
    }
}
