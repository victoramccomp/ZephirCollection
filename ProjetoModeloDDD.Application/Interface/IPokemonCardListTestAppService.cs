using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Application.Interface
{
    public interface IPokemonCardListTestAppService : IAppServiceBase<PokemonCard>
    {
        IEnumerable<PokemonCard> GetAllPokemonCardList();
    }
}
