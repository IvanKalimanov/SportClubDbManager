using SportClubDbManager.Core.DTO;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;

namespace SportClubDbManager.Core.Mappers
{
    public class SportsmanMapper : IMapper<Sportsman, SportsmanDto>, IMapper<SportsmanDto, Sportsman>
    {
        public SportsmanDto Map(Sportsman source) =>
            new SportsmanDto()
            {
                CertNum = source.CertNum,
                Fio = source.Fio,
                BirthDate = source.BirthDate,
                Sex = source.Sex,
                Level = source.Level,
                TrainerId = source.Trainer,
                TrainerFio = source.TrainerNavigation.Fio,
                Rating = source.Rating,
                PartnerCertNum = source.Partner,
                PartnerFio = source.PartnerNavigation.Fio,
                Address = source.Address,
                MobilePhone = source.MobilePhone,
                HomePhone = source.HomePhone,
                StartDate = source.StartDate
            };

        public Sportsman Map(SportsmanDto source) =>
            new Sportsman()
            {
                CertNum = source.CertNum,
                Fio = source.Fio,
                BirthDate = source.BirthDate,
                Sex = source.Sex,
                Level = source.Level,
                Trainer = source.TrainerId,
                Rating = source.Rating,
                Partner = source.PartnerCertNum,
                Address = source.Address,
                MobilePhone = source.MobilePhone,
                HomePhone = source.HomePhone,
                StartDate = source.StartDate
            };
    }
}

