using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
