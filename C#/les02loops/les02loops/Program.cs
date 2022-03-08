using System;
using System.Threading;

namespace les02loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Convert.ToString(i+1)+" Hello! My name is Justin!");
                Thread.Sleep(10);
            }
         Thread.Sleep(5000);
        }
    }
}   
