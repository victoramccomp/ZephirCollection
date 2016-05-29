using AutoMapper;
using MVC.ViewModels;
using ZephirCollection.Domain.Entities;

namespace MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<PokemonCardListTestViewModel, Card>();
            Mapper.CreateMap<PokemonCardListTestViewModel, PokemonCard>();
        }
    }
}