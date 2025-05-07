using NTierExample.Application.Dtos;
using NTierExample.Application.Interfaces;
using NTierExample.Data.Interfaces;

namespace NTierExample.Application.BaristaService
{
    public class BaristaService : IBaristaService
    {
        public IBaristaRepository _baristaRepository;
        public BaristaService(IBaristaRepository _baristaRepository)
        {
            _baristaRepository = _baristaRepository;
        }

        public async Task<BaristaDto> GetBarista(int round)
        {
            var barista = await _baristaRepository.GetByRoundAsync(round);

            var baristaDto = new BaristaDto
            {
                round = round,
                currentHealth = barista.currentHealth,
                currentDmg = barista.currentDmg
            };
            return baristaDto;
        }
    }
}