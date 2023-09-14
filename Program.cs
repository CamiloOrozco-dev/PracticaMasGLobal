using Models.Class;
using PracticeMasGlobal.Models;

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
            int number = Convert.ToInt32(Console.ReadLine());
            List<Truck> listTrucks = new List<Truck>();
            List<Bike> listBikes = new List<Bike>();

            switch (type)
            {
                case ("Truck"):
                    for (int i = 1; i <= number; i++)
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
                        Console.WriteLine("You want to add additional vehicle data?");
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

                        }
                        listTrucks.Add(truck);

                    }
                    break;

                case ("Bike"):


                    for (int i = 1; i <= number; i++)
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

            // bool listExist = listObjects.Count == 0 ? false : true;
            if (listTrucks != null)
            {

                Race<Truck> race = new Race<Truck>(listTrucks);
                race._EnlistedTrucks = listTrucks;
                race.TypeRace = type;
                race.NumberOfVehicles = number;
                Console.WriteLine("enter [1] to start the race");
                bool resp = Console.ReadLine() == "1" ? true : false;
                string info = race.startRace(resp, listTrucks);
                // Console.WriteLine(race.startrace(resp));
                Console.WriteLine(info);


            }
            //Race<listObjects> race =  listTrucks>;
            //Race<Bike> race = new Race<Bike>(listObjects);


        }

    }
}