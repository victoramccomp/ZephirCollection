using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class EvolutionStageRepository : RepositoryBase<EvolutionStageRepository>, IEvolutionStageRepository
    {
        public void Add(EvolutionStage obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(EvolutionStage obj)
        {
            throw new NotImplementedException();
        }

        public void Update(EvolutionStage obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<EvolutionStage> IRepositoryBase<EvolutionStage>.GetAll()
        {
            return Db.Set<EvolutionStage>();
        }

        EvolutionStage IRepositoryBase<EvolutionStage>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
