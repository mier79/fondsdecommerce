using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using fondsdecommerce.Repository.Domain;
using fondsdecommerce.Repository.DataAccessLayer;


namespace fondsdecommerce.Services.MiddelLayer 
{
    public class CommerceService : GenericService<Commerce>, ICommerceService

    {
        private ICommerceRepository CommerceRepository { get;}
        public CommerceService(ICommerceRepository commerceRepository) : base(commerceRepository)
        {
            CommerceRepository =  commerceRepository ;
        }
   
    }

}