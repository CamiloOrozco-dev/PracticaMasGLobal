using PracticeMasGlobal.Enums;
using PracticeMasGlobal.Models;
using System.ComponentModel.DataAnnotations;

namespace Models.Class
{
    public class Vehicle
    {
        [Required]
        public Guid Id { get; set; }
        public string Model { get; set; }
        public EColor Color { get; set; }
        public string Brand { get; set; }
        public IDictionary<string, string> Accessories { get; set; }

        public int Position ;

       
    }
}
