using System.ComponentModel.DataAnnotations;

namespace Models.Class
{
    public abstract class Vehicle 
    {
        public int Id { get; set; }
        [Required]
        public string ModelVehicle { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string[] Accesories { get; set; }
        public Vehicle() { }
    }
}