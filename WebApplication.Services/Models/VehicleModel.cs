using System.ComponentModel.DataAnnotations;

namespace WebApplication.Services.Models
{
    public class VehicleModel
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string ModelName { get; set; }

        [Required]
        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        public string ManufacturerId { get; set; }
        
    }
}