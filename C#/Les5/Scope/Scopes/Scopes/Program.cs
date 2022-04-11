using System;

namespace scopes
{
    internal class Program
    {
        public static void call()
        {
            {
                bool x = true;
                Console.WriteLine(x);
            }
        }
        static void Main(string[] args)
        {
            call();
        }
    }
}