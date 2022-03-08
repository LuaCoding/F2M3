using System;
using System.Threading;

namespace les02variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int eenGetal = 1;
            float eenKommaGetal = (float)eenGetal; // Conversion door casting

            int nieuwGetal = 75;
            char nieuwChar = (char)nieuwGetal; // Converteerd 75 naar ASCII character code. Dus de letter K.

            Console.WriteLine(Convert.ToChar(nieuwChar));
            Thread.Sleep(5000);
        }
    }
}
