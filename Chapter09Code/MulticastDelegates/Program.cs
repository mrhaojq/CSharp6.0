using System;
using static System.Console;

namespace MulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("MulticastDelegates");

            Action<double> operations = MathOperations.MultiplyByTwo;
            operations += MathOperations.Square;

            ProcessAndDisplayNumber(operations, 2.0);
            ProcessAndDisplayNumber(operations, 7.94);
            ProcessAndDisplayNumber(operations, 1.414);
            WriteLine();

            //多播委托安顺序执行，如果发生错误，会停止执行后边的方法
            //为避免这种情况，应自己迭代方法列表
            Action d1 = One;
            d1 += Two;

            try
            {
                d1.Invoke();
            }
            catch (Exception ex)
            {

                WriteLine($"Exception caught:{ex.Message}");
            }

            //为避免这种情况，应自己迭代方法列表
            Delegate[] delegates = d1.GetInvocationList();
            foreach (Action d in delegates)
            {
                try
                {
                    d();
                    //d.Invoke();
                }
                catch (Exception ex)
                {
                    WriteLine($"Exception caught:{ex.Message}");
                }
            }

            ReadKey();

        }

        static void ProcessAndDisplayNumber(Action<double> action, double value)
        {
            WriteLine();
            WriteLine($"ProcessAndDisplayNumber called with value ={ value}");
            action(value);
        }

        static void One()
        {
            WriteLine("One");
            throw new Exception("Error in one");
        }

        static void Two()
        {
            WriteLine("Two");
        }
    }
}
