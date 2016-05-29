using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Repositories;
using ZephirCollection.Domain.Interfaces.Services;

namespace ZephirCollection.Domain.Services
{
    public class CollectorService : ServiceBase<Collector>, ICollectorService
    {
        private readonly ICollectorRepository _collectorRepository;

        public CollectorService(ICollectorRepository collectorRepository)
            : base(collectorRepository)
        {
            _collectorRepository = collectorRepository;
        }
    }
}
