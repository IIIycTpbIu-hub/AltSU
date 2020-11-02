using AltSU.Task_1;
using AltSU.Task_2;
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

            Console.WriteLine("Task_2");
            var point1 = new Point();
            var point2 = new Point(1, 2, 3);
            var result = point1.DistanceTo(point2);
            Console.WriteLine("Расстояние между двумя точками {0} и {1} равно: {2}", point1, point2, result);
        }
    }
}
