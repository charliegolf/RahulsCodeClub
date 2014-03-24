using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInDec = 256; 
            int numberInHex = 0x100;
            Console.WriteLine("Int "+numberInDec);
            Console.WriteKine("hex "+numberInHex);
            Console.ReadKey();
        }
    }
}
