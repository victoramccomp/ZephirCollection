using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class SeriesRepository : RepositoryBase<SeriesRepository>, ISeriesRepository
    {
        public void Add(Series obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Series obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Series obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Series> IRepositoryBase<Series>.GetAll()
        {
            return Db.Set<Series>();
        }

        Series IRepositoryBase<Series>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
