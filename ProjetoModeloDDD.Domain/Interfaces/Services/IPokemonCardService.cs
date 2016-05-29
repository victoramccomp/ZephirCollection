using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Domain.Interfaces.Services
{
    public interface IPokemonCardService : IServiceBase<PokemonCard>
    {
        IEnumerable<PokemonCard> GetAllPokemonCardList();
    }
}
