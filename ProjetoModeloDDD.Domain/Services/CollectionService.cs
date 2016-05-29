using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Repositories;
using ZephirCollection.Domain.Interfaces.Services;

namespace ZephirCollection.Domain.Services
{
    public class CollectionService : ServiceBase<Collection>, ICollectionService
    {
        private readonly ICollectionRepository _collectionRepository;

        public CollectionService(ICollectionRepository collectionRepository)
            : base(collectionRepository)
        {
            _collectionRepository = collectionRepository;
        }
    }
}
