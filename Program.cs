using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int i = 2;
            Console.WriteLine("the prime factors of {0} are ",num);

            for (i = 2; i <= num; i++)
            {

                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }

            }
        }
    }
}
