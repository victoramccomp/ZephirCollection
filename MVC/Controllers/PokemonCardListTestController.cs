using AutoMapper;
using MVC.ViewModels;
using ZephirCollection.Application.Interface;
using ZephirCollection.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PokemonCardListTestController : Controller
    {
        //Faltam os serviços
        private readonly IPokemonCardListTestAppService _pokemonCardListTestAppService;

        public PokemonCardListTestController(IPokemonCardListTestAppService pokemonCardListTestAppService)
        {
            _pokemonCardListTestAppService = pokemonCardListTestAppService;
        }

        public ActionResult Index()
        {
            var pokemonCardListTestViewModel = Mapper.Map<IEnumerable<PokemonCard>, IEnumerable<PokemonCardListTestViewModel>>(_pokemonCardListTestAppService.GetAllPokemonCardList().ToList());

            var collectionListTestViewModel = Mapper.Map<IEnumerable<PokemonCard>, IEnumerable<PokemonCardListTestViewModel>>(_pokemonCardListTestAppService.GetAllPokemonCardList().ToList());

            return View(pokemonCardListTestViewModel);
        }
	}
}