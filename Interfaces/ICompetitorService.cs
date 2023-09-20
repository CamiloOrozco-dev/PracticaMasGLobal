using Models.Class;
using PracticeMasGlobal.Enums;
using PracticeMasGlobal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Interfaces
{
    internal interface ICompetitorService
    {

        public List<Competitor> AddCompetitors( List<Vehicle> listVehicle);

        public string GetCompetitors(List<Competitor> competitor);




    }
}
