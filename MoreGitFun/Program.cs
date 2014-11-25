using System;

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
            Console.Write("....!");
        }
    }
}
