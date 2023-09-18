using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Interfaces
{
    internal interface IRaceService
    {
        bool Register(string name, ERaceType Type, int NumberOfvehicles );
        void Start();
       Task<string> GetPodiumByLap();
       string GetRacePosition(Guid competitor, int NumberofVehicles);
        Task<string> RandomRacePosition();
        Task<IList<Competitor>> ProbabilityPositions();


       
    }
}