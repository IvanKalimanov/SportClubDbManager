using SportClubDbManager.Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services.Interfaces
{
    public interface ISportService
    {
        Task<IEnumerable<SportDto>> GetAll();
        Task<bool> Insert(SportDto item);
        Task<bool> Update(SportDto item);
        Task<bool> Delete(string name);
    }
}
