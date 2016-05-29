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
    public class CollectionManagementController : Controller
    {
        private readonly ICardAppService _cardAppService;
        private readonly IRarityAppService _rarityAppService;
        private readonly ICollectionAppService _collectionAppService;
        private readonly ICollectorAppService _collectorAppService;

        public CollectionManagementController(
            ICardAppService cardAppService,
            IRarityAppService rarityAppService,
            ICollectionAppService collectionAppService,
            ICollectorAppService collectorAppService)
        {
            _cardAppService = cardAppService;
            _rarityAppService = rarityAppService;
            _collectionAppService = collectionAppService;
            _collectorAppService = collectorAppService;
        }

        public ActionResult Index()
        {
            var collectionManagement = new List<CollectionManagementViewModel>();

            var cards = _cardAppService.GetAll();
            var rarity = _rarityAppService.GetAll();
            var collection = _collectionAppService.GetAll();
            var collector = _collectorAppService.GetAll();

            foreach (var card in cards)
            {
                collectionManagement.Add(new CollectionManagementViewModel
                {
                    CardDescription = card.Description,
                    CardNumber = card.CardNumber,
                    CollectionDescription = collection.FirstOrDefault(s => s.CollectionId == card.CollectionId).Description,
                    RarityAbbreviation = rarity.FirstOrDefault(s => s.RarityId == card.RarityId).Abbreviation,
                });
            }
            
            return View(collectionManagement);
        }
    }
}