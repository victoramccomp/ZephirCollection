using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class CardTypeRepository : RepositoryBase<CardTypeRepository>, ICardTypeRepository
    {
        public void Add(CardType obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(CardType obj)
        {
            throw new NotImplementedException();
        }

        public void Update(CardType obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CardType> IRepositoryBase<CardType>.GetAll()
        {
            return Db.Set<CardType>();
        }

        CardType IRepositoryBase<CardType>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
