using Models.Class;
using PracticeMasGlobal.Interfaces;

namespace PracticeMasGlobal.Models
{
    internal class Race<T> : IEventsRace
    {
        public int NumberOfVehicles { get; set; }
        public string TypeRace{ get; set; }

        public bool _RaceStatus { get; set; }

        public int[] position;
         public List<Bike>? _EnlistedBikes;
         public List<Truck>? _EnlistedTrucks;

        public  Race( List<T> listobject) {
            if(typeof(T) == typeof(List<Truck>))
            {
                _EnlistedTrucks = (List<Truck>?)Convert.ChangeType(listobject, typeof(List<Truck>));
            }
            if (typeof(T) == typeof(List<Bike>))
            {
                _EnlistedBikes = (List<Bike>?)Convert.ChangeType(listobject, typeof(List<Bike>));
            }
        }
       

        public void courseRace()
        {
            throw new NotImplementedException();
        }

        public void printResult()
        {
            throw new NotImplementedException();
        }

 

        public string stopRace()
        {
            throw new NotImplementedException();
        }

      public string startRace(bool RaceStatus, List<Truck> list) 
      {
            if (_EnlistedBikes != null)
            {
                _RaceStatus = RaceStatus;

                return "Race Started";
            }

            if (_EnlistedTrucks != null) { 
                
                
                
              _RaceStatus = RaceStatus;
                
                return "Race Started";
               
            }

            return "The race could not be started  ";
           

        }

        public void generatePodium(int Position)
        {
            throw new NotImplementedException();
        }

        public void getlistAndSetTypeList()
        {
            throw new NotImplementedException();
        }
    }
}




