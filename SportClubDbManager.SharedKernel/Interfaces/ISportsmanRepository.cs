using SportClubDbManager.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface ISportsmanRepository
    {
        Task<IEnumerable<Sportsman>> GetAll();
        Task<Sportsman> GetByCertNum(decimal certNum);
        Task<bool> Insert(Sportsman item);
        Task<bool> Update(Sportsman item);
        Task<bool> Delete(decimal certNum);
    }
}
