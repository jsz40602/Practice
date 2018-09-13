using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("type name:");
            string name = Console.ReadLine();
            Console.Write("today's mood ?");
            string status = Console.ReadLine();
            Console.WriteLine(
                "my name is {0}, today's mood is {1}"
                , name
                , status);
        }
    }
}