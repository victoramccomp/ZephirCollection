using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Application.Interface
{
    public interface IPokemonCardAppService : IAppServiceBase<PokemonCard>
    {
        IEnumerable<PokemonCard> GetAllPokemonCardList();
    }
}
