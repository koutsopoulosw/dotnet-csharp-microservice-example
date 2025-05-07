using NTierExample.Data.Interfaces;
using NTierExample.Data.Types;

namespace NTierExample.Data.Repositories
{
    public class BaristaRepository : IBaristaRepository
    {
        public async Task<Barista> GetByIdAsync(int id)
        {
            return new Barista();
        }
        public async Task<Barista> GetByRoundAsync(int round)
        {
            return new Barista();
        }

    }
}