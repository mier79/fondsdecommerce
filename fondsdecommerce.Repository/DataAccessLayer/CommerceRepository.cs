using System.Linq;
using Microsoft.EntityFrameworkCore;
using fondsdecommerce.Repository.Domain;

namespace fondsdecommerce.Repository.DataAccessLayer
{
    public class CommerceRepository : GenericRepository<Commerce>, ICommerceRepository
    {
        public CommerceRepository(ExchangeContext dbContext)
        {
            DbContext = dbContext;
        }
           
    
    }
}