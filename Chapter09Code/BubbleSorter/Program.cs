using System;
using static System.Console;

namespace BubbleSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("BubbleSorter");

                Employee[] employees =
                {
                new Employee("Bugs Bunny", 20000),
                new Employee("Elmer Fudd", 10000),
                new Employee("Daffy Duck", 25000),
                new Employee("Wile Coyote", 1000000.38m),
                new Employee("Foghorn Leghorn", 23000),
                new Employee("RoadRunner", 50000)
            };

                BubbleSorter.Sort<Employee>(employees, Employee.CompareSalary);


                foreach (var employee in employees)
                {
                    WriteLine(employee.ToString());
                }

                int[] arrayInt = { 1, 9, 4, 5, 3, 8 };
                BubbleSorter.Sort<int>(arrayInt, CompareInt);

                foreach (var item in arrayInt)
                {
                    WriteLine(item.ToString());
                }

                ReadKey();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        static bool CompareInt(int first, int second) => first < second;
    }
}
