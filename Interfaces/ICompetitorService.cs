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

        public Competitor AddCompetitor(Epilots name, Guid Id);
       
            
        
    }
}
