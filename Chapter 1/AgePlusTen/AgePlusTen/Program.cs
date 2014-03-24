using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgePlusTen
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();
            int ageAsInt = int.Parse(age);
            int newAge = ageAsInt+10;
            DateTime today = System.DateTime.Now;
            DateTime newDate = today.AddYears(10);
            Console.Write("On " + newDate+" you will be "+newAge);
            Console.ReadKey();
        }
    }
}
