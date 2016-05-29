using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class TrainerTypeRepository : RepositoryBase<TrainerTypeRepository>, ITrainerTypeRepository
    {
        public void Add(TrainerType obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(TrainerType obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TrainerType obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TrainerType> IRepositoryBase<TrainerType>.GetAll()
        {
            return Db.Set<TrainerType>();
        }

        TrainerType IRepositoryBase<TrainerType>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
