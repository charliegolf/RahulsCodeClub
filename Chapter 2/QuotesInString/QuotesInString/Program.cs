using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string withQuotes = "The\"use\" of quotations causes difficulties.";
            string withoutQuotes = "The use of quotations causes difficulties.";
            Console.WriteLine(withQuotes);
            Console.WriteLine(withoutQuotes);
            Console.ReadKey();
        }
    }
}
