using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using ZephirCollection.Domain.Interfaces.Repositories;


namespace ZephirCollection.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
