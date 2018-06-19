using System;
using static System.Console;

namespace SimpleDelegates
{
    class Program
    {
        delegate double DoubleOp(double x);

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Delegates");

            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };


            for (int i = 0; i < operations.Length; i++)
            {
                WriteLine($"Using operations[{i}]:");
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                WriteLine();
            }


            //Action<T> Func<T> 泛型委托 
            Func<double, double>[] operations1 =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            WriteLine("泛型委托");
            for (int i = 0; i < operations1.Length; i++)
            {
                WriteLine($"Using operations1[{i}]:");
                ProcessAndDisplayNumber1(operations1[i], 2.0);
                ProcessAndDisplayNumber1(operations1[i], 7.94);
                ProcessAndDisplayNumber1(operations1[i], 1.414);
                WriteLine();
            }

            ReadKey();
        }

        /// <summary>
        /// 把操作应用到值上 把算法应用到数据上
        /// </summary>
        /// <param name="action">委托</param>
        /// <param name="value">带处理的值</param>
        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            //action 代表接收一个double参数 返回double值的一个委托
            //在这里action代表 委托绑定的具体实现方法 具体的算法
            WriteLine($"Value is {value},result of operation is {result}");
        }

        static void ProcessAndDisplayNumber1(Func<double,double> action,double value)
        {
            double result = action(value);
            //action 代表接收一个double参数 返回double值的一个委托
            //在这里action代表 委托绑定的具体实现方法 具体的算法
            WriteLine($"Value is {value},result of operation is {result}");
        }
    }
}
