using Models.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMasGlobal.Interfaces
{
    internal interface IEventsRace
    {
        public string startRace(bool RaceStatus, List<Truck> listExist);
        public string stopRace();
        public void courseRace();
        public void printResult();
        public void generatePodium(int Position);

        public void getlistAndSetTypeList( );
    }
}