using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int head = 0;
            int tail = 0;
            Random rand = new Random();

            int i = 1;
            while (i <= 100)
            {
                int random = rand.Next(0, 2);
                if (random == 0)
                {
                    head++;

                }
                else
                {
                    tail++;

                }
                i++;



            }
            Console.WriteLine("number of heads :" + head);
            Console.WriteLine("number of tails :" + tail);
            Console.WriteLine("percentage of heads is {0}%", head);
            Console.WriteLine("percentage of tails is {0}%", tail);
        }
    }
}
