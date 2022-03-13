using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the two number to be swaped");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            Console.WriteLine("before swapping a={0},b={1}",a,b);
            a = b;
            b = c;
            Console.WriteLine("after swapping  a={0},b={1}",a,b);

            
        }
    }
}
