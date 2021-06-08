using System;
using System.Collections.Generic;
using System.Text;

namespace SportClubDbManager.SharedKernel.Interfaces
{
    public interface IMapper
    {
        TDest Map<TSource, TDest>(TSource source);
    }
}
