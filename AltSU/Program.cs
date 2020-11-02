using AltSU.Task_1;
using System;

namespace AltSU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            var empl1 = new Employee("Ivan", "Ivanov", "Ivanovich", "Lead .Net developer", "Software development", 200000);
            var empl2 = new Employee("Petr", "Petrov", "Petrovich", "Junior .Net developer", "Software development", 30000);

            Console.WriteLine("{0} {1}", empl1, empl2);
        }
    }
}
