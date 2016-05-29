using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Infra.Data.Context;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using ZephirCollection.Domain.Entities.DTO;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class PokemonCardRepository : RepositoryBase<PokemonCard>, IPokemonCardRepository
    {
        public IList<PokemonCard> GetAllPokemonCardList()
        {
            var retorno = Db.Set<PokemonCard>().ToList();

            return retorno;
        }
    }
}
