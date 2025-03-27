using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T Find(Predicate<T> match)
        {
            return items.Find(match);
        }

        public void DisplayAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}: {Price:C}";
        }
    }

    class Task9
    {
        public static void Execute()
        {
            Repository<Product> productRepo = new Repository<Product>();
            productRepo.Add(new Product("Ноутбук", 100000));
            productRepo.Add(new Product("Смартфон", 50000));
            productRepo.Add(new Product("Наушники", 10000));

            Console.WriteLine("Список продуктов:");
            productRepo.DisplayAll();

            Console.WriteLine("\nПоиск смартфона:");
            var foundProduct = productRepo.Find(p => p.Name == "Смартфон");
            Console.WriteLine(foundProduct != null ? foundProduct.ToString() : "Не найден");
        }
    }
}

