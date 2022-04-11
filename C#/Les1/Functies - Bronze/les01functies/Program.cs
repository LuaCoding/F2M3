using System;
using System.Threading;

namespace les01functies
{
    class Program
    {
        static void Main(string[] args)
        // BRONZE
        
        {
            Console.WriteLine(helloWorld());
            Thread.Sleep(5000);
        }

        private static string helloWorld()
        {
            return "Hello World!";
        }
    }
}
