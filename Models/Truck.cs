using PracticeMasGlobal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Class
{
    internal class Truck : Vehicle
    {
        public double Weight { get; set; }
        public int NumberOfWheels{ get; set; }
        public bool Trailer {  get; set; }
        public Truck() { }
       

    }
}
