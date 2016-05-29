using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class RarityRepository : RepositoryBase<RarityRepository>, IRarityRepository
    {
        public void Add(Rarity obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Rarity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Rarity obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Rarity> IRepositoryBase<Rarity>.GetAll()
        {
            return Db.Set<Rarity>();
        }

        Rarity IRepositoryBase<Rarity>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
