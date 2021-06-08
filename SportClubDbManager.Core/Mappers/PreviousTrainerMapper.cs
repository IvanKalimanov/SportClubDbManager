using SportClubDbManager.Core.DTO;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;

namespace SportClubDbManager.Core.Mappers
{
    public class PreviousTrainerMapper : IMapper<PreviousTrainer, PreviousTrainerDto>, IMapper<PreviousTrainerDto, PreviousTrainer>
    {
        public PreviousTrainerDto Map(PreviousTrainer source) =>
            new PreviousTrainerDto()
            {
                TrainerId = source.Trainer,
                SportsmanCertNum = source.Sportsman,
                EndDate = source.EndDate,
                TrainerFio = source.TrainerNavigation.Fio,
                SportsmanFio = source.SportsmanNavigation.Fio
            };

        public PreviousTrainer Map(PreviousTrainerDto source) =>
            new PreviousTrainer()
            {
                Trainer = source.TrainerId,
                Sportsman = source.SportsmanCertNum,
                EndDate = source.EndDate
            };
    }
}
