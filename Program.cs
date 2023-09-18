using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Enums;
using PracticeMasGlobal.Models;
using PracticeMasGlobal.Services;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace PracticeMasGlobal
{
    public class Program
    {

        //                     TO DO 

        // Validacion mas de dos camiones por carrera 
        // While para parar cuando el usuario quiera 
        // Como generar valores aleactorios 
        // Atributo posicion y que se asigne Aleactoriamente
        public static void Main(string[] args)
        {
            VehicleServices vehicleServices = new VehicleServices();
            CompetitorService competitorService = new CompetitorService();
            RaceService raceService = new RaceService();

            var MotorBikes = vehicleServices.SetRandomVehicles(6, ERaceType.MotorBike);

            var Trucks = vehicleServices.SetRandomVehicles(7, ERaceType.Truck);

            var ViewBikes = vehicleServices.GetRandomVehicles(MotorBikes);
            Console.WriteLine(ViewBikes);

            var ViewTruck = vehicleServices.GetRandomVehicles(Trucks);
            Console.WriteLine(ViewTruck);

          

            List<Competitor> competitors = new List<Competitor>();
           // Competitor competitor1 = competitorService.AddCompetitor(Epilots , MotorBikes[0].Id);
         //   Competitor competitor2 = competitorService.AddCompetitor(Epilots., MotorBikes[4].Id);
            //competitors.Add(competitor1);
            //competitors.Add(competitor2);

            foreach (var c in competitors)
            {
                Console.WriteLine($"/{c.FullName}/{c.Vehicle}");
            }

          
        }
    }
}