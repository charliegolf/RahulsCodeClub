using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please a real number ");
            decimal real1 = Convert.ToDecimal(Console.ReadLine());
            float float1 = (float)real1;
            Console.WriteLine("Please neter another real number ");
            decimal real2 = Convert.ToDecimal(Console.ReadLine());
            float float2 = (float)real2;

            bool equal = Math.Abs(float1 - float2) > 0.000001;
            if (equal == false)
            {
                Console.WriteLine("Your two numbers are within 0.000001 of each other.");
            }
            else
            {
                Console.WriteLine("Your two numbers are not within 0.000001 of each other.");
            }
            Console.ReadKey();
        }
    }
}
