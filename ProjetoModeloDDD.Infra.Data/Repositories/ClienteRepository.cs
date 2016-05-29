using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Repositories;
using System;

namespace ZephirCollection.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
