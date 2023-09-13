using Models.Class;
using PracticeMasGlobal.Interfaces;

namespace PracticeMasGlobal.Models
{
    internal class Race : IEventsRace
    {

        

        public int NumberOfVehicles { get; set; }
        public string TypeRace{ get; set; }

        public bool _RaceStatus { get; set; }

        public int[] position;
        string raceStarted = "In process";

         public List<Bike> _EnlistedBikes;
         public List<Truck> _EnlistedTrucks;

        public Race( List <Bike> listBike) {
        
            _EnlistedBikes = listBike;
        }
        public Race(List<Truck> listTruck)
        {

            _EnlistedTrucks = listTruck;
        }

        public void CourseRace()
        {
            throw new NotImplementedException();
        }

        public void PrintResult()
        {
            throw new NotImplementedException();
        }

        public bool StartRace()
        {
            return true; 
        }

        public string StopRace()
        {
            throw new NotImplementedException();
        }

      public string StartRace(bool RaceStatus) 
      {
            _RaceStatus = RaceStatus;

            return "Race Started";

        }

        public void GeneratePodium(int Position)
        {
            throw new NotImplementedException();
        }

    }
}




