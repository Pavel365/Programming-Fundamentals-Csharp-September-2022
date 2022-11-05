using System;
using System.Collections.Generic;
using System.Linq;

namespace P._11.Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCars; i++)
            {
                cars.Add(new Car(Console.ReadLine().Split()));
            }

            string cargoType = Console.ReadLine();

            if (cargoType == "fragile")
            {
                foreach (var car in cars.Where(c => c.CarsCargo.Type == "fragile"
                                            && c.CarsCargo.Weigth < 1000))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else if (cargoType == "flamable")
            {
                foreach (var car in cars.Where(c => c.CarsCargo.Type == "flamable"
                                            && c.CarsEngine.Power > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }

    public class Car
    {
        public Car(string[] carInfo)
        {
            this.Model = carInfo[0];
            this.CarsEngine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            this.CarsCargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
        }
        public string Model { get; set; }
        public Engine CarsEngine { get; set; }
        public Cargo CarsCargo { get; set; }
    }

    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weigth = weight;
            this.Type = type;
        }
        public int Weigth { get; set; }
        public string Type { get; set; }
    }
}
