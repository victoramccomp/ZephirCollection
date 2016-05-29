using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Repositories;
using ZephirCollection.Domain.Interfaces.Services;

namespace ZephirCollection.Domain.Services
{
    public class RarityService : ServiceBase<Rarity>, IRarityService
    {
        private readonly IRarityRepository _rarityRepository;

        public RarityService(IRarityRepository rarityRepository)
            : base(rarityRepository)
        {
            _rarityRepository = rarityRepository;
        }
    }
}
