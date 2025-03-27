using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Task10
    {
        public static void Execute()
        {
            int a = 5, b = 10;
            Console.WriteLine($"До обмена: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b}");

            string x = "Hello", y = "World";
            Console.WriteLine($"\nДо обмена: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После обмена: x = {x}, y = {y}");

            Item p1 = new Item("Ноутбук", 100000);
            Item p2 = new Item("Смартфон", 50000);
            Console.WriteLine($"\nДо обмена: p1 = {p1}, p2 = {p2}");
            Swap(ref p1, ref p2);
            Console.WriteLine($"После обмена: p1 = {p1}, p2 = {p2}");
        }

        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }

    class Item
    {
        public string Name { get; }
        public decimal Price { get; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}: {Price:C}";
        }
    }
}
