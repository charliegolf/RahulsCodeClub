﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCastToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string castFromObject = (string)helloWorld;
            Console.Write(castFromObject);
            Console.ReadKey();
        }
    }
}
