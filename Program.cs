using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int a = 1
               ;
            for (int i = 1; i <= num; i++)
            {
                a = a * 2;
            }

            Console.WriteLine("2 power of {0} is {1}", num, a);

        }
    }
}
