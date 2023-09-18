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
    internal class CompetitorService : ICompetitorService

    {
        public Competitor AddCompetitor(Epilots name, Guid Id)
        {
          
                return new Competitor()
                {
                    Id = Guid.NewGuid(),
                    FullName = Utility.RandomPilots(),
                    CurrentPosition = 0,
                    Vehicle = Id

                };

        }
    }
}
