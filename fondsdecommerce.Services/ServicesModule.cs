using System;
using Microsoft.Extensions.DependencyInjection;
using fondsdecommerce.Services.MiddelLayer;

namespace fondsdecommerce.Services
{
    public static class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICommerceService, CommerceService>();
            
        }
    }
}
