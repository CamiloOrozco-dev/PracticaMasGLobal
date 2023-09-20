using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Interfaces;
using PracticeMasGlobal.Models;
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
    public class VehicleServices : IVehicleService
    {
       
        public string GetRandomVehicles(List<Vehicle> randomList)
        {
            
            string outPut = string.Empty;
            Console.WriteLine($"   Model\tColor\t  Brand\n");
            foreach (Vehicle i in randomList)
               
            {
             outPut += $"{i.Position}:  {i.Model}\t{i.Color}\t {i.Brand}\n ";
            }
          
            return outPut;
        }



        public List<Vehicle> SetRandomVehicles(int NumberOfVehicles, ERaceType Type)
        {
            List<Vehicle> ListRandom = new();
            for (int i = 1; i <= NumberOfVehicles; i++)
            {
                
                Vehicle vehicle = new Vehicle()
                {
                   
                    Id = Guid.NewGuid(),
                    Model = Utility.RandomModel(4),
                    Brand = Utility.RandomBrand(Type),
                    Color = Utility.RandomColor(),
                    Accessories = new Dictionary<string, string>(),
                    Position = i,
                    
                };
                ListRandom.Add(vehicle);
            
            }
                
            return ListRandom;
        }

    }
}
