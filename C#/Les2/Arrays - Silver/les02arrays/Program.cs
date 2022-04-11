using System;
using System.Threading;

namespace les02arrays
{
    class Program
    {
        // SILVER
        static void Main(string[] args)
        {
            Int32[] nummers = { 10, 20, 30, 40, 50, 60 };
            Int32 eindGetal = 0;

            for (int i = 0; i < nummers.Length; i++)
            {
                eindGetal = eindGetal + nummers[i];
                Console.WriteLine(eindGetal);
            }
        Thread.Sleep(5000);
        }
    }
}
