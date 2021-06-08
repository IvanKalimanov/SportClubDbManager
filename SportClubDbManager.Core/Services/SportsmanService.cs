using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Models;
using SportClubDbManager.Core.Services.Interfaces;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services
{
    public class SportsmanService : ISportsmanService
    {
        private readonly ISportsmanRepository _sportsmanRepository;
        private readonly IMapper _mapper;

        public SportsmanService(ISportsmanRepository sportsmanRepository, IMapper mapper)
        {
            _sportsmanRepository = sportsmanRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SportsmanDto>> GetAll()
        {
            return (await _sportsmanRepository.GetAll()).Select(x => _mapper.Map<Sportsman, SportsmanDto>(x));
        }

        public Task<bool> Insert(SportsmanDto item)
        {
            return _sportsmanRepository.Insert(_mapper.Map<SportsmanDto, Sportsman>(item));
        }

        public async Task<bool> Delete(decimal certNum)
        {
            return await _sportsmanRepository.Delete(certNum);
        }

        public Task<bool> Update(SportsmanDto item)
        {
            return _sportsmanRepository.Update(_mapper.Map<SportsmanDto, Sportsman>(item));
        }

        public async Task<IEnumerable<SportsmanDto>> SearchSportsmen(SportsmanSearchModel searchParams)
        {
            var selection = (await _sportsmanRepository.GetAll()).Where(x =>
            x.Fio.ToLower().Contains(searchParams.Fio.ToLower()) &&
            x.Address.ToLower().Contains(searchParams.Address.ToLower()) &&
            x.Level.ToLower().Contains(searchParams.Level.ToLower()));
            if (searchParams.StartDate != null)
            {
                selection = selection.Where(x => x.StartDate == searchParams.StartDate);
            }

            if (searchParams.BirthDate != null)
            {
                selection = selection.Where(x => x.BirthDate == searchParams.BirthDate);
            }

            if (searchParams.Sex != null)
            {
                selection = selection.Where(x => x.Sex == searchParams.Sex);
            }
            return selection.Select(x => _mapper.Map<Sportsman, SportsmanDto>(x)); ;
        }
    }
}
