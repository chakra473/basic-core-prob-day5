using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            double a = 0;
            for (double i = 1; i <= num; i++)
            {
                a = a+1/i;
            }

            Console.WriteLine("{0}th harmonic value is {1}", num, a);

        }
    }
}
