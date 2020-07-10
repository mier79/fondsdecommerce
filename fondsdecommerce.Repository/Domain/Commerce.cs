using System.Collections.Generic;

namespace fondsdecommerce.Repository.Domain
{
    public class Commerce 
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string RegistreCommerce {get; set;}

        public Achalandage Achal {get; set;}

    }
}
