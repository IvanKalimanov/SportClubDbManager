using SportClubDbManager.Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services.Interfaces
{
    public interface ITrainerService
    {
        Task<IEnumerable<TrainerDto>> GetAll();
        Task<bool> Insert(TrainerDto item);
        Task<bool> Delete(decimal id);
        
    }
}
