using NTierExample.Data.Types;

namespace NTierExample.Data.Interfaces
{
    public interface IBaristaRepository
    {
        public Task<Barista> GetByIdAsync(int id);
        public Task<Barista> GetByRoundAsync(int round);
    }
}
