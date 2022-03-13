using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            if(a>b&&a>c)
            {
                Console.WriteLine("{0} is greatest among three numbers ",a);
            }
            else if(b>c)
            {
                Console.WriteLine("{0} is greatest among three numbers",b);
            }
            else
            {
                Console.WriteLine("{0} is greatest among three numbers", c);
            }
            

           
            
        }
    }
}
