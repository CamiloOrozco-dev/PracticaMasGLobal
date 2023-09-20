using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Interfaces;
using PracticeMasGlobal.Models;
using PracticeMasGlobal.Util;
using System.Diagnostics;

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
            string getVehicles = vehicleServices.GetRandomVehicles(generateRandomVehicles);
            Console.WriteLine(getVehicles);
            List<Competitor> EnlistedCompetitors = competitorService.AddCompetitors(generateRandomVehicles);
            startLoop(race, EnlistedCompetitors);

        }




        public string[] GetPodium(string list)
        {
            Console.WriteLine($"-----CONGRATULATIONS----\n" +
                $"The winner is: ");
              string[] prueba = list.Split("\n");
            return prueba;
            
        }

      

        public string ProbabilityPositions(List<Competitor> Competitors)
        {
            Random random = new Random();
            List<Competitor> lPositions = Competitors.OrderBy(x => random.Next()).ToList();
            string output = competitorService.GetCompetitors(lPositions);
            return output;

        }

        public void startLoop(Race race, List<Competitor> listCompetitor)
        {
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine($" The race |{race._Name}| has started");
                string getCompetitors = competitorService.GetCompetitors(listCompetitor);
                Console.WriteLine($"{getCompetitors} ");
            string changePosition = "Not Found";
            for (int i = 1; i <= race._Laps; i++)
            {
                Console.WriteLine($"Lap {i}/{race._Laps}");
                stopwatch.Start();
                Thread.Sleep(random.Next(1000, 7000));
                changePosition = ProbabilityPositions(listCompetitor);
                Console.WriteLine($"{changePosition} ");
                stopwatch.Stop();
                TimeSpan time = stopwatch.Elapsed;
                Console.WriteLine($"time: {time}");
                Thread.Sleep(5000);
                stopwatch.Reset();
               
            }
            
            Console.WriteLine($" Race ended");
           string[] Podium = GetPodium(changePosition);
            for (int i = 0; i <  3; i++) {

            Console.WriteLine(Podium [i]);
            }
        }
    }
}
