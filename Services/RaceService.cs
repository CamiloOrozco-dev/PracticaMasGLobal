using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Interfaces;
using PracticeMasGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Services
{
    internal class RaceService : IRaceService


    {

        public bool Register(string name, ERaceType Type, int NumberOfvehicles)
        {

            //Console.WriteLine("Register Race");
            //Console.WriteLine("Enter the Race name");
            //Console.WriteLine("Enter the Type of race");



            return false;
            
        }

        public Task<string> GetPodiumByLap()
        {
            throw new NotImplementedException();
        }

        public string GetRacePosition(Guid competitor, int NumberofVehicles)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Competitor>> ProbabilityPositions()
        {
            throw new NotImplementedException();
        }

        public Task<string> RandomRacePosition()
        {
            throw new NotImplementedException();
        }

        

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
