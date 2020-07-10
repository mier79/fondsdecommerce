using System.Collections.Generic;

namespace fondsdecommerce.Repository.Domain
{

    public class Client {
        
        public int Id { get; set; }
        
        public string Nom {get; set;}

        public Type typ {get; set;}
        
    }

    public enum Type {particulier , commerce};

}