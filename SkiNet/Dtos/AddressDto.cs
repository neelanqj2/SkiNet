using System.ComponentModel.DataAnnotations;

namespace SkiNet.Dtos
{
    public class AddressDto
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string lastName { get; set; }
        
        [Required]
        public string Street { get; set; }
        
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
    }
}
