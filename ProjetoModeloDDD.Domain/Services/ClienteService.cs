﻿using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Services;
using ZephirCollection.Domain.Interfaces.Repositories;
using ZephirCollection.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ZephirCollection.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
