using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void WriteHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            // zavolanie metody write hello world
            WriteHelloWorld();
            // zmena stringu vo writeline
            Console.WriteLine("Hello World new version!");
            Console.ReadKey();
            // novy commit
        }
    }
}
