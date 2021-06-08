using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Services.Interfaces;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services
{
    public class PreviousTrainerService : IPreviousTrainerService
    {
        private readonly IPreviousTrainerRepository _previousTrainerRepository;
        private readonly IMapper _mapper;

        public PreviousTrainerService(IPreviousTrainerRepository previousTrainerRepository, IMapper mapper)
        {
            _previousTrainerRepository = previousTrainerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PreviousTrainerDto>> GetAll()
        {
            return (await _previousTrainerRepository.GetAll()).Select(x => _mapper.Map<PreviousTrainer, PreviousTrainerDto>(x));
        }

        public Task<bool> Insert(PreviousTrainerDto item)
        {
            return _previousTrainerRepository.Insert(_mapper.Map<PreviousTrainerDto, PreviousTrainer>(item));
        }

        public Task<bool> Delete(decimal trainerId, decimal sportsmanCertNum)
        {
            return _previousTrainerRepository.Delete(trainerId, sportsmanCertNum);
        }
    }
}
