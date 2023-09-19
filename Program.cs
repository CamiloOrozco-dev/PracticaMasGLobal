using Models.Class;
using PracticeMasGlobal.Enum;
using PracticeMasGlobal.Enums;
using PracticeMasGlobal.Models;
using PracticeMasGlobal.Services;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace PracticeMasGlobal
{
    public class Program
    {

        public static void Main(string[] args)
        {

            RaceService raceService = new RaceService();
           Race? newRace = raceService.register("Race test", ERaceType.MotorBike, 6, 6);

        }
    }
}