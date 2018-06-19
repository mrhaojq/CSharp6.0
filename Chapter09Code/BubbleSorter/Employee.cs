using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSorter
{
    class Employee
    {

        public string Name { get; }
        public decimal Salary { get; private set; }

        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString() => $"{Name},{Salary:C}";

        /// <summary>
        /// 定义比较算法
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool CompareSalary(Employee e1, Employee e2) => e1.Salary < e2.Salary;
    }
}
