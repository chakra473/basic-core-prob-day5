using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                Console.WriteLine("{0} is leap year",year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year",year);
            }
        }
    }
}
