using Models.Class;
using PracticeMasGlobal.Models;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace PracticeMasGlobal
{
    public class Program
    {

        //                      DONE 
        //Cuantos camiones pueden competir = Usuario ----DONE
        // Valores Adionales para los camiones --- DONE 
        // Nueva clase carrera --- DONE 


        //                     TO DO 

        // Validacion mas de dos camiones por carrera 
        // While para parar cuando el usuario quiera 
        // Como generar valores aleactorios 
        // Atributo posicion y que se asigne Aleactoriamente
        public static void Main(string[] args)
        {

            Console.WriteLine("----- Welcome to the Race -----");
            Console.WriteLine("Select the type of race you want to generate [Truck] for truck type, [Bike] for bike type. ");
            string type = Console.ReadLine();
            Console.WriteLine($"Enter the number of {type}s you want for the race");
            int Number = Convert.ToInt32(Console.ReadLine());

            List<Bike> listBikes = new List<Bike>();
            List<Truck> listTrucks = new List<Truck>();
            switch (type)
            {
                case ("Truck"):


                    for (int i = 1; i <= Number; i++)
                    {
                        Truck truck = new Truck();
                        //TODO::Create single responsibility and enums
                        Console.WriteLine($"Enter the unique id of the {type} number: {i} ");
                        truck.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the {type} model ");
                        truck.ModelVehicle = Console.ReadLine();
                        Console.WriteLine($"Enter the {type} color");
                        truck.Color = Console.ReadLine();
                        //Not funtional response
                        Console.WriteLine("You want to add additional vehicle data? [1] YES/ [0] NO\"");
                        int response = Convert.ToInt32(Console.ReadLine());
                        //-----
                        if (response.Equals(1))
                        {
                            Console.WriteLine("Enter the weight of the truck");
                            truck.Weight = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the number of wheels to the truck");
                            truck.NumberOfWheels = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Write [1] if truck has trailer, write [0] if truck does not have trailer ");
                            truck.Trailer = Convert.ToBoolean(Console.ReadLine);
                            listTrucks.Add(truck);
                        }

                    }
                    break;

                case ("Bike"):


                    for (int i = 1 ; i <= Number; i++)
                    {
                        Bike bike = new Bike();
                        Console.WriteLine($"Enter the unique id of the {type} number: {i} ");
                        bike.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter the {type} model ");
                        bike.ModelVehicle = Console.ReadLine();
                        Console.WriteLine($"Enter the {type} color");
                        bike.Color = Console.ReadLine();
                        Console.WriteLine("You want to add additional vehicle data? [1] YES/ [0] NO");
                        int response = Convert.ToInt32(Console.ReadLine());
                        if (response.Equals(1))
                        {
                            Console.WriteLine("Enter the power of the bike from 1 to 10");
                            bike.PowerBike = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the type of bike");
                            bike.TypeBike = Console.ReadLine();
                        }
                        listBikes.Add(bike);
                    }
                    break;
                default:
                    Console.WriteLine("Error. You selected an incorrect value ");
                    break;
            }

         

            bool listExistBike = listBikes.Count == 0 ? false : true;
            bool listExistTruck = listTrucks.Count == 0 ? false : true;
            Race race = new Race(listBikes);
            race.TypeRace = type;
            race.NumberOfVehicles = Number;
            Console.WriteLine("Enter [1] to start the race");
            bool resp = Console.ReadLine() == "1" ? true : false;
            string info = race.StartRace(resp);
            // Console.WriteLine(race.StartRace(resp));
            Console.WriteLine(info);
        }

    }
}