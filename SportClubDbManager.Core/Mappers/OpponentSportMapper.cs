using SportClubDbManager.Core.DTO;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportClubDbManager.Core.Mappers
{
    public class OpponentSportMapper : IMapper<OpponentSport, OpponentSportDto>, IMapper<OpponentSportDto, OpponentSport>
    {
        public OpponentSportDto Map(OpponentSport source) =>
            new OpponentSportDto()
            {
                Name = source.Name,
                Type = source.Type
            };

        public OpponentSport Map(OpponentSportDto source) =>
            new OpponentSport()
            {
                Name = source.Name,
                Type = source.Type
            };
    }
}
