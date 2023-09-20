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
        Race register(string name, ERaceType type, int NumberOfvehicles, int laps);
        void InitializerObjects(Race race);
       string[] GetPodium( string list);
        string ProbabilityPositions(List <Competitor> competitors);
        void startLoop(Race race, List<Competitor> listCompetitor);

        



    }
}