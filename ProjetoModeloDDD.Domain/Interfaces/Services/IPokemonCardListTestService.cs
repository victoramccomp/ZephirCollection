using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Domain.Interfaces.Services
{
    public interface IPokemonCardListTestService : IServiceBase<PokemonCard>
    {
        IEnumerable<PokemonCard> GetAllPokemonCardList();
    }
}
