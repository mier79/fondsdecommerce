using System.Collections.Generic;

namespace fondsdecommerce.Repository.Domain
{
    public class Achalandage 
    {

        public int Id { get; set; }
        public int NumberOfClient {get; set;}
        public List<Client> Clients {get; set;} 

    }

}