[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MVC.App_Start.NinjectWebCommon), "Stop")]

namespace MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using ZephirCollection.Application;
    using ZephirCollection.Application.Interface;
    using ZephirCollection.Domain.Services;
    using ZephirCollection.Domain.Interfaces.Services;
    using ZephirCollection.Infra.Data.Repositories;
    using ZephirCollection.Domain.Interfaces.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // Servi�o de Aplica��o
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            kernel.Bind<IPokemonCardListTestAppService>().To<PokemonCardListTestAppService>();
            kernel.Bind<ICardAppService>().To<CardAppService>();
            kernel.Bind<ICollectionAppService>().To<CollectionAppService>();
            kernel.Bind<ICollectorAppService>().To<CollectorAppService>();
            kernel.Bind<IPokemonCardAppService>().To<PokemonCardAppService>();
            kernel.Bind<IRarityAppService>().To<RarityAppService>();
            
            // Servi�o de Dom�nio
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<IPokemonCardListTestService>().To<PokemonCardListTestService>();
            kernel.Bind<ICardService>().To<CardService>();
            kernel.Bind<IPokemonCardService>().To<PokemonCardService>();
            kernel.Bind<ICollectionService>().To<CollectionService>();
            kernel.Bind<ICollectorService>().To<CollectorService>();
            kernel.Bind<IRarityService>().To<RarityService>();

            // Reposit�rio
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
            kernel.Bind<ICardRepository>().To<CardRepository>();
            kernel.Bind<ICardTypeRepository>().To<CardTypeRepository>();
            kernel.Bind<ICollectionRepository>().To<CollectionRepository>();
            kernel.Bind<ICollectorRepository>().To<CollectorRepository>();
            kernel.Bind<IEnergyCardRepository>().To<EnergyCardRepository>();
            kernel.Bind<IEvolutionStageRepository>().To<EvolutionStageRepository>();
            kernel.Bind<IPokemonCardRepository>().To<PokemonCardRepository>();
            kernel.Bind<IPokemonTypeRepository>().To<PokemonTypeRepository>();
            kernel.Bind<IRarityRepository>().To<RarityRepository>();
            kernel.Bind<ISeriesRepository>().To<SeriesRepository>();
            kernel.Bind<ITrainerCardRepository>().To<TrainerCardRepository>();
            kernel.Bind<ITrainerTypeRepository>().To<TrainerTypeRepository>();
        }        
    }
}
