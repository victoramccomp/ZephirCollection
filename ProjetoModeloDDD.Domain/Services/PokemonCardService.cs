using ZephirCollection.Domain.Interfaces;
using ZephirCollection.Domain.Interfaces.Services;
using ZephirCollection.Domain.Interfaces.Repositories;
using ZephirCollection.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ZephirCollection.Domain.Services
{
    public class PokemonCardService : ServiceBase<PokemonCard>, IPokemonCardService
    {
        private readonly IPokemonCardRepository _pokemonCardRepository;

        public PokemonCardService(IPokemonCardRepository pokemonCardRepository)
            : base(pokemonCardRepository)
        {
            _pokemonCardRepository = pokemonCardRepository;
        }

        public IEnumerable<PokemonCard> GetAllPokemonCardList()
        {
            return _pokemonCardRepository.GetAllPokemonCardList();
        }
    }
}
