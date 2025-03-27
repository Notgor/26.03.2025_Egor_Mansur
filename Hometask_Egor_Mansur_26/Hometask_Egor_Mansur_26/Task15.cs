using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    abstract class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public virtual string Describe()
        {
            return $"Модель: {Model}, Год: {Year}";
        }
    }

    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string model, int year, int numberOfDoors)
            : base(model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override string Describe()
        {
            return base.Describe() + $", Количество дверей: {NumberOfDoors}";
        }
    }

    class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public Truck(string model, int year, double loadCapacity)
            : base(model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public override string Describe()
        {
            return base.Describe() + $", Грузоподъёмность: {LoadCapacity} тонн";
        }
    }

    class Task15
    {
        public static void Execute()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Toyota Corolla", 2020, 4),
                new Truck("Volvo FH16", 2018, 25)
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Describe());
            }
        }
    }
}
