using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreGitFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Printer("Yet More changes");
            Console.ReadLine();
        }

        private static void Printer(string arg)
        {
            Console.WriteLine(arg);
        }
    }
}
