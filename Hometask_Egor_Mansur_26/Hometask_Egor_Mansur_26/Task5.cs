using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    delegate int ArithmeticOperation(int a, int b);

    class Task5
    {
        public static void Execute()
        {
            ArithmeticOperation add = (a, b) => a + b;
            ArithmeticOperation subtract = (a, b) => a - b;
            ArithmeticOperation multiply = (a, b) => a * b;

            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию (1 - сложение, 2 - вычитание, 3 - умножение):");
            int choice = int.Parse(Console.ReadLine());

            ArithmeticOperation operation = choice switch
            {
                1 => add,
                2 => subtract,
                3 => multiply,
                _ => null
            };

            if (operation != null)
            {
                Console.WriteLine($"Результат: {operation(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Некорректный выбор операции.");
            }
        }
    }
}


