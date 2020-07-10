using System;
using Microsoft.EntityFrameworkCore;
using fondsdecommerce.Repository.Domain;

namespace fondsdecommerce.Repository
{
    public class ExchangeContext : DbContext
    {
        private readonly IDataSeed _dataSeed;

        public ExchangeContext(IDataSeed dataSeed)
        {
            _dataSeed = dataSeed;
        }

        public ExchangeContext(DbContextOptions<ExchangeContext> options, IDataSeed dataSeed) : base(options)
        {
            _dataSeed = dataSeed;
        }

        public DbSet<Commerce> Commerces { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commerce>().HasData(_dataSeed.GetCommerces());
            
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
