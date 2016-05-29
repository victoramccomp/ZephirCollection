using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Application
{
    public class PokemonCardListTestAppService : AppServiceBase<PokemonCard>, IPokemonCardListTestAppService
    {
        private readonly IPokemonCardListTestService _pokemonCardListTestService;

        public PokemonCardListTestAppService(IPokemonCardListTestService pokemonCardListTestService)
            : base(pokemonCardListTestService)
        {
            _pokemonCardListTestService = pokemonCardListTestService;
        }

        public IEnumerable<PokemonCard> GetAllPokemonCardList()
        {
            return _pokemonCardListTestService.GetAllPokemonCardList();
        }
    }
}
