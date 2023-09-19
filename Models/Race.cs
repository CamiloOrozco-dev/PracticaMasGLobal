using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Interfaces;

namespace PracticeMasGlobal.Models
{
    public class Race 
   
    {

        public Guid Id { get; set; }
        public string _Name { get; set; }
        public int _NumberOfVehicles { get; set; }
        public bool statusRace { get; set; }
        public ERaceType Type;
        public int _Laps { get; set; }

       
      
    }
}




