using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Services;

namespace ZephirCollection.Application
{
    public class CollectorAppService : AppServiceBase<Collector>, ICollectorAppService
    {
        private readonly ICollectorService _collectorService;

        public CollectorAppService(ICollectorService collectorService)
            : base(collectorService)
        {
            _collectorService = collectorService;
        }
    }
}
