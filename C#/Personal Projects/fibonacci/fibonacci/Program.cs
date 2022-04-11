using System;
using System.Threading;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            for(int i=0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        Thread.Sleep(5000);
        }
    }
}
