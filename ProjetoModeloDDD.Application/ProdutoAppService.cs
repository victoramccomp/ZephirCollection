using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;


namespace ZephirCollection.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {

        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscaPorNome(nome);
        }
    }
}
