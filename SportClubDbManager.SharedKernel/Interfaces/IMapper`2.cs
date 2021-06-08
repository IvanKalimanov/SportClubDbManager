using System.Collections.Generic;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface IMapper<in TSource, out TDest>
    {
        TDest Map(TSource source);
    }
}
