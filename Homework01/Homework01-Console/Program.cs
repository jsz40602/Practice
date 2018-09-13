using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Type : ");
            string type = Console.ReadLine();
            Console.Write("Species : ");
            string species = Console.ReadLine();

            Console.WriteLine("Pokemon 001 is {0} , Type is {1} , Species is {2}", name, type, species);
        }
    }
}