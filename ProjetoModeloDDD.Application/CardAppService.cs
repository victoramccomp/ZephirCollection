using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Services;

namespace ZephirCollection.Application
{
    public class CardAppService : AppServiceBase<Card>, ICardAppService
    {
        private readonly ICardService _cardService;

        public CardAppService(ICardService cardService)
            : base(cardService)
        {
            _cardService = cardService;
        }
    }
}
