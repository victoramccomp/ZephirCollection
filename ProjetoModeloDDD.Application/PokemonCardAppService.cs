using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using ZephirCollection.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ZephirCollection.Application
{
    public class PokemonCardAppService : AppServiceBase<PokemonCard>, IPokemonCardAppService
    {
        private readonly IPokemonCardService _pokemonCardService;

        public PokemonCardAppService(IPokemonCardService pokemonCardService)
            : base(pokemonCardService)
        {
            _pokemonCardService = pokemonCardService;
        }

        public IEnumerable<PokemonCard> GetAllPokemonCardList()
        {
            return _pokemonCardService.GetAllPokemonCardList();
        }
    }
}
