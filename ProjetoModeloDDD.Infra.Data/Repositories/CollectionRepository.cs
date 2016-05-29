using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class CollectionRepository : RepositoryBase<CollectionRepository>, ICollectionRepository
    {
        public void Add(Collection obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Collection obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Collection obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Collection> IRepositoryBase<Collection>.GetAll()
        {
            return Db.Set<Collection>();
        }

        Collection IRepositoryBase<Collection>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
