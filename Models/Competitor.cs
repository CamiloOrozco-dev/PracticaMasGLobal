using PracticeMasGlobal.Enums;
using PracticeMasGlobal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Models
{
    internal class Competitor 
    {

        public Guid Id { get; set; }
        public Epilots FullName{ get; set; }
        public Guid Vehicle { get; set; }
         public int CurrentPosition { get; set; }

       
    }
}
