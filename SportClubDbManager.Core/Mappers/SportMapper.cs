using SportClubDbManager.Core.DTO;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportClubDbManager.Core.Mappers
{
    public class SportMapper : IMapper<Sport, SportDto>, IMapper<SportDto, Sport>
    {
        public SportDto Map(Sport source) =>
            new SportDto()
            {
                Name = source.Name,
                Type = source.Type
            };

        public Sport Map(SportDto source) =>
            new Sport()
            {
                Name = source.Name,
                Type = source.Type
            };

    }
}
