using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a man? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                bool IAmAMan = true;
                Console.Write("It is " + IAmAMan + " I am a man!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Oh no, I'm a woman!");
                Console.ReadKey();
            }

        }
    }
}
