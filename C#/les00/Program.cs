using System;
using System.Threading;

namespace les00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string hello = "Hello World!";
            foreach (char c in hello)
            {
                Console.WriteLine(c);
                Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
