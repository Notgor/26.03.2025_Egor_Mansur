using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} издаёт неопределённый звук.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} говорит: \"Гав!\"");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} говорит: \"Мяу!\"");
        }
    }

    // Демонстрация полиморфизма
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
        {
            new Dog { Name = "Бобик", Age = 3 },
            new Cat { Name = "Мурка", Age = 2 }
        };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} ({animal.Age} года) говорит:");
                animal.Speak();
            }
        }
    }
}




