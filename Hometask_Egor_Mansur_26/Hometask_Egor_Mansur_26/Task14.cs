using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Task14
    {
        public static void Execute()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Func<int, bool> filter = x => x % 2 == 0;
            Func<int, int> transform = x => x * x;

            List<int> filteredNumbers = ProcessData(numbers, filter);
            List<int> transformedNumbers = ProcessData(numbers, transform);

            Console.WriteLine("Чётные числа: " + string.Join(", ", filteredNumbers));
            Console.WriteLine("Квадраты чисел: " + string.Join(", ", transformedNumbers));
        }

        public static List<T> ProcessData<T>(List<T> data, Func<T, T> operation)
        {
            return data.Select(operation).ToList();
        }

        public static List<T> ProcessData<T>(List<T> data, Func<T, bool> condition)
        {
            return data.Where(condition).ToList();
        }
    }
}
