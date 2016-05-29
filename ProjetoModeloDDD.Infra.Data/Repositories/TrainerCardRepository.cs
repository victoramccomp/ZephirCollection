using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class TrainerCardRepository : RepositoryBase<TrainerCardRepository>, ITrainerCardRepository
    {
        public void Add(TrainerCard obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(TrainerCard obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TrainerCard obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TrainerCard> IRepositoryBase<TrainerCard>.GetAll()
        {
            return Db.Set<TrainerCard>();
        }

        TrainerCard IRepositoryBase<TrainerCard>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
