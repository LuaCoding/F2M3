using System;
using System.Threading;

namespace les01return
{
    class Program
    {
        // BRONZE
        static void Main(string[] args)
        {
            Console.WriteLine(myName());
            Thread.Sleep(5000);
        }
        private static string myName()
        {
            return "Justin";
        }
    }
}
