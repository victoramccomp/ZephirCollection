using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Services;

namespace ZephirCollection.Application
{
    public class CollectionAppService : AppServiceBase<Collection>, ICollectionAppService
    {
        private readonly ICollectionService _collectionService;

        public CollectionAppService(ICollectionService collectionService)
            : base(collectionService)
        {
            _collectionService = collectionService;
        }
    }
}
