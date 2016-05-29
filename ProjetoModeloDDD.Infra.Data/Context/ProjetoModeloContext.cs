using ZephirCollection.Domain.Entities;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using ZephirCollection.Infra.Data.EntityConfig;

namespace ZephirCollection.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext()
            : base("ZephyrCollection")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Collector> Collectors { get; set; }
        public DbSet<EnergyCard> EnergyCards { get; set; }
        public DbSet<EvolutionStage> EvolutionStages { get; set; }
        public DbSet<PokemonCard> PokemonCards { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }
        public DbSet<Rarity> Rarities { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<TrainerCard> TrainerCards { get; set; }
        public DbSet<TrainerType> TrainerTypes { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(500));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new CardConfig());
            modelBuilder.Configurations.Add(new CardTypeConfig());
            modelBuilder.Configurations.Add(new CollectionConfig());
            modelBuilder.Configurations.Add(new CollectorConfig());
            modelBuilder.Configurations.Add(new EnergyCardConfig());
            modelBuilder.Configurations.Add(new EvolutionStageConfig());
            modelBuilder.Configurations.Add(new PokemonCardConfig());
            modelBuilder.Configurations.Add(new PokemonTypeConfig());
            modelBuilder.Configurations.Add(new RarityConfig());
            modelBuilder.Configurations.Add(new SeriesConfig());
            modelBuilder.Configurations.Add(new TrainerCardConfig());
            modelBuilder.Configurations.Add(new TrainerTypeConfig());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            { 
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        //public System.Data.Entity.DbSet<MVC.ViewModels.CardListTestViewModel> CardListTestViewModels { get; set; }
    }
}
