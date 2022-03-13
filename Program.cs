using System;

namespace basic_core_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter an alphabet to check whether it is vowel or not");
            char vowel=char.Parse(Console.ReadLine());
            switch (vowel)
            {
                case 'a':Console.WriteLine("a is vowel");break;
                    case 'e':Console.WriteLine("e is vowel");break;
                case 'i':Console.WriteLine("i is vowel");break;
                case 'o':Console.WriteLine("o is vowel");break;
                case 'u':Console.WriteLine("u is vowel");break;
                    default:Console.WriteLine("{0} is consonant",vowel);break;
            }

           
            
        }
    }
}
