using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the dividend");
            double dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the divisor");
            double divisor=int.Parse(Console.ReadLine());
            double r;double q;
            r= dividend%divisor;
            q= dividend/divisor;
            Console.WriteLine("Quotient is {0}", q);
            Console.WriteLine("Remainder is {0}", r);
           
        }
    }
}
