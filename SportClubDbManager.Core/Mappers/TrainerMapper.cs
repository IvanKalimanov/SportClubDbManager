using SportClubDbManager.Core.DTO;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportClubDbManager.Core.Mappers
{
    public class TrainerMapper : IMapper<Trainer, TrainerDto>, IMapper<TrainerDto, Trainer>
    {
        public TrainerDto Map(Trainer source) =>
            new TrainerDto()
            {
                Id = source.Id,
                Fio = source.Fio,
                SportName = source.SportName,
                Level = source.Level,
                Rating = source.Rating
            };

        public Trainer Map(TrainerDto source) =>
            new Trainer()
            {
                Id = source.Id,
                Fio = source.Fio,
                SportName = source.SportName,
                Level = source.Level,
                Rating = source.Rating
            };
    }
}
