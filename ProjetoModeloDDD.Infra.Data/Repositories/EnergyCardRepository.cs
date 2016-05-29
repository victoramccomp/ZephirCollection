using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class EnergyCardRepository : RepositoryBase<EnergyCardRepository>, IEnergyCardRepository
    {
        public void Add(EnergyCard obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(EnergyCard obj)
        {
            throw new NotImplementedException();
        }

        public void Update(EnergyCard obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<EnergyCard> IRepositoryBase<EnergyCard>.GetAll()
        {
            return Db.Set<EnergyCard>();
        }

        EnergyCard IRepositoryBase<EnergyCard>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
