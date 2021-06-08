using SportClubDbManager.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface ISportRepository
    {
        Task<IEnumerable<Sport>> GetAll();
        Task<Sport> GetByName(string name);
        Task<bool> Insert(Sport item);
        Task<bool> Update(Sport item);
        Task<bool> Delete(string name);
    }
}
