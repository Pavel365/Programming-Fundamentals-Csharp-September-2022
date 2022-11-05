using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace P._06.VehiCata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string typeOfVehicle = cmdArgs[0];
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                int horsePower = int.Parse(cmdArgs[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                vehicles.Add(vehicle);
            }

            string command2;
            while ((command2 = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle1 in vehicles)
                {
                    if (vehicle1.Model == command2 && vehicle1.Type == "car")
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {vehicle1.Model}");
                        Console.WriteLine($"Color: {vehicle1.Color}");
                        Console.WriteLine($"Horsepower: {vehicle1.HorsePower}");
                    }
                    else if (vehicle1.Model == command2 && vehicle1.Type == "truck")
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {vehicle1.Model}");
                        Console.WriteLine($"Color: {vehicle1.Color}");
                        Console.WriteLine($"Horsepower: {vehicle1.HorsePower}");
                    }
                }
            }

            List<Vehicle> onlyCars = vehicles
                       .Where(x => x.Type == "car")
                        .ToList();
            List<Vehicle> onlyTrucks = vehicles
                        .Where(x => x.Type == "truck")
                        .ToList();

            decimal tottalCarHP = 0;
            decimal tottalTruckHp = 0;

            foreach (Vehicle car in onlyCars)
            {
                tottalCarHP += car.HorsePower;
            }
            foreach (Vehicle truck in onlyTrucks)
            {
                tottalTruckHp += truck.HorsePower;
            }

            decimal averageCarHP = 0;
            decimal averageTrucksHp = 0;

            if (onlyCars.Count == 0)
            {
                averageCarHP = 0m;
            }
            else
            {
                averageCarHP = tottalCarHP / onlyCars.Count;
            }

            if (onlyTrucks.Count == 0)
            {
                averageTrucksHp = 0m;
            }
            else
            {
                averageTrucksHp = tottalTruckHp / onlyTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHp:F2}.");
            
        }
    }

    public class Vehicle
    { 
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model {get; set;}  
        public string Color {get; set;}
        public int HorsePower {get; set;}
    }
}
