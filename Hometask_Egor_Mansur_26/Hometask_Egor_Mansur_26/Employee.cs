using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Employee
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Name}: {Salary:C}";
        }
    }

    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x == null || y == null) return 0;
            return x.Salary.CompareTo(y.Salary);
        }
    }

    class Task8
    {
        public static void Execute()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Алексей", 50000),
                new Employee("Мария", 70000),
                new Employee("Иван", 45000),
                new Employee("Ольга", 60000)
            };

            employees.Sort(new EmployeeComparer());

            Console.WriteLine("Список сотрудников после сортировки по зарплате:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
