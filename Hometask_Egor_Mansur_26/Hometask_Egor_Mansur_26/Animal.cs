using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Task1
    {
        public static void Execute()
        {
            List<Animal> animals = new List<Animal> { new Dog("Бобик", 3), new Cat("Мурка", 2) };
            foreach (var animal in animals)
            {
                animal.Speak();
            }
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Speak()
        {
            Console.WriteLine("Животное издаёт звук");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void Speak()
        {
            Console.WriteLine("Гав! Гав!");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void Speak()
        {
            Console.WriteLine("Мяу! Мяу!");
        }
    }
}




