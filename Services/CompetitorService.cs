using Microsoft.VisualStudio.TestPlatform.Utilities;
using Models.Class;
using PracticeMasGlobal.Enums;
using PracticeMasGlobal.Interfaces;
using PracticeMasGlobal.Models;
using PracticeMasGlobal.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Services
{
    public class CompetitorService : ICompetitorService

    {
        public List<Competitor> AddCompetitors(List<Vehicle> listVehicles)
        {
            List<Competitor> listCompetitors = new List<Competitor>();
            foreach (var vehicle in listVehicles)
            {
                {
                    Competitor competitor = new Competitor
                    {
                        Id = Guid.NewGuid(),
                        FullName = Utility.RandomPilots(),
                        Vehicle = vehicle

                    };

                    listCompetitors.Add(competitor);

                }
            }
           return listCompetitors;

        }

        public string GetCompetitors(List<Competitor> competitor)
        {

            string outPut = string.Empty;
            Console.WriteLine( $"#  {"Pilot Name",-15}{"Model",-10}{"Color",-10}{"Brand",-10}\n");

            foreach (Competitor i in competitor)
            {
                outPut += $"{i.Vehicle.Position}: {i.FullName,-15}{i.Vehicle.Model,-10}{i.Vehicle.Color,-10}{i.Vehicle.Brand,-10}\n";
            }


            return outPut;
        }

    }
}
