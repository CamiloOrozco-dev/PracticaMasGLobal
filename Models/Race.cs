using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Interfaces;

namespace PracticeMasGlobal.Models
{
    internal class Race 
   
    {

        public Guid Id { get; set; }
        public string? _Name { get; set; }
        public int _NumberOfVehicles { get; set; }
        public ERaceType Type;
        public int _Laps { get; set; }

        public Race (string name, int numberOfVehicles)
        {
             Guid id = Guid.NewGuid ();
            _NumberOfVehicles = numberOfVehicles;
            _Name = name;
        }
      
    }
}




