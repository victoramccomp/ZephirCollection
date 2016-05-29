using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class PokemonTypeRepository : RepositoryBase<PokemonTypeRepository>, IPokemonTypeRepository
    {
        public void Add(PokemonType obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(PokemonType obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PokemonType obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<PokemonType> IRepositoryBase<PokemonType>.GetAll()
        {
            return Db.Set<PokemonType>();
        }

        PokemonType IRepositoryBase<PokemonType>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
