using Models.Class;
using PracticeMasGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Interfaces
{
    internal interface IVehicleService
    {
         IList<Vehicle> SetRandomVehicles(int NumberOfVehicles, ERaceType Type);

       string GetRandomVehicles(IList<Vehicle> convertList);
        
   

    }
}
