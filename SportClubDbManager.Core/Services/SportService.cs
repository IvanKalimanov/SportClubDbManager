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
    public class SportService : ISportService
    {
        private readonly ISportRepository _sportRepository;
        private readonly IMapper _mapper;

        public SportService(ISportRepository sportRepository, IMapper mapper)
        {
            _sportRepository = sportRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SportDto>> GetAll()
        {
            return (await _sportRepository.GetAll()).Select(x => _mapper.Map<Sport, SportDto>(x));
        }

        public Task<bool> Insert(SportDto item)
        {
            return _sportRepository.Insert(_mapper.Map<SportDto, Sport>(item));
        }

        public Task<bool> Update(SportDto item)
        {
            return _sportRepository.Update(_mapper.Map<SportDto, Sport>(item));
        }

        public async Task<bool> Delete(string name)
        {
            return await _sportRepository.Delete(name);
        }
    }
}
