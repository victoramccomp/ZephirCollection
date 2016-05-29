using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class CollectorRepository : RepositoryBase<CollectorRepository>, ICollectorRepository
    {
        public void Add(Collector obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Collector obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Collector obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Collector> IRepositoryBase<Collector>.GetAll()
        {
            return Db.Set<Collector>();
        }

        Collector IRepositoryBase<Collector>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
