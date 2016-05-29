using ZephirCollection.Domain.Entities;
using System.Collections.Generic;

namespace ZephirCollection.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
