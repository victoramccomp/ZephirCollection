using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public IEnumerable<Card> GetAllCardList()
        {
            var retorno = Db.Set<Card>()
                .Include("Collection")
                .Include("Rarity");

            return retorno;
        }
    }
}
