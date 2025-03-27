using Hometask_Egor_Mansur_26;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания (от 1 до 15) или 0 для выхода:");
                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    if (taskNumber == 0) break;

                    switch (taskNumber)
                    {
                        case 1:
                            Task1.Execute();
                            break;
                        case 2:
                            Task2.Execute();
                            break;
                        case 3:
                            Task3.Execute();
                            break;
                        case 4:
                            Task4.Execute();
                            break;
                        case 5:
                            Task5.Execute();
                            break;
                        case 6:
                            Task6.Execute();
                            break;
                        case 7:
                            Task7.Execute();
                            break;
                        case 8:
                            Task8.Execute();
                            break;
                        case 9:
                            Task9.Execute();
                            break;
                        case 10:
                            Task10.Execute();
                            break;
                        case 11:
                            Task11.Execute();
                            break;
                        case 12:
                            Task12.Execute();
                            break;
                        case 13:
                            Task13.Execute();
                            break;
                        case 14:
                            Task14.Execute();
                            break;
                        case 15:
                            Task15.Execute();
                            break;
                        default:
                            Console.WriteLine("некорректный номер задания.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }
        }
    }
}

