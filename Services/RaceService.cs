using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Interfaces;
using PracticeMasGlobal.Models;
using PracticeMasGlobal.Util;

namespace PracticeMasGlobal.Services
{
    public class RaceService : IRaceService
    {
        CompetitorService competitorService = new CompetitorService();
        VehicleServices vehicleServices = new VehicleServices();
        public Race? register(string name, ERaceType type, int NumberOfvehicles, int laps)
        {
            if (NumberOfvehicles > 5 && NumberOfvehicles < 15 && laps > 2 && laps < 23)
            {
                Race race = new Race()
                {
                    Id = Guid.NewGuid(),
                    _NumberOfVehicles = NumberOfvehicles,
                    Type = type,
                    _Laps = laps,
                    _Name = name,
                    
                };
                InitializerObjects(race);
                return race;

            }

            Console.WriteLine("Invalid parameters for race creation");
            return null;
        }


         public void InitializerObjects(Race? race)
        {

           List <Vehicle>? generateRandomVehicles = vehicleServices.SetRandomVehicles(race._NumberOfVehicles, race.Type);
           List <Competitor> EnlistedCompetitors = competitorService.AddCompetitors(generateRandomVehicles);
            string getCompetitors = competitorService.GetCompetitors(EnlistedCompetitors);
            Console.WriteLine($"{getCompetitors}\n The race has started ");
           // startLoop();

        }




        public Task<string> GetPodiumByLap()
        {
            throw new NotImplementedException();
        }

      

        public string ProbabilityPositions()
        {
            throw new NotImplementedException();
        }

        //public void startLoop()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
