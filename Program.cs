using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to check whether it is even or odd");
            int n=int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} is an even number ", n);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", n);

            }
            
        }
    }
}
