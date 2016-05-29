using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Repositories;
using ZephirCollection.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ZephirCollection.Domain.Services
{
    public class CardService : ServiceBase<Card>, ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardService(ICardRepository cardRepository)
            : base(cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public IEnumerable<Card> GetAllCardList()
        {
            return _cardRepository.GetAllCardList();
        }
    }
}
