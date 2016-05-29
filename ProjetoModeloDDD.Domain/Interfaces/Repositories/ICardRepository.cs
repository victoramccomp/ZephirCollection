using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Domain.Interfaces.Repositories
{
    public interface ICardRepository : IRepositoryBase<Card>
    {
        IEnumerable<Card> GetAllCardList();
    }
}
