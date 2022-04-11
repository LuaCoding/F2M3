using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = Convert.ToInt32(Console.ReadLine());

            switch (myInt)
            {
                case 0:
                    Console.WriteLine("hallo, dit is case 0");
                    break;
                default:
                    Console.WriteLine("hallo, dit is de default case");
                    break;
            }
        }
    }
}