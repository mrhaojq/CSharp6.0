using System;
using static System.Console;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Lambda Expressions");
            SimpleDemos();
            WriteLine();

            Closure1();

            ReadKey();
        }

        static void SimpleDemos()
        {
            Func<string, string> oneParam = s => $"change uppercase {s.ToUpper()}";
            WriteLine(oneParam("test"));

            Func<double, double, double> twoParams = (x, y) => x * y;
            WriteLine(twoParams(3, 2));

            Func<double, double,double> twoParamsWithType = (double x, double y) => x * y;
            WriteLine(twoParamsWithType(4, 2));

            Func<double, double> operations = x => x * 2;
            operations += x => x * x;

            ProcessAndDisplayNumber(operations, 2.0);
            ProcessAndDisplayNumber(operations, 7.94);
            ProcessAndDisplayNumber(operations, 1.414);

            
        }

        static void ProcessAndDisplayNumber(Func<double, double> action, double value)
        {
            double result = action(value);
            WriteLine($"Value is {value}, result of operation is {result}");
        }

        static void Closure1()
        {
            //闭包 访问表达式外部的变量

            int someVal = 5;
            Func<int, int> f = x => x + someVal;

            someVal = 7;//建议访问不变的量

            //编译器在编译时 会对表达式的代码块 创建一个你们类 
            //将someVal通过构造函数传递进去
            WriteLine(f(3));
        }
    }
} 
