using SportClubDbManager.Core.DTO;
using SportClubDbManager.Core.Services.Interfaces;
using SportClubDbManager.Data;
using SportClubDbManager.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClubDbManager.Core.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly ITrainerRepository _trainerRepository;
        private readonly IMapper _mapper;

        public TrainerService(ITrainerRepository trainerRepository, IMapper mapper)
        {
            _trainerRepository = trainerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TrainerDto>> GetAll()
        {
            return (await _trainerRepository.GetAll()).Select(x => _mapper.Map<Trainer, TrainerDto>(x));
        }

        public Task<bool> Insert(TrainerDto item)
        {
            return _trainerRepository.Insert(_mapper.Map<TrainerDto, Trainer>(item));
        }
        public async Task<bool> Delete(decimal id)
        {
            return await _trainerRepository.Delete(id);
        }


    }
}
