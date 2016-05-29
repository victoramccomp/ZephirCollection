using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Services;

namespace ZephirCollection.Application
{
    public class RarityAppService : AppServiceBase<Rarity>, IRarityAppService
    {
        private readonly IRarityService _rarityService;

        public RarityAppService(IRarityService rarityService)
            : base(rarityService)
        {
            _rarityService = rarityService;
        }
    }
}
