using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Interfaces
{
    internal interface IEventsRace
    {
        public string StartRace(bool RaceStatus);
        public string StopRace();
        public void CourseRace();
        public void PrintResult();
        public void GeneratePodium(int Position);
    }
}