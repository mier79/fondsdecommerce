using System;
using fondsdecommerce.Repository.Domain;

namespace fondsdecommerce.Repository
{
    public interface IDataSeed
    {
        Commerce[] GetCommerces();
               
    }
}