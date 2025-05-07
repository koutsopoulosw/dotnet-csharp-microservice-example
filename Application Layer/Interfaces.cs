using NTierExample.Application.Dtos;

namespace NTierExample.Application.Interfaces
{
    public interface IBaristaService
    {
        public Task<BaristaDto> GetBarista(int round);
    }
}