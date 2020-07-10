using System;
using System.IO;
using Newtonsoft.Json;
using fondsdecommerce.Repository;
using fondsdecommerce.Repository.Domain;

namespace fondsdecommerce.Api
{
    public class DataSeed : IDataSeed
    {
        public Commerce[] GetCommerces()
        {
            return JsonConvert.DeserializeObject<Commerce[]>(File.ReadAllText(Path.Combine("Data","commerce.json")));
        }
        
    }
}