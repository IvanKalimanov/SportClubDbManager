using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Services.Interfaces;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services
{
    public class OpponentSportService : IOpponentSportService
    {
        private readonly IOpponentSportRepository _opponentSportRepository;
        private readonly IMapper _mapper;

        public OpponentSportService(IOpponentSportRepository opponentSportRepository, IMapper mapper)
        {
            _opponentSportRepository = opponentSportRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OpponentSportDto>> GetAll()
        {
            return (await _opponentSportRepository.GetAll()).Select(x => _mapper.Map<OpponentSport, OpponentSportDto>(x));
        }

        public Task<bool> Insert(OpponentSportDto item)
        {
            return _opponentSportRepository.Insert(_mapper.Map<OpponentSportDto, OpponentSport>(item));
        }

        public Task<bool> Update(OpponentSportDto item)
        {
            return _opponentSportRepository.Update(_mapper.Map<OpponentSportDto, OpponentSport>(item));
        }

        public async Task<bool> Delete(string name)
        {
            return await _opponentSportRepository.Delete(name);
        }
    }
}
