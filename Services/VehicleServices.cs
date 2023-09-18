using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Interfaces;
using PracticeMasGlobal.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Services
{
    internal class VehicleServices : IVehicleService
    {
        public string GetRandomVehicles(IList<Vehicle> randomList)
        {
            int n = 0;
            string outPut = string.Empty;
            Console.WriteLine($" \tModel \t Color\t  Brand");
            foreach (Vehicle i in randomList)
               
            {
                n++;
             outPut += $" {n}:\t{i.Model}\t{i.Color}\t{i.Brand}\n";
            }
            return outPut;
        }



        public IList<Vehicle> SetRandomVehicles(int NumberOfVehicles, ERaceType Type)
        {

            List<Vehicle> ListRandom = new();

            for (int i = 0; i < NumberOfVehicles; i++)
            {
                Vehicle vehicle = new Vehicle()
                {
                    Id = Guid.NewGuid(),
                    Model = Utility.RandomModel(4),
                    Brand = Utility.RandomBrand(Type),
                    Color = Utility.RandomColor(),
                    Accessories = new Dictionary<string, string>()

                };
                ListRandom.Add(vehicle);
            }
            return ListRandom;
        }

    }
}
