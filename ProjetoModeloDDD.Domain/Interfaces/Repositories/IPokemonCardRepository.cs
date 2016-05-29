using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Domain.Interfaces.Repositories
{
    public interface IPokemonCardRepository : IRepositoryBase<PokemonCard>
    {
        IList<PokemonCard> GetAllPokemonCardList();
    }
}
