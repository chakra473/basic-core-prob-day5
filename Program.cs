using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the dividend");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the divisor");
            int divisor=int.Parse(Console.ReadLine());
            int r, q;
            r= dividend%divisor;
            q= dividend/divisor;
            Console.WriteLine("Quotient is {0}", q);
            Console.WriteLine("Remainder is {0}",r);
           
        }
    }
}
