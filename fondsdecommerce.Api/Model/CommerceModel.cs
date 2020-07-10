using System.ComponentModel.DataAnnotations;

namespace fondsdecommerce.Api.Model
{
    public class CommerceModel
    {

        [Required]
        public int Id { get; set; }
       
        [Required]
        public string Name { get; set; }

        [Required]
        public string RegistreCommerce { get; set; }
        
        public string Action { get; set; }

    }
}