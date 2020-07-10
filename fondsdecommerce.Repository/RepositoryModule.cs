using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using fondsdecommerce.Repository.DataAccessLayer;

namespace fondsdecommerce.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<ExchangeContext>(options => options.UseSqlServer(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICommerceRepository, CommerceRepository>();
            
        }
    }
}