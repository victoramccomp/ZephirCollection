using AutoMapper;
using MVC.ViewModels;
using ZephirCollection.Domain.Entities;

namespace MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Card, PokemonCardListTestViewModel>();
            Mapper.CreateMap<PokemonCard, PokemonCardListTestViewModel>();
        }
    }
}