using ZephirCollection.Domain.Entities;
using System;
using System.Collections.Generic;


namespace ZephirCollection.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
