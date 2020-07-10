using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fondsdecommerce.Api.Model;
using fondsdecommerce.Repository.Domain;
using fondsdecommerce.Services.MiddelLayer;


namespace fondsdecommerce.Api.Controllers
{
    [Route("api")]
    public class CommerceController : ControllerBase
    {
        private readonly ICommerceService _commerceService;

        public CommerceController(ICommerceService commerceService)
        {
            _commerceService = commerceService;
        }

        [HttpGet("commerces")]
        public async Task<IActionResult> GetAllcommerces()
        {
            
            var list = await _commerceService.GetAllAsync();

            if (list.Count == 0)
            {
                return NotFound();
            }

            return Ok(list);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int Id)
        {
            if (Id <= 0)
            {
                return BadRequest();
            }

            var com = await _commerceService.GetByIdAsync(Id);

            if (com == null)
            {
                return NotFound();
            }

            return Ok(com);
        }
 
    }
}