using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            int next = 0;
            while (total < 1000)
            {
                //next++;
                //total += next;
                total += ++(next);
            }
            Console.WriteLine("Total:{0}", total);
            Console.WriteLine("Next:{0}", next);
        }
    }
}