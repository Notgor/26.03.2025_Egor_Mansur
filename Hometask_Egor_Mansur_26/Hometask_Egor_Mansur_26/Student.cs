using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Student : IComparable<Student>
    {
        public string Name { get; }
        public int Grade { get; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Grade.CompareTo(other.Grade);
        }

        public override string ToString()
        {
            return $"{Name}: {Grade}";
        }
    }

    class Task7
    {
        public static void Execute()
        {
            List<Student> students = new List<Student>
            {
                new Student("Алексей", 85),
                new Student("Мария", 92),
                new Student("Иван", 78),
                new Student("Ольга", 88)
            };

            students.Sort();

            Console.WriteLine("Список студентов после сортировки по оценкам:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}

